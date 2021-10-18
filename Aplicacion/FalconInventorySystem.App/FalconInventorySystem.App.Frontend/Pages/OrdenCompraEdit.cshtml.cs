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
    public class OrdenCompraEditModel : PageModel
    {
        private readonly IRepositoryPurchaseOrder repositoryPurchaseOrder;

        private readonly IRepositorySupplier repositorySupplier;
        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }
        public Supplier Supplier  { get; set; }
        public List<PurchaseOrder> PurchaseOrderList { get; set; }
        public List<Supplier> SupplierList { get; set; }

        public OrdenCompraEditModel(IRepositoryPurchaseOrder repositoryPurchaseOrder,IRepositorySupplier repositorySupplier)
        {
            this.repositoryPurchaseOrder = repositoryPurchaseOrder;
            this.repositorySupplier  = repositorySupplier;
        }

          public IEnumerable<Supplier> GetSuppliers()
        {
            var supplierList = repositorySupplier.GetSuppliersAll();
            return supplierList;
        }
        public IActionResult OnGet(int PurchaseOrderId)
        {
            SupplierList = new List<Supplier>();
            SupplierList.AddRange(GetSuppliers());
            PurchaseOrder = repositoryPurchaseOrder.GetPurchaseOrderById(PurchaseOrderId);
            
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryPurchaseOrder.UpdatePurchaseOrder(PurchaseOrder);
            return RedirectToPage("./OrdenCompra");
        }
    }
}