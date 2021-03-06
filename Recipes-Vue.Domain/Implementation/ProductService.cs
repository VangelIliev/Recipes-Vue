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
    public class ProductService : IServiceBase<ProductServiceModel>, IProductService
    {
        private readonly RecipesDbContext _dbContext;

        public ProductService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Guid Create(ProductServiceModel entity)
        {
            try
            {
                var product = new Product
                {
                    Id = Guid.NewGuid(),
                    Name = entity.Name,
                    Calories = entity.Calories,
                    Weight = entity.Weight,
                };
                this._dbContext.Set<Product>().Add(product);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(ProductServiceModel entity)
        {
            try
            {
                var product = new Product
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Calories = entity.Calories,
                    Weight = entity.Weight,
                };
                this._dbContext.Set<Product>().Remove(product);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ProductServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Product>().AsNoTracking().ToList();
                var products = entities.Select(e => new ProductServiceModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Calories = e.Calories,
                    Weight = e.Weight,
                }).ToList();
                return products;
            }
            catch (Exception)
            {
                return new List<ProductServiceModel>();
            }
        }

        public ProductServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Product>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new ProductServiceModel {
                    Id = entity.Id,
                    Name = entity.Name,
                    Calories = entity.Calories,
                    Weight = entity.Weight,
                };
            }
            return null;
        }

        public bool Update(ProductServiceModel entity)
        {
            try
            {
                var product = new Product
                {
                    Id = entity.Id,
                    Name = entity.Name,
                    Calories = entity.Calories,
                    Weight = entity.Weight,
                };
                this._dbContext.Set<Product>().Update(product);
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
