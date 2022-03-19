using System.Collections.Generic;

namespace Recipes_Vue.Models.AdminModels
{
    public class RemoveCategoryViewModel
    {
        public string Category { get; set; }

        public Dictionary<string, string> Categories { get; set; }

        public string Id { get; set; }
    }
}
