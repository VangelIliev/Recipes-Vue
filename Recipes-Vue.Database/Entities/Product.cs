using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class Product : IBaseEntity
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Weight { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal Calories { get; set; }

        public IEnumerable<RecipeProduct> Recipes { get; set; } = new List<RecipeProduct>();

    }
}
