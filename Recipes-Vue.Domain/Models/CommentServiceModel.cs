using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class CommentServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }

        public Guid RecipeId { get; set; }

        public string IdentityUserId { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
