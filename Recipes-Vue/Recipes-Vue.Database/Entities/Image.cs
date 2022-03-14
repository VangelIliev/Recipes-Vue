using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class Image
    {
        public Guid Id { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public string UserId { get; set; }

        public IdentityUser IdentityUser { get; set; }

        public string Extension { get; set; }

        public DateTime CreatedOn { get; set; }

        public string FilePath { get; set; }

        public string ImageName { get; set; }
    }
}
