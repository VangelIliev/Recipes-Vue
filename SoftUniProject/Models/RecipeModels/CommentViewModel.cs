using System;
using System.Collections.Generic;

namespace Web.Models.RecipeModels
{
    public class CommentViewModel
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
