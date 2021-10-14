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
    public class CategoryModel : PageModel
    {
        private readonly IRepositoryCategory repositoryCategory;

        [BindProperty]
        public Category Category { get; set; }
        public List<Category> CategoryList { get; set; }

        public CategoryModel(IRepositoryCategory repositoryCategory)
        {
            this.repositoryCategory = repositoryCategory;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categoryList = repositoryCategory.GetAllCategories();
            return categoryList;
        }

        public void OnGet()
        {
            CategoryList = new List<Category>();
            CategoryList.AddRange(GetCategories());
        }

        public IActionResult OnPost()
        {
            var newCategory = Category;
            var brandCreated = repositoryCategory.CreateCategory(newCategory);
            Category = null;
            CategoryList = new List<Category>();
            CategoryList.AddRange(GetCategories());
            return RedirectToPage("Category");
        }
    }
}
