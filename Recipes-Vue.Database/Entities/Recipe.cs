using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class Recipe : IBaseEntity
    {
        [Required]
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int PortionsSize { get; set; }
        [Required]
        public int TimeToPrepare { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(2500)]
        public string PreparationDescription { get; set; }
        //User who created It
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int NumberOfComments { get; set; }
        public int TotalCalories { get; set; }
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public IEnumerable<Like> Likes { get; set; } = new List<Like>();
        public List<RecipeProduct> Ingredients { get; set; } = new List<RecipeProduct>();

        public IEnumerable<Image> Images { get; set; } = new List<Image>();
    }
}
