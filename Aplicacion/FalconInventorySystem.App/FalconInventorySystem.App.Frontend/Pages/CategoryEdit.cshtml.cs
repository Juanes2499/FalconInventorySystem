using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;

namespace FalnconInventorySystem.App.Frontend.Pages
{
    public class CategoryEditModel : PageModel
    {
        private readonly IRepositoryCategory repositoryCategory;

        [BindProperty]
        public Category Category { get; set; }
        public List<Category> CategoryList { get; set; }

        public CategoryEditModel(IRepositoryCategory repositoryCategory)
        {
            this.repositoryCategory = repositoryCategory;
        }

        public IActionResult OnGet(int categoryId)
        {
            Category = repositoryCategory.GetCategoryById(categoryId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryCategory.UpdateCategory(Category);
            return RedirectToPage("./Category");
        }
    }
}
