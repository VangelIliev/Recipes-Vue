using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Database.Entities;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Recipes_Vue.Domain.Implementation
{
    public class ImageService : IServiceBase<ImageServiceModel>, IImageService
    {
        private readonly RecipesDbContext _dbContext;

        public ImageService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Guid Create(ImageServiceModel entity)
        {
            try
            {
                var image = new Image
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = entity.CreatedOn,
                    Extension = entity.Extension,
                    RecipeId = entity.RecipeId,
                    FilePath = entity.FilePath,
                    ImageName = entity.ImageName,
                    IdentityUserId = entity.UserId,
                };
                this._dbContext.Set<Image>().Add(image);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(ImageServiceModel entity)
        {
            try
            {
                var image = new Image
                {
                    Id = entity.Id,
                    CreatedOn = entity.CreatedOn,
                    Extension = entity.Extension,
                    RecipeId = entity.RecipeId,
                    FilePath = entity.FilePath,
                    ImageName = entity.ImageName,
                    IdentityUserId = entity.UserId,
                };
                this._dbContext.Set<Image>().Remove(image);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ImageServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Image>().AsNoTracking().ToList();
                var categories = entities.Select(e => new ImageServiceModel
                {
                    Id = e.Id,
                    CreatedOn = e.CreatedOn,
                    Extension = e.Extension,
                    RecipeId = e.RecipeId,
                    FilePath = e.FilePath,
                    ImageName = e.ImageName,
                    UserId = e.IdentityUserId,
                }).ToList();
                return categories;
            }
            catch (Exception)
            {
                return new List<ImageServiceModel>();
            }
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

        public ImageServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Image>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new ImageServiceModel {
                    Id = entity.Id,
                    CreatedOn = entity.CreatedOn,
                    Extension = entity.Extension,
                    RecipeId = entity.RecipeId,
                    FilePath = entity.FilePath,
                    ImageName = entity.ImageName,
                    UserId = entity.IdentityUserId,
                };
            }
            return null;
        }

        public bool Update(ImageServiceModel entity)
        {
            try
            {
                var image = new Image
                {
                    Id = entity.Id,
                    CreatedOn = entity.CreatedOn,
                    Extension = entity.Extension,
                    RecipeId = entity.RecipeId,
                    FilePath = entity.FilePath,
                    ImageName = entity.ImageName,
                    IdentityUserId = entity.UserId,
                };
                this._dbContext.Set<Image>().Update(image);
                this._dbContext.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
