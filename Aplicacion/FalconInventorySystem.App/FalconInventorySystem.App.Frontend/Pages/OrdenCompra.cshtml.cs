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
    public class OrdenCompraModel : PageModel
    {
       private readonly IRepositoryPurchaseOrder repositoryPurchaseOrder;

       private readonly IRepositorySupplier repositorySupplier;

        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }

        public Supplier Supplier  { get; set; }
        public List<PurchaseOrder > PurchaseOrderList { get; set; }
        public List<Supplier> SupplierList { get; set; }

        public OrdenCompraModel(IRepositoryPurchaseOrder repositoryPurchaseOrder,IRepositorySupplier repositorySupplier)
        {
            this.repositoryPurchaseOrder  = repositoryPurchaseOrder ;
            this.repositorySupplier  = repositorySupplier;
        }

        public IEnumerable<PurchaseOrder> GetPurchaseOrders()
        {
            var PurchaseOrderList = repositoryPurchaseOrder .GetAllPurchaseOrders();
            return PurchaseOrderList;
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            var SupplierList = repositorySupplier.GetSuppliersAll();
            return SupplierList;
        }

        public void OnGet()
        {
            PurchaseOrderList = new List<PurchaseOrder>();
            PurchaseOrderList.AddRange(GetPurchaseOrders());
            SupplierList = new List<Supplier>();
            SupplierList.AddRange(GetSuppliers());

        }

        public IActionResult OnPost()
        {
            var newPurchaseOrder = PurchaseOrder;
            var WareHouseCreated = repositoryPurchaseOrder.CreatePurchaseOrder(newPurchaseOrder);
            PurchaseOrder = null;
            PurchaseOrderList = new List<PurchaseOrder>();
            PurchaseOrderList.AddRange(GetPurchaseOrders());
            return RedirectToPage("OrdenCompra");
        }
    }
}

