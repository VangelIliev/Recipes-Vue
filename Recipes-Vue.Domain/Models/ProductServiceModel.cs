using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class ProductServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Weight { get; set; }
        public decimal Calories { get; set; }
    }
}
