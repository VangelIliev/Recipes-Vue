using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Database.Entities;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Implementation
{
    public class RecipeService : IServiceBase<RecipeServiceModel>, IRecipeService
    {
        private readonly RecipesDbContext _dbContext;

        public RecipeService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Guid Create(RecipeServiceModel entity)
        {
            try
            {
                var product = new Recipe
                {
                    Id = Guid.NewGuid(),
                    PortionsSize = entity.PortionsSize,
                    IdentityUserId = entity.ApplicationUserId,
                    CategoryId = entity.CategoryId,
                    CreatedOn = entity.CreatedOn,
                    ImageUrl = entity.ImageUrl,
                    Name = entity.Name,
                    TotalCalories = entity.TotalCalories,
                    TimeToPrepare = entity.TimeToPrepare,
                    PreparationDescription = entity.PreparationDescription,
                };
                this._dbContext.Set<Recipe>().Add(product);
                this._dbContext.SaveChanges();
                return product.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(RecipeServiceModel entity)
        {
            try
            {
                var product = new Recipe
                {
                    Id = entity.Id,
                    PortionsSize = entity.PortionsSize,
                    IdentityUserId = entity.ApplicationUserId,
                    CategoryId = entity.CategoryId,
                    CreatedOn = entity.CreatedOn,
                    ImageUrl = entity.ImageUrl,
                    Name = entity.Name,
                    TotalCalories = entity.TotalCalories,
                    TimeToPrepare = entity.TimeToPrepare,
                    PreparationDescription = entity.PreparationDescription,
                };
                this._dbContext.Set<Recipe>().Remove(product);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RecipeServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Recipe>().AsNoTracking().ToList();
                var products = entities.Select(e => new RecipeServiceModel
                {
                    Id = e.Id,
                    PortionsSize = e.PortionsSize,
                    ApplicationUserId = e.IdentityUserId,
                    CategoryId = e.CategoryId,
                    CreatedOn = e.CreatedOn,
                    ImageUrl = e.ImageUrl,
                    Name = e.Name,
                    TotalCalories = e.TotalCalories,
                    TimeToPrepare = e.TimeToPrepare,
                    PreparationDescription = e.PreparationDescription,
                }).ToList();
                return products;
            }
            catch (Exception)
            {
                return new List<RecipeServiceModel>();
            }
        }

        public RecipeServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Recipe>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new RecipeServiceModel
                {
                    Id = entity.Id,
                    PortionsSize = entity.PortionsSize,
                    ApplicationUserId = entity.IdentityUserId,
                    CategoryId = entity.CategoryId,
                    CreatedOn = entity.CreatedOn,
                    ImageUrl = entity.ImageUrl,
                    Name = entity.Name,
                    TotalCalories = entity.TotalCalories,
                    TimeToPrepare = entity.TimeToPrepare,
                    PreparationDescription = entity.PreparationDescription,
                };
            }
            return null;
        }

        public bool Update(RecipeServiceModel entity)
        {
            try
            {
                var product = new Recipe
                {
                    Id = entity.Id,
                    PortionsSize = entity.PortionsSize,
                    IdentityUserId = entity.ApplicationUserId,
                    CategoryId = entity.CategoryId,
                    CreatedOn = entity.CreatedOn,
                    ImageUrl = entity.ImageUrl,
                    Name = entity.Name,
                    TotalCalories = entity.TotalCalories,
                    TimeToPrepare = entity.TimeToPrepare,
                    PreparationDescription = entity.PreparationDescription,
                };
                this._dbContext.Set<Recipe>().Update(product);
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
