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
    public class ProveedorModel : PageModel
    {
        
        private readonly IRepositorySupplier repositorySupplier;

        [BindProperty]
        public Supplier Supplier { get; set; }
        public List<Supplier> SuppliersList { get; set; }

        public ProveedorModel (IRepositorySupplier repositorySupplier)
        {
            this.repositorySupplier = repositorySupplier;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            var supplierList = repositorySupplier.GetSuppliersAll();
            return supplierList;
        }

        public void OnGet()
        {
            SuppliersList = new List<Supplier>();
            SuppliersList.AddRange(GetSuppliers());  
        }

        public IActionResult OnPost()
        {
            var newSupplier = Supplier;
            var supplierCreated = repositorySupplier.AddSuppliers(newSupplier);
            Supplier = null;
            SuppliersList = new List<Supplier>();
            SuppliersList.AddRange(GetSuppliers());
            return RedirectToPage("Proveedor");
        }
    }
}
