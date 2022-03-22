using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Web.Models.RecipeModels;

namespace Web.Controllers
{
    public class RecipeController : Controller
    {
        private readonly IRecipeService _recipeService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILikeService _likeService;
        private readonly ICommentService _commentService;
        private readonly IRecipeDislikeService _recipeDislikesService;
        private readonly IProductService _productService;
        private readonly IRecipeProductService _recipeProductsService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IImageService _imageService;

        public RecipeController(
            IRecipeService recipesService,
            ICategoryService categoryService,
            UserManager<IdentityUser> userManager,
            ILikeService likeService,
            ICommentService commentService,
            IRecipeDislikeService recipeDislikesService,
            IProductService productService,
            IRecipeProductService recipeProductsService,
            IImageService imageService,
            IWebHostEnvironment webHostEnvironment)
        {
            this._recipeService = recipesService;
            this._categoryService = categoryService;
            this._userManager = userManager;
            this._likeService = likeService;
            this._commentService = commentService;
            this._recipeDislikesService = recipeDislikesService;
            this._productService = productService;
            this._recipeProductsService = recipeProductsService;
            this._imageService = imageService;
            this._webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult All()
        {
            try
            {
                var recipesModels =  _recipeService.FindAll();
                var recipeViewModels = new List<RecipeViewModel>();
                foreach (var model in recipesModels)
                {
                    var recipe = _recipeService.Read(model.Id);
                    var userName = _userManager.FindByIdAsync(recipe.ApplicationUserId).Result;
                    //All likes
                    var allLlikesOfRecipes = _likeService.FindAll();
                    var currentRecipeLikes = allLlikesOfRecipes.Where(x => x.RecipeId == model.Id).ToList();
                    var currentRecipeLikesCount = currentRecipeLikes.Count();

                    //All Dislikes
                    var allDisLlikesOfRecipes = _recipeDislikesService.FindAll();
                    var currentRecipeDisLikes = allDisLlikesOfRecipes.Where(x => x.RecipeId == model.Id).ToList();
                    var currentRecipeDisLikesCount = currentRecipeDisLikes.Count();

                    var numberOfLikes = currentRecipeLikesCount - currentRecipeDisLikesCount;
                    var currentRecipeComments = _commentService.FindAll();
                    var currentRecipeCommentsCount = currentRecipeComments.Where(x => x.RecipeId == model.Id).ToList().Count();
                    var recipeViewModel = new RecipeViewModel
                    {
                        Id = recipe.Id.ToString(),
                        PreparationDescription = recipe.PreparationDescription,
                        TimeToPrepare = recipe.TimeToPrepare,
                        CreatedBy = userName.Email,
                        NumberOfComments = currentRecipeCommentsCount,
                        NumberOfLikes = numberOfLikes,
                        Name = recipe.Name
                    };
                    var imagesPaths = _imageService.PopulateRecipeViewModelImages(recipe.Id);
                    recipeViewModel.ImagesFilePaths = imagesPaths;
                    recipeViewModels.Add(recipeViewModel);

                }
                return View(recipeViewModels);
            }
            catch (Exception)
            {

                return RedirectToAction("CustomError", "Errors");
            }

        }

        [HttpGet]
        [Authorize]
        public IActionResult Own()
        {
            var recipes = _recipeService.FindAll();
            var user = this._userManager.GetUserAsync(HttpContext.User).Result;
            var userID = user.Id;
            var recipesOfUser = recipes.Where(x => x.ApplicationUserId == userID).ToList();

            var recipeViewModels = recipesOfUser.Select(x => new RecipeViewModel
            {
                Id = x.Id.ToString(),
                Name = x.Name,
                NumberOfComments = x.NumberOfComments,
                NumberOfLikes = x.Likes.Count(),
                PreparationDescription = x.PreparationDescription,
                CategoryId = x.CategoryId.ToString()
            });
            var recipeViewModelsList = new List<RecipeViewModel>();
            foreach (var model in recipeViewModels)
            {
                var imagesPaths = _imageService.PopulateRecipeViewModelImages(Guid.Parse(model.Id));
                model.ImagesFilePaths = imagesPaths;
                recipeViewModelsList.Add(model);
            }
            return View(recipeViewModelsList);
        }
        [HttpGet]
        [Authorize]
        public IActionResult Details(string id)
        {
            var recipe = _recipeService.Read(Guid.Parse(id));
            var categories = _categoryService.FindAll();
            var categoryForRecipe = categories.FirstOrDefault(x => x.Id == recipe.CategoryId);
            var recipeLikes = _likeService.FindAll();
            var likesCount = recipeLikes.Where(x => x.RecipeId == Guid.Parse(id)).Count();
            var recipeIngredients = _recipeProductsService.FindAll();
            var recipeIngredientsForCurrentRecipe = recipeIngredients.Where(x => x.RecipeId == recipe.Id).ToList();
            var recipeIngredientsList = new List<RecipeIngredientInputModel>();
            foreach (var recipeIngredient in recipeIngredientsForCurrentRecipe)
            {
                var ingredient = _productService.Read(recipeIngredient.ProductId);
                recipeIngredientsList.Add(new RecipeIngredientInputModel
                {
                    IngredientName = ingredient.Name,
                    Quantity = recipeIngredient.Quantity
                });
            }
            var recipeViewModel = new RecipeViewModel
            {
                Id = recipe.Id.ToString(),
                PreparationDescription = recipe.PreparationDescription,
                NumberOfLikes = recipe.Likes.Count(),
                NumberOfComments = recipe.NumberOfComments,
                PortionsSize = recipe.PortionsSize,
                CategoryId = recipe.CategoryId.ToString(),
            };

            var imagesPaths = _imageService.PopulateRecipeViewModelImages(recipe.Id);
            recipeViewModel.ImagesFilePaths = imagesPaths;
            recipeViewModel.Ingredients = recipeIngredientsList;
            recipeViewModel.NumberOfLikes = likesCount;
            recipeViewModel.Category = categoryForRecipe.Name;
            return View(recipeViewModel);
        }
        [HttpGet]
        [Authorize]
        public IActionResult RemoveRecipe(string id)
        {
            var ricipeId = new Guid(id.ToUpper());
            var recipe = _recipeService.Read(ricipeId);
            _recipeService.Delete(recipe);
            this.TempData["Message"] = "Successfully removed recipe !";
            return this.RedirectToAction("All", "Recipe");
        }

        [HttpGet]
        [Authorize]
        public IActionResult UpdateRecipe(string id)
        {
            try
            {
                var categoriesModels = _categoryService.FindAll();

                var categoriesWithId = new Dictionary<string, string>();

                foreach (var category in categoriesModels.Distinct())
                {
                    categoriesWithId.Add(category.Id.ToString(), category.Name);
                }

                var recipe = _recipeService.Read(Guid.Parse(id));
                var recipeViewModel = new RecipeViewModel
                {
                    Id = recipe.Id.ToString(),
                    Name = recipe.Name,
                    Categories = categoriesWithId,
                    PreparationDescription = recipe.PreparationDescription,
                    TimeToPrepare = recipe.TimeToPrepare,
                    PortionsSize = recipe.PortionsSize,
                    CategoryId = recipe.CategoryId.ToString()
                };
                recipeViewModel.Categories = categoriesWithId;
                var recipeIngredients = _recipeProductsService.FindAll();
                var recipeIngredientsForCurrentRecipe = recipeIngredients.Where(x => x.RecipeId == recipe.Id).ToList();
                var recipeIngredientsList = new List<RecipeIngredientInputModel>();
                foreach (var recipeIngredient in recipeIngredientsForCurrentRecipe)
                {
                    var ingredient = _productService.Read(recipeIngredient.ProductId);
                    recipeIngredientsList.Add(new RecipeIngredientInputModel
                    {
                        IngredientName = ingredient.Name,
                        Quantity = recipeIngredient.Quantity
                    });
                }
                var imagesPaths = _imageService.PopulateRecipeViewModelImages(recipe.Id);
                recipeViewModel.ImagesFilePaths = imagesPaths;
                recipeViewModel.Ingredients = recipeIngredientsList;
                return View("Update", recipeViewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("CustomError", "Errors");
            }

        }

        [HttpPost]
        [Authorize]
        public IActionResult UpdateRecipe(RecipeViewModel model)
        {
            try
            {
                var categoriesModels = _categoryService.FindAll();

                var categoriesWithId = new Dictionary<string, string>();

                foreach (var category in categoriesModels.Distinct())
                {
                    categoriesWithId.Add(category.Id.ToString(), category.Name);
                }
                model.Categories = categoriesWithId;
                if (!ModelState.IsValid)
                {
                    return View("Update", model);
                }

                var user = this._userManager.GetUserAsync(HttpContext.User).Result;
                var userID = user.Id;
                var recipeId = model.Id;
                //Update recipe entity
                var recipeInDb = _recipeService.Read(Guid.Parse(model.Id));
                var recipeModel = new RecipeServiceModel
                {
                    Id = Guid.Parse(model.Id),
                    PortionsSize = model.PortionsSize,
                    PreparationDescription = model.PreparationDescription
                };
                recipeModel.ApplicationUserId = recipeInDb.ApplicationUserId;
                recipeModel.CreatedOn = recipeInDb.CreatedOn;
                _recipeService.Update(recipeModel);

                //update recipe products
                var recipeProducts = _recipeProductsService.FindAll();
                var recipeProductsForThisRecipe = recipeProducts.Where(x => x.RecipeId == Guid.Parse(model.Id)).ToList();
                foreach (var product in recipeProductsForThisRecipe)
                {
                    _recipeProductsService.Delete(product);
                }
                var productsIds = new List<Guid>();
                foreach (var inputIngredient in model.Ingredients)
                {
                    var ingredients = this._productService.FindAll();
                    var ingredient = ingredients.FirstOrDefault(x => x.Name == inputIngredient.IngredientName);
                    if (ingredient == null)
                    {
                        ingredient = new ProductServiceModel
                        {
                            Name = inputIngredient.IngredientName,
                        };
                        var id = this._productService.Create(ingredient);
                        productsIds.Add(id);
                    }
                    if (ingredient.Id != Guid.Empty)
                    {
                        productsIds.Add(ingredient.Id);
                    }

                }
                var counter = 0;
                foreach (var item in productsIds)
                {
                    var recipeProductsDb = _recipeProductsService.FindAll();
                    var recipeProduct = recipeProductsDb.FirstOrDefault(x => x.ProductId == item);
                    if (recipeProduct != null)
                    {
                        _recipeProductsService.Delete(recipeProduct);
                    }

                }
                for (int j = 0; j < productsIds.Count;)
                {
                    if (counter == productsIds.Count)
                    {
                        break;
                    }
                    var recipeProduct = new RecipeProductServiceModel
                    {
                        RecipeId = Guid.Parse(recipeId),
                        ProductId = productsIds[counter],
                        Quantity = model.Ingredients[counter].Quantity
                    };
                    this._recipeProductsService.Create(recipeProduct);
                    counter++;

                }

                //Update Images
                var images = _imageService.FindAll();
                var imagesForRecipe = images.Where(x => x.RecipeId == Guid.Parse(recipeId)).ToList();
                if (model.Images != null)
                {
                    foreach (var image in imagesForRecipe)
                    {
                        _imageService.Delete(image);
                        var path = image.FilePath;
                        if (System.IO.File.Exists(path))
                        {
                            System.IO.File.Delete(path);

                        }

                    }
                }
                var wwwRootPath = _webHostEnvironment.WebRootPath;
                if (model.Images != null)
                {
                    foreach (var image in model.Images)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(image.FileName + recipeId);
                        string extension = Path.GetExtension(image.FileName);

                        fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                        string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                        using (var fileStream = new FileStream(path, FileMode.Create))
                        {
                            image.CopyTo(fileStream);
                        }

                        var imageModel = new ImageServiceModel
                        {
                            CreatedOn = DateTime.Now,
                            Extension = extension,
                            RecipeId = Guid.Parse(recipeId),
                            UserId = userID,
                            FilePath = path,
                            ImageName = fileName
                        };
                        _imageService.Create(imageModel);

                    }
                }

                this.TempData["Message"] = "Successfully updated recipe !";
                return RedirectToAction("All", "Recipes");
            }
            catch (Exception)
            {
                return View("Update", model);
            }

        }
        [HttpGet]
        [Authorize]
        public IActionResult Add()
        {
            var categoriesModels = _categoryService.FindAll();

            var categoriesWithId = new Dictionary<string, string>();

            foreach (var category in categoriesModels.Distinct())
            {
                categoriesWithId.Add(category.Id.ToString(), category.Name);
            }
            var recipeModel = new RecipeViewModel
            {
                Categories = categoriesWithId
            };
            return View(recipeModel);
        }

        [HttpPost]
        [Authorize]
        public IActionResult Add(RecipeViewModel model)
        {
            try
            {
                var categoriesModels = _categoryService.FindAll();

                var categoriesWithId = new Dictionary<string, string>();

                foreach (var category in categoriesModels.Distinct())
                {
                    categoriesWithId.Add(category.Id.ToString(), category.Name);

                }
                model.Categories = categoriesWithId;
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var user = this._userManager.GetUserAsync(HttpContext.User).Result;
                var userID = user.Id;
                model.CreatedOn = DateTime.Now;
                model.ApplicationUserId = userID;
                model.CategoryId = model.CategoryId;
                model.NumberOfComments = 0;
                model.NumberOfLikes = 0;
                var productsIds = new List<Guid>();
                foreach (var inputIngredient in model.Ingredients)
                {
                    var ingredients = this._productService.FindAll();
                    var ingredient = ingredients.FirstOrDefault(x => x.Name == inputIngredient.IngredientName.Trim());
                    if (ingredient == null)
                    {
                        ingredient = new ProductServiceModel
                        {
                            Name = inputIngredient.IngredientName,
                        };
                        var id = this._productService.Create(ingredient);
                        productsIds.Add(id);
                    }
                    productsIds.Add(ingredient.Id);
                }
                var recipeModelData = new RecipeServiceModel
                {
                    Id = Guid.NewGuid(),
                    Name = model.Name,
                    PreparationDescription = model.PreparationDescription,
                    TimeToPrepare = model.TimeToPrepare,
                    PortionsSize = model.PortionsSize,
                    CategoryId = Guid.Parse(model.CategoryId),
                    ApplicationUserId = userID
                };

                var recipeId = _recipeService.Create(recipeModelData);
                var wwwRootPath = _webHostEnvironment.WebRootPath;
                foreach (var image in model.Images)
                {
                    string fileName = Path.GetFileNameWithoutExtension(image.FileName + recipeId);
                    string extension = Path.GetExtension(image.FileName);

                    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                    string path = Path.Combine(wwwRootPath + "/Images/", fileName);
                    using (var fileStream = new FileStream(path, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }

                    var imageModel = new ImageServiceModel
                    {
                        CreatedOn = DateTime.Now,
                        Extension = extension,
                        RecipeId = recipeId,
                        UserId = userID,
                        FilePath = path,
                        ImageName = fileName
                    };
                    _imageService.Create(imageModel);

                }
                var counter = 0;
                for (int i = counter; i < model.Ingredients.Count;)
                {
                    if (counter == model.Ingredients.Count)
                    {
                        break;
                    }
                    for (int j = 0; j < productsIds.Count; j++)
                    {
                        var recipeProduct = new RecipeProductServiceModel
                        {
                            RecipeId = recipeId,
                            ProductId = productsIds[counter],
                            Quantity = model.Ingredients[counter].Quantity
                        };
                        this._recipeProductsService.Create(recipeProduct);
                        counter++;
                        break;
                    }

                }
                this.TempData["Message"] = "Successfully added recipe !";
                return RedirectToAction("All");
            }
            catch (Exception)
            {
                return RedirectToAction("CustomError", "Errors");
            }

        }
    }
}
