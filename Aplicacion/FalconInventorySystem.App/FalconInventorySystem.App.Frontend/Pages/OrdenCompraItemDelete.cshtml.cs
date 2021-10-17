using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;


namespace FalconInventorySystem.App.Frontend.Pages
{
    public class OrdenCompraItemDeleteModel : PageModel
    {
        private readonly IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem;

        [BindProperty]
        public PurchaseOrderItem PurchaseOrderItem { get; set; }

        public List<PurchaseOrderItem> PurchaseOrderItemsList { get; set; }

        public OrdenCompraItemDeleteModel(
            IRepositoryPurchaseOrderItem repositoryPurchaseOrderItem
        )
        {
            this.repositoryPurchaseOrderItem = repositoryPurchaseOrderItem;
        }

        public IActionResult OnGet(int? purchaseOrderItemId)
        {
            if (purchaseOrderItemId.HasValue)
            {
                PurchaseOrderItem = repositoryPurchaseOrderItem.GetPurchaseOrderItemById(purchaseOrderItemId.Value);
            }
            else
            {
                PurchaseOrderItem = new PurchaseOrderItem();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var UpdatePurchaseOrderItem = PurchaseOrderItem;
            repositoryPurchaseOrderItem.DeletePurchaseOrderItem(UpdatePurchaseOrderItem.Id);
            return RedirectToPage("OrdenCompraDetails", new { PurchaseOrderId = UpdatePurchaseOrderItem.PurchaseOrderId });
        }
    }
}
