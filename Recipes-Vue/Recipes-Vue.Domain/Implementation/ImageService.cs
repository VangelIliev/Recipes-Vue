using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;

namespace Recipes_Vue.Domain.Implementation
{
    public class ImageService : ServiceBase<ImageServiceModel>, IImageService
    {
        public ImageService(RecipesDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
    }
}
