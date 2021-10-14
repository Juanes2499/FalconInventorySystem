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
    public class ProductoModel : PageModel
    {
        
        private readonly IRepositoryProduct repositoryProduct;

        [BindProperty]
        public Product Product { get; set; }
        public List<Product> ProductsList { get; set; }

        public ProductoModel (IRepositoryProduct repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }

        public IEnumerable<Product> GetProdicts()
        {
            var productList = repositoryProduct.GetAllProducts();
            return productList;
        }

        public void OnGet()
        {
            ProductsList = new List<Product>();
            ProductsList.AddRange(GetProdicts());  
        }

        public IActionResult OnPost()
        {
            var newProduct = Product;
            var ProductCreated = repositoryProduct.CreateProduct(newProduct);
            Product = null;
            ProductsList = new List<Product>();
            ProductsList.AddRange(GetProdicts());
            return RedirectToPage("Proveedor");
        }
    }
}