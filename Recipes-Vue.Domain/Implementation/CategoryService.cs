using Microsoft.Extensions.Logging;
using Recipes_Vue.Database.DbContext;
using Recipes_Vue.Domain.Interfaces;
using Recipes_Vue.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Implementation
{
    public class CategoryService : ServiceBase<CategoryServiceModel>, ICategoryService
    {
        public CategoryService(RecipesDbContext dbContext) : base(dbContext)
        {
        }
    }
}
