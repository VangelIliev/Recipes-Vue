﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes_Vue.Database.Entities
{
    public class RecipeDislike
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        public Guid RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        //add user

        public string ApplicationUserId { get; set; }

        public IdentityUser IdentityUser { get; set; }
    }
}
