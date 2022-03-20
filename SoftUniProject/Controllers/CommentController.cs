using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.Models.AdminModels;
using Web.Models.RecipeModels;

namespace Web.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly IRecipeService _recipesService;
        private readonly IAdminService _adminService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ICommentService _commentService;
        private readonly IImageService _imageService;

        public CommentController(
           IRecipeService recipesService,
           IAdminService adminService,
           UserManager<IdentityUser> userManager,
           ICommentService commentService,
           IImageService imageService)
        {
            this._recipesService = recipesService;
            this._adminService = adminService;
            this._userManager = userManager;
            this._commentService = commentService;
            this._imageService = imageService;
        }
        [HttpGet]
        public IActionResult All(string id)
        {
            var recipe =  this._recipesService.Read(Guid.Parse(id));
            var allComments = this._commentService.FindAll();
            var commentsForRecipe = allComments.Where(x => x.RecipeId == Guid.Parse(id)).ToList();
            var recipeCommentsViewModel = commentsForRecipe.Select(x => new CommentViewModel
            {
                Id=x.Id,
                RecipeId = x.RecipeId,
                Description = x.Description,
                CreatedOn = x.CreatedOn,
                ImageUrl = x.ImageUrl,
                RecipeName = x.RecipeName,
            }).ToList();

            this.ViewData["RecipeId"] = id;
            foreach (var commentModel in recipeCommentsViewModel)
            {
                commentModel.RecipeName = recipe.Name;
                commentModel.RecipeId = recipe.Id;
                commentModel.ImageUrl = recipe.ImageUrl;

            }
            for (int i = 0; i < recipeCommentsViewModel.Count; i++)
            {
                for (int j = 0; j < commentsForRecipe.Count; j++)
                {
                    var user =  _userManager.FindByIdAsync(commentsForRecipe[j].IdentityUserId).Result;
                    var userEmail = user.Email;
                    recipeCommentsViewModel[i].SenderEmail = userEmail;
                    i++;
                }
                break;
            }
            if (recipeCommentsViewModel.Count == 0)
            {
                recipeCommentsViewModel.Add(new CommentViewModel
                {
                    RecipeId = Guid.Parse(id),
                    RecipeName = recipe.Name,
                    ImageUrl = recipe.ImageUrl
                });
            }
            var recipeViewModel = new RecipeViewModel {Id = recipe.Id.ToString() };

            var imagesPaths =  _imageService.PopulateRecipeViewModelImages(recipe.Id);
            recipeCommentsViewModel[0].ImagesFilePaths = imagesPaths;
            return View(recipeCommentsViewModel);
        }

        [HttpPost]

        public IActionResult Add(CommentSendModel model)
        {
            var allUsers = this._adminService.GetAllUsersAsync();
            var usersViewModels = allUsers.Select(x => new UserDetailsViewModel
            {
                Id = x.Id,
                Email = x.Email,
                Role = x.Role
            });
            var isUserRegistered = allUsers.FirstOrDefault(x => x.Email == model.SenderEmail);
            var user =  this._userManager.GetUserAsync(HttpContext.User).Result;
            var currentUserEmail = user.Email;
            var userID = user.Id;
            if (!ModelState.IsValid)
            {
                return Json(new { success = false, message = "Please insert valid form data!" });
            }
            if (currentUserEmail != model.SenderEmail)
            {
                return Json(new { success = false, message = "You cannot add comment from other users emails" });
            }
            if (isUserRegistered == null)
            {
                return Json(new { success = false, message = "There isn't registered user w*-ith this Email address!" });
            }
            var comment = new CommentServiceModel
            {
                Description = model.CommentMessage,
                RecipeId = Guid.Parse(model.RecipeId),
                IdentityUserId = userID,
                CreatedOn = DateTime.Now.ToString(),

            };
            var recipe = this._recipesService.Read(Guid.Parse(model.RecipeId));
            recipe.NumberOfComments++;
            this._recipesService.Update(recipe);
            this._commentService.Create(comment);
            model.CommentCreation = DateTime.Now.ToShortDateString();
            return Json(new { success = true, message = "You have added successfully a comment", commentModel = model });
        }
    }
}
