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

        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }
        public List<PurchaseOrder > PurchaseOrderList { get; set; }

        public OrdenCompraModel(IRepositoryPurchaseOrder repositoryPurchaseOrder )
        {
            this.repositoryPurchaseOrder  = repositoryPurchaseOrder ;
        }

        public IEnumerable<PurchaseOrder> GetPurchaseOrders()
        {
            var PurchaseOrderList = repositoryPurchaseOrder .GetAllPurchaseOrders();
            return PurchaseOrderList;
        }

        public void OnGet()
        {
            PurchaseOrderList = new List<PurchaseOrder>();
            PurchaseOrderList.AddRange(GetPurchaseOrders());
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

