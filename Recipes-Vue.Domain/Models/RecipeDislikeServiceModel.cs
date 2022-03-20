using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class RecipeDislikeServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
