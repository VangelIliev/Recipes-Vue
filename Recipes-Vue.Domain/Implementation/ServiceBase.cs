using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Implementation
{
    public abstract class ServiceBase<T> : IServiceBase<T> where T : class, IBaseEntity
    {
        private readonly RecipesDbContext _dbContext;
        private readonly ILogger _logger;

        public ServiceBase(RecipesDbContext dbContext, ILogger logger)
        {
            this._dbContext = dbContext;
            this._logger = logger;
        }

        public Guid Create(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Add(entity);
                this._dbContext.SaveChanges();
                return entity.Id;
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                return Guid.Empty;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Remove(entity);
                this._dbContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                return false;
            }
        }

        public List<T> FindAll()
        {
            try
            {
                var entities = this._dbContext.Set<T>().ToList();
                return entities;
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                return new List<T>();
            }
        }

        public T Read(Guid id)
        {
            var entity = this._dbContext.Set<T>().FirstOrDefault(x => x.Id == id);
            if (entity != null)
            {
                return entity;
            }
            return null;
        }

        public bool Update(T entity)
        {
            try
            {
                this._dbContext.Set<T>().Update(entity);
                this._dbContext.SaveChanges();
                return true;
                
            }
            catch (Exception e)
            {
                this._logger.LogError(e.Message);
                return false;
            }
        }
    }
}
