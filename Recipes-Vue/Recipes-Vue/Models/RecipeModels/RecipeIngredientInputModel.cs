using System.ComponentModel.DataAnnotations;

namespace Recipes_Vue.Models.RecipeModels
{
    public class RecipeIngredientInputModel
    {
        [Required]
        [MinLength(3)]
        public string IngredientName { get; set; }

        [Required]
        [MinLength(3)]
        public string Quantity { get; set; }
    }
}
