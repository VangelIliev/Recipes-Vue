using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Linq;

namespace Web.Controllers
{
    [Authorize]
    public class LikesController : Controller
    {
        private readonly ILikeService _likeService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IRecipeService _recipesService;
        private readonly IRecipeDislikeService _recipeDislikesService;
        public LikesController(
            ILikeService likeService,
            UserManager<IdentityUser> userManager,
            IRecipeService recipesService,
            IRecipeDislikeService recipeDislikesService)
        {
            this._likeService = likeService;
            this._userManager = userManager;
            this._recipesService = recipesService;
            this._recipeDislikesService = recipeDislikesService;
        }
        [HttpPost]
        public IActionResult LikeRecipe(string id)
        {
            try
            {
                var likes = _likeService.FindAll();
                var likesForCurrentRecipe = likes.Where(x => x.RecipeId == Guid.Parse(id)).ToList();
                var recipe = this._recipesService.Read(Guid.Parse(id));
                var dislikes = _recipeDislikesService.FindAll();
                var user = this._userManager.GetUserAsync(HttpContext.User).Result;
                var userID = user.Id;
                var isRecipeLikedByUser = likesForCurrentRecipe.Any(x => x.ApplicationUserId == userID);
                if (isRecipeLikedByUser)
                {
                    return Json(new { success = false, message = "You have already liked this recipe !!" });
                }
                var isDislikedByUser = dislikes.Any(x => x.ApplicationUserId == userID);

                if (isDislikedByUser)
                {
                    var dislikesForCurrentRecipe = dislikes.Where(x => x.RecipeId == Guid.Parse(id)).ToList();
                    var dislikesWithUser = dislikesForCurrentRecipe.FirstOrDefault(x => x.ApplicationUserId == userID);
                    this._recipeDislikesService.Delete(dislikesWithUser);
                    return Json(new { success = true, id = id });
                }
                var likeModel = new LikeServiceModel
                {
                    RecipeId = Guid.Parse(id),
                    ApplicationUserId = userID,
                };

                this._likeService.Create(likeModel);
                return Json(new { success = true, id = id });
            }
            catch (Exception)
            {

                return RedirectToAction("CustomError", "Errors");
            }

        }

        [HttpPost]
        public IActionResult DisLikeRecipe(string id)
        {
            try
            {
                var dislikes = _recipeDislikesService.FindAll();
                var dislikesForCurrentRecipe = dislikes.Where(x => x.RecipeId == Guid.Parse(id)).ToList();
                var recipe = _recipesService.Read(Guid.Parse(id));

                var likes = _likeService.FindAll();
                var user = this._userManager.GetUserAsync(HttpContext.User).Result;
                var userID = user.Id;
                var isRecipeDislikes = dislikesForCurrentRecipe.Any(x => x.ApplicationUserId == userID);
                if (isRecipeDislikes)
                {
                    return Json(new { success = false, message = "You have already disliked this recipe" });
                }
                var isLikedRecipe = likes.Any(x => x.ApplicationUserId == userID);
                if (isLikedRecipe)
                {
                    var likesForCurrentRecipe = likes.Where(x => x.RecipeId == Guid.Parse(id)).ToList();
                    var likesWithUser = likesForCurrentRecipe.FirstOrDefault(x => x.ApplicationUserId == userID);
                    this._likeService.Delete(likesWithUser);
                    return Json(new { success = true, id = id });
                }
                var dislikedRecipe = new RecipeDislikeServiceModel
                {
                    ApplicationUserId = userID,
                    RecipeId = Guid.Parse(id)
                };
                _recipeDislikesService.Create(dislikedRecipe);
                return Json(new { success = true, id = id });
            }
            catch (Exception)
            {
                return RedirectToAction("CustomError", "Errors");
            }

        }

    }
}
