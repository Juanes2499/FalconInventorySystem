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
    public class BrandDeleteModel : PageModel
    {
        private readonly IRepositoryBrand repositoryBrand;

        [BindProperty]
        public Brand Brand { get; set; }
        public List<Brand> BrandList { get; set; }

        public BrandDeleteModel(IRepositoryBrand repositoryBrand)
        {
            this.repositoryBrand = repositoryBrand;
        }

        public IEnumerable<Brand> GetBrands()
        {
            var brandList = repositoryBrand.GetAllBrands();
            return brandList;
        }

        public IActionResult OnGet(int brandId)
        {
            Brand = repositoryBrand.GetBrandById(brandId);
            return Page();
        }

        public IActionResult OnPost()
        {
            var brandDeleted = repositoryBrand.DeleteBrand(Brand.Id);
            return RedirectToPage("Brand");
        }
    }
}
