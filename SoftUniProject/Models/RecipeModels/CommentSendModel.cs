﻿namespace Web.Models.RecipeModels
{
    public class CommentSendModel
    {
        public string RecipeId { get; set; }

        public string CommentMessage { get; set; }

        public string SenderEmail { get; set; }

        public string CommentCreation { get; set; }
    }
}
