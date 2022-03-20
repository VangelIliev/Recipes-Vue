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
    public class CategoryController : Controller
    {
        private readonly IRecipeService _recipesService;
        private readonly ICategoryService _categoryService;
        private readonly IImageService _imageService;
        private readonly ILikeService _likeService;
        private readonly ICommentService _commentService;
        private readonly IRecipeDislikeService _recipeDislikesService;
        private readonly UserManager<IdentityUser> _userManager;

        public CategoryController(
            IRecipeService recipesService,
            ICategoryService categoryService,
            IImageService imageService,
            ILikeService likeService,
            IRecipeDislikeService recipeDislikesService,
            UserManager<IdentityUser> userManager,
            ICommentService commentService)
        {
            _recipesService = recipesService;
            _categoryService = categoryService;
            _imageService = imageService;
            _likeService = likeService;
            _recipeDislikesService = recipeDislikesService;
            _userManager = userManager;
            _commentService = commentService;
        }

        public IActionResult Filter(string id)
        {
            var recipesModels = _recipesService.FindAll();
            var recipeViewModels = new List<RecipeViewModel>();
            foreach (var model in recipesModels.Where(x => x.CategoryId == Guid.Parse(id)).ToList())
            {
                var recipe = _recipesService.Read(model.Id);
                var userName = _userManager.FindByIdAsync(recipe.ApplicationUserId).Result;
                //All likes
                var allLlikesOfRecipes =  _likeService.FindAll();
                var currentRecipeLikes = allLlikesOfRecipes.Where(x => x.RecipeId == model.Id).ToList();
                var currentRecipeLikesCount = currentRecipeLikes.Count();

                //All Dislikes
                var allDisLlikesOfRecipes = _recipeDislikesService.FindAll();
                var currentRecipeDisLikes = allDisLlikesOfRecipes.Where(x => x.RecipeId == model.Id).ToList();
                var currentRecipeDisLikesCount = currentRecipeDisLikes.Count();

                var numberOfLikes = currentRecipeLikesCount - currentRecipeDisLikesCount;
                var currentRecipeComments =  _commentService.FindAll();
                var currentRecipeCommentsCount = currentRecipeComments.Where(x => x.RecipeId == model.Id).ToList().Count();
                var recipeViewModel = new RecipeViewModel
                {
                    Id = recipe.Id.ToString(),
                    PreparationDescription = recipe.PreparationDescription,
                    TimeToPrepare = recipe.TimeToPrepare,
                    CreatedBy = userName.Email,
                    NumberOfComments = recipe.NumberOfComments,
                    NumberOfLikes = numberOfLikes,
                    Name = recipe.Name
                };
                var imagesPaths = _imageService.PopulateRecipeViewModelImages(recipe.Id);
                recipeViewModel.ImagesFilePaths = imagesPaths;
                recipeViewModels.Add(recipeViewModel);
            }
            return View(recipeViewModels);

        }

        [HttpGet]
        public ActionResult AddCategory()
        {

            return View("AddCategory");
        }

        [HttpPost]

        public IActionResult AddCategory(AddCategoryViewModel model)
        {
            var categoryModel = new CategoryServiceModel
            {
                Id = model.Id,
                Name = model.Name,
            };
             _categoryService.Create(categoryModel);
            this.TempData["Message"] = "Successfully added category!";
            return Redirect("/Recipes/All");
        }

        [HttpGet]
        public  IActionResult RemoveCategory()
        {
            var categories =  _categoryService.FindAll();
            var selectList = new Dictionary<string, string>();
            foreach (var category in categories)
            {
                selectList.Add(category.Name, category.Id.ToString());
            }
            var removeCategoryModel = new RemoveCategoryViewModel
            {
                Categories = selectList
            };
            return View(removeCategoryModel);
        }

        [HttpPost]
        public IActionResult RemoveCategory(RemoveCategoryViewModel model)
        {
            var category = _categoryService.Read(Guid.Parse(model.Id));
            this._categoryService.Delete(category);
            this.TempData["Message"] = "Successfully removed category !";
            return RedirectToAction("All", "Recipes");
        }
    }
}
