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
    public class RecipeDislikeService : IServiceBase<RecipeDislikeServiceModel>, IRecipeDislikeService
    {
        private readonly RecipesDbContext _dbContext;

        public RecipeDislikeService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Guid Create(RecipeDislikeServiceModel entity)
        {
            try
            {
                var dislike = new RecipeDislike
                {
                    Id = Guid.NewGuid(),
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeDislike>().Add(dislike);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(RecipeDislikeServiceModel entity)
        {
            try
            {
                var dislike = new RecipeDislike
                {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeDislike>().Remove(dislike);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<RecipeDislikeServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<RecipeDislike>().AsNoTracking().ToList();
                var dislikes = entities.Select(e => new RecipeDislikeServiceModel
                {
                    Id = e.Id,
                    ApplicationUserId = e.ApplicationUserId,
                    RecipeId = e.RecipeId,
                }).ToList();
                return dislikes;
            }
            catch (Exception)
            {
                return new List<RecipeDislikeServiceModel>();
            }
        }

        public RecipeDislikeServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<RecipeDislike>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new RecipeDislikeServiceModel {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
            }
            return null;
        }

        public bool Update(RecipeDislikeServiceModel entity)
        {
            try
            {
                var dislike = new RecipeDislike
                {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<RecipeDislike>().Update(dislike);
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
