using System.Collections.Generic;

namespace Web.Models.AdminModels
{
    public class RemoveCategoryViewModel
    {
        public string Category { get; set; }

        public Dictionary<string, string> Categories { get; set; }

        public string Id { get; set; }
    }
}
