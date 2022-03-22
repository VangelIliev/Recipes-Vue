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
    public class CommentService : IServiceBase<CommentServiceModel>, ICommentService
    {
        private readonly RecipesDbContext _dbContext;

        public CommentService(RecipesDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Guid Create(CommentServiceModel entity)
        {
            try
            {
                var comment = new Comment
                {
                    Id = Guid.NewGuid(),
                    CreatedOn = DateTime.Parse(entity.CreatedOn),
                    Description = entity.Description,
                    IdentityUserId = entity.IdentityUserId,
                    RecipeId = entity.RecipeId
                };
                this._dbContext.Set<Comment>().Add(comment);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception)
            {
                return Guid.Empty;
            }
        }

        public bool Delete(CommentServiceModel entity)
        {
            try
            {
                var comment = new Comment
                {
                    Id = entity.Id,
                    CreatedOn = DateTime.Parse(entity.CreatedOn),
                    Description = entity.Description,
                    IdentityUserId = entity.IdentityUserId,
                    RecipeId = entity.RecipeId
                };
                this._dbContext.Set<Comment>().Remove(comment);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<CommentServiceModel> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<Comment>().AsNoTracking().ToList();
                var comments = entities.Select(e => new CommentServiceModel
                {
                    Id = e.Id,
                    CreatedOn = e.CreatedOn.ToString(),
                    Description = e.Description,
                    IdentityUserId = e.IdentityUserId,
                    RecipeId = e.RecipeId
                }).ToList();
                return comments;
            }
            catch (Exception)
            {
                return new List<CommentServiceModel>();
            }
        }

        public CommentServiceModel Read(Guid id)
        {
            var entity = this._dbContext.Set<Comment>().AsNoTracking().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return new CommentServiceModel {
                    Id = entity.Id,
                    CreatedOn = entity.CreatedOn.ToString(),
                    Description = entity.Description,
                    IdentityUserId = entity.IdentityUserId,
                    RecipeId = entity.RecipeId
                };
            }
            return null;
        }

        public bool Update(CommentServiceModel entity)
        {
            try
            {
                var comment = new Comment
                {
                    Id = entity.Id,
                    CreatedOn = DateTime.Parse(entity.CreatedOn),
                    Description = entity.Description,
                    IdentityUserId = entity.IdentityUserId,
                    RecipeId = entity.RecipeId
                };
                this._dbContext.Set<Comment>().Update(comment);
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
