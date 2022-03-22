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
    public class RecipeProductService : IServiceBase<RecipeProductServiceModel>, IRecipeProductService
    {
        private readonly RecipesDbContext _dbContext;

        public RecipeProductService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Guid Create(RecipeProductServiceModel entity)
        {
            try
            {
                var product = new RecipeProduct
                {
                    Id = Guid.NewGuid(),
                    ProductId = entity.ProductId,
                    Quantity= entity.Quantity,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeProduct>().Add(product);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception e)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(RecipeProductServiceModel entity)
        {
            try
            {
                var product = new RecipeProduct
                {
                    Id = entity.Id,
                    ProductId = entity.ProductId,
                    Quantity = entity.Quantity,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeProduct>().Remove(product);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<RecipeProductServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<RecipeProduct>().AsNoTracking().ToList();
                var products = entities.Select(e => new RecipeProductServiceModel
                {
                    Id = e.Id,
                    ProductId = e.ProductId,
                    Quantity = e.Quantity,
                    RecipeId = e.RecipeId,
                }).ToList();
                return products;
            }
            catch (Exception e)
            {
                return new List<RecipeProductServiceModel>();
            }
        }

        public RecipeProductServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<RecipeProduct>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new RecipeProductServiceModel
                {
                    Id = entity.Id,
                    ProductId = entity.ProductId,
                    Quantity = entity.Quantity,
                    RecipeId = entity.RecipeId,
                };
            }
            return null;
        }

        public bool Update(RecipeProductServiceModel entity)
        {
            try
            {
                var product = new RecipeProduct
                {
                    Id = entity.Id,
                    ProductId = entity.ProductId,
                    Quantity = entity.Quantity,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeProduct>().Update(product);
                this._dbContext.SaveChanges();
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
