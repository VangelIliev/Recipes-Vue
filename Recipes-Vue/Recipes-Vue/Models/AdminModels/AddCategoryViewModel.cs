using System;
using System.ComponentModel.DataAnnotations;

namespace Recipes_Vue.Models.AdminModels
{
    public class AddCategoryViewModel
    {
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
