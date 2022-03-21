using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class RecipeProduct : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }

        public Recipe Recipe { get; set; }

        public Guid ProductId { get; set; }

        public Product Product { get; set; }

        public string Quantity { get; set; }
    }
}
