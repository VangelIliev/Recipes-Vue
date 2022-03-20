using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class CategoryServiceModel : IBaseEntity
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
    }
}
