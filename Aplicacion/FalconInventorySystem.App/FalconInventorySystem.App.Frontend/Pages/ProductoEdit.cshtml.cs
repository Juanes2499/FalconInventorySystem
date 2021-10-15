using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;

namespace FalconInventorySystem.App.Frontend.Pages
{
    public class ProductoEditModel : PageModel
    {

        private readonly IRepositoryProduct repositoryProduct;
        private readonly IRepositoryBrand repositoryBrand;
        private readonly IRepositoryCategory repositoryCategory;

        [BindProperty]
        public Product Product { get; set; }
        public Brand Brand { get; set; }
        public Category Category { get; set; }

        public List<Product> ProductsList { get; set; }
        public List<Brand> BrandsList { get; set; }
        public List<Category> CategoriesList { get; set; }

        public ProductoEditModel(
                IRepositoryProduct repositoryProduct,
                IRepositoryBrand repositoryBrand,
                IRepositoryCategory repositoryCategory
        )
        {
            this.repositoryProduct = repositoryProduct;
            this.repositoryBrand = repositoryBrand;
            this.repositoryCategory = repositoryCategory;
        }

        public IEnumerable<Product> GetProducts()
        {
            var productList = repositoryProduct.GetAllProducts();
            return productList;
        }

        public IEnumerable<Brand> GetBrands()
        {
            var brandsList = repositoryBrand.GetAllBrands();
            return brandsList;
        }

        public IEnumerable<Category> GetCategories()
        {
            var categoriesList = repositoryCategory.GetAllCategories();
            return categoriesList;
        }

        public IActionResult OnGet(int productId)
        {
            BrandsList = new List<Brand>();
            BrandsList.AddRange(GetBrands());

            CategoriesList = new List<Category>();
            CategoriesList.AddRange(GetCategories());

            Product = repositoryProduct.GetProductById(productId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryProduct.UpdateProduct(Product);
            return RedirectToPage("./Producto");
        }

    }
}
