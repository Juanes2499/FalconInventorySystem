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
    public class ProveedoresDeleteModel : PageModel
    {
        private readonly IRepositorySupplier repositorySupplier;

        [BindProperty]
        public Supplier Supplier { get; set; }

        public ProveedoresDeleteModel(IRepositorySupplier repositorySupplier)
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
            repositorySupplier.DeleteSupplier(Supplier.Id);
            return RedirectToPage("./Proveedor");
        }
    }
}
