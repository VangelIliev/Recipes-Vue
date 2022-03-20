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
    public class CommentService : ServiceBase<CommentServiceModel>, ICommentService
    {
        public CommentService(RecipesDbContext dbContext, ILogger logger) : base(dbContext, logger)
        {
        }
    }
}
