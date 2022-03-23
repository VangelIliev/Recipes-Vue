using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.RecipeModels
{
    public class RecipeViewModel
    {

        public string Id { get; set; }
        [Required]
        public List<IFormFile> Images { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public int PortionsSize { get; set; }
        [Required]
        public int TimeToPrepare { get; set; }
        [Required]
        [MinLength(10)]
        public string PreparationDescription { get; set; }

        public DateTime CreatedOn { get; set; }

        public int NumberOfLikes { get; set; }

        public int NumberOfDislikes { get; set; }

        public int NumberOfComments { get; set; }

        public int TotalCalories { get; set; }

        public string ApplicationUserId { get; set; }

        public string CreatedBy { get; set; }

        public string CategoryId { get; set; }

        public string Category { get; set; }

        public Dictionary<string, string> Categories { get; set; }

        public List<RecipeIngredientInputModel> Ingredients { get; set; }

        public List<string> ImagesFilePaths { get; set; }
    }
}
