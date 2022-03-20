using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recipes_Vue.Domain.Implementation
{
    public class ImageService : ServiceBase<ImageServiceModel>, IImageService
    {
        public ImageService(RecipesDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
            
        }
        public List<string> PopulateRecipeViewModelImages(Guid recipeId)
        {
            var images = FindAll();
            var imagesForRecipe = images.Where(x => x.RecipeId == recipeId).ToList();
            var imagePaths = new List<string>();
            foreach (var image in imagesForRecipe)
            {
                imagePaths.Add(image.ImageName);
            }

            return imagePaths;
        }
    }
}
