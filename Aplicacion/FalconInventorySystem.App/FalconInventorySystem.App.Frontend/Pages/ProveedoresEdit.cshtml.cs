using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;

namespace FalnconInventorySystem.App.Frontend
{
    public class ProveedoresEditModel : PageModel
    {
        private readonly IRepositorySupplier repositorySupplier;

        [BindProperty]
        public Supplier Supplier { get; set; }

        public ProveedoresEditModel(IRepositorySupplier repositorySupplier)
        {
            this.repositorySupplier = repositorySupplier;
        }

        public IActionResult OnGet(int supplierId)
        {
            Supplier = repositorySupplier.GetSupplierById(supplierId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositorySupplier.UpdateSupplier(Supplier);
            return RedirectToPage("./Proveedor");
        }
    }
}
