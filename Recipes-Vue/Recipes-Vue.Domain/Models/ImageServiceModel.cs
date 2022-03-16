using Microsoft.AspNetCore.Identity;
using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class ImageServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public string UserId { get; set; }
        public string Extension { get; set; }
        public DateTime CreatedOn { get; set; }
        public string FilePath { get; set; }
        public string ImageName { get; set; }
    }
}
