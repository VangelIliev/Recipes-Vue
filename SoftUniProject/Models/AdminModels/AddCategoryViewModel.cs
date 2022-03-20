using System;
using System.ComponentModel.DataAnnotations;

namespace Web.Models.AdminModels
{
    public class AddCategoryViewModel
    {
        public Guid Id { get; set; }
        [MaxLength(10)]
        public string Name { get; set; }
    }
}
