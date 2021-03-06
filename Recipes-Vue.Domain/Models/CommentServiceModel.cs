using Recipes_Vue.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Domain.Models
{
    public class CommentServiceModel : IBaseEntity
    {
        public Guid Id { get; set; }
        public Guid RecipeId { get; set; }
        public string RecipeName { get; set; }

        public string ImageUrl { get; set; }

        public string LastCommentDate { get; set; }

        public string Description { get; set; }

        public string SenderEmail { get; set; }

        public string CreatedOn { get; set; }

        public List<string> ImagesFilePaths { get; set; }

        public string IdentityUserId { get; set; }
    }
}
