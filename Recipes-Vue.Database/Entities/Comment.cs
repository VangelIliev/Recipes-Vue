using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class Comment : IBaseEntity
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Description { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        //Add user

        public string IdentityUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
