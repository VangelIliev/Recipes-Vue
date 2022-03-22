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
    public class CategoryService : IServiceBase<CategoryServiceModel>, ICategoryService
    {
        private readonly RecipesDbContext _dbContext;

        public CategoryService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Guid Create(CategoryServiceModel entity)
        {
            try
            {
                var category = new Category
                {
                    Id = Guid.NewGuid(),
                    Name = entity.Name,
                };
                this._dbContext.Set<Category>().Add(category);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception e)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(CategoryServiceModel entity)
        {
            try
            {
                var category = new Category
                {
                    Id = entity.Id,
                    Name = entity.Name,
                };
                this._dbContext.Set<Category>().Remove(category);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CategoryServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Category>().AsNoTracking().ToList();
                var categories = entities.Select(e => new CategoryServiceModel
                {
                    Id = e.Id,
                    Name = e.Name,
                }).ToList();
                return categories;
            }
            catch (Exception)
            {
                return new List<CategoryServiceModel>();
            }
        }

        public CategoryServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Category>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new CategoryServiceModel { Id = entity.Id, Name = entity.Name};
            }
            return null;
        }

        public bool Update(CategoryServiceModel entity)
        {
            try
            {
                var category = new Category
                {
                    Id = entity.Id,
                    Name = entity.Name,
                };
                this._dbContext.Set<Category>().Update(category);
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
