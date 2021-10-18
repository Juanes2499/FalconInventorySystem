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
    public class ProductoDeleteModel : PageModel
    {
        private readonly IRepositoryProduct repositoryProduct;

        [BindProperty]
        public Product Product { get; set; }
      
        public List<Product> ProductsList { get; set; }

        public ProductoDeleteModel(
                IRepositoryProduct repositoryProduct
        )
        {
            this.repositoryProduct = repositoryProduct;
        }

        public IActionResult OnGet(int productId)
        { 
            Product = repositoryProduct.GetProductById(productId);
            return Page();
        }

        public IActionResult OnPost()
        {
            var productDeleted = repositoryProduct.DeleteProduct(Product.Id);
            return RedirectToPage("Producto");
        }
    }
}
