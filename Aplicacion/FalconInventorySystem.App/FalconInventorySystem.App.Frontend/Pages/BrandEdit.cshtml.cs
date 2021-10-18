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
    public class BrandEditModel : PageModel
    {
        private readonly IRepositoryBrand repositoryBrand;

        [BindProperty]
        public Brand Brand { get; set; }
        public List<Brand> BrandList { get; set; }

        public BrandEditModel(IRepositoryBrand repositoryBrand)
        {
            this.repositoryBrand = repositoryBrand;
        }

        public IActionResult OnGet(int brandId)
        {
            Brand = repositoryBrand.GetBrandById(brandId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryBrand.UpdateBrand(Brand);
            return RedirectToPage("./Brand");
        }
    }
}
