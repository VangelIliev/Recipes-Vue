namespace Recipes_Vue.Models.AdminModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string Role { get; set; }
        public string NewRole { get; set; }
    }
}
