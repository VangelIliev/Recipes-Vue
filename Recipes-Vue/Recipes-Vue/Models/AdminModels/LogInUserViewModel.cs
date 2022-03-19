using System.ComponentModel.DataAnnotations;

namespace Recipes_Vue.Models.AdminModels
{
    public class LogInUserViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
