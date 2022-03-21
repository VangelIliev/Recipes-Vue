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
    public class LikeService : IServiceBase<LikeServiceModel>, ILikeService
    {
        private readonly RecipesDbContext _dbContext;

        public LikeService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public Guid Create(LikeServiceModel entity)
        {
            try
            {
                var like = new Like
                {
                    Id = Guid.NewGuid(),
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<Like>().Add(like);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception e)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(LikeServiceModel entity)
        {
            try
            {
                var like = new Like
                {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<Like>().Remove(like);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<LikeServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Like>().ToList();
                var categories = entities.Select(e => new LikeServiceModel
                {
                    Id = e.Id,
                    ApplicationUserId = e.ApplicationUserId,
                    RecipeId = e.RecipeId,
                }).ToList();
                return categories;
            }
            catch (Exception e)
            {
                return new List<LikeServiceModel>();
            }
        }

        public LikeServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Like>().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new LikeServiceModel {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
            }
            return null;
        }

        public bool Update(LikeServiceModel entity)
        {
            try
            {
                var like = new Like
                {
                    Id = entity.Id,
                    ApplicationUserId = entity.ApplicationUserId,
                    RecipeId = entity.RecipeId,
                };
                this._dbContext.Set<Like>().Update(like);
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
