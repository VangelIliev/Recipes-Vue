using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class RecipeServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int PortionsSize { get; set; }
        public int TimeToPrepare { get; set; }
        public string PreparationDescription { get; set; }
        public DateTime CreatedOn { get; set; }
        public int NumberOfComments { get; set; }
        public int TotalCalories { get; set; }
        public string ApplicationUserId { get; set; }
        public Guid CategoryId { get; set; }
        public IEnumerable<LikeServiceModel> Likes { get; set; } = new List<LikeServiceModel>();
        public List<RecipeProductServiceModel> Ingredients { get; set; } = new List<RecipeProductServiceModel>();
        public IEnumerable<ImageServiceModel> Images { get; set; } = new List<ImageServiceModel>();
    }
}
