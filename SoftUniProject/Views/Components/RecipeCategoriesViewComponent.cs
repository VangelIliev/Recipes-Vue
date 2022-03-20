using Microsoft.AspNetCore.Mvc;
using Recipes_Vue.Domain.Interfaces;
using Web.Models.RecipeModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Views.Components
{
    public class RecipeCategoriesViewComponent : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public RecipeCategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.FindAll();
            var categoriesViewModel = categories.Select(x => new CategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
            }).ToList();
            return View(categoriesViewModel);
        }
    }
}
