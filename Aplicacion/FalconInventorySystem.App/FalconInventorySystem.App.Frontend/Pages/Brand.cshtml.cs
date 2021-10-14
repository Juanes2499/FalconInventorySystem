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
    public class BrandModel : PageModel
    {
        private readonly IRepositoryBrand repositoryBrand;

        [BindProperty]
        public Brand Brand { get; set; }
        public List<Brand> BrandList { get; set; }

        public BrandModel(IRepositoryBrand repositoryBrand)
        {
            this.repositoryBrand = repositoryBrand;
        }

        public IEnumerable<Brand> GetBrands()
        {
            var brandList = repositoryBrand.GetAllBrands();
            return brandList;
        }

        public void OnGet()
        {
            BrandList = new List<Brand>();
            BrandList.AddRange(GetBrands());
        }

        public IActionResult OnPost()
        {
            var newBrand = Brand;
            var supplierCreated = repositoryBrand.CreateBrand(newBrand);
            Brand = null;
            BrandList = new List<Brand>();
            BrandList.AddRange(GetBrands());
            return RedirectToPage("Brand");
        }
    }
}
