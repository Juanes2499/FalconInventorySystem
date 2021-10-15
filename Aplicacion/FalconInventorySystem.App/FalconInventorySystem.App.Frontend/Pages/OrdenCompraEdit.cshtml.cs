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

        [BindProperty]
        public PurchaseOrder PurchaseOrder { get; set; }
        public List<PurchaseOrder> PurchaseOrderList { get; set; }

        public OrdenCompraEditModel(IRepositoryPurchaseOrder repositoryPurchaseOrder)
        {
            this.repositoryPurchaseOrder = repositoryPurchaseOrder;
        }

        public IActionResult OnGet(int PurchaseOrderId)
        {
            PurchaseOrder = repositoryPurchaseOrder.GetPurchaseOrderById(PurchaseOrderId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryPurchaseOrder.UpdatePurchaseOrder(PurchaseOrder);
            return RedirectToPage("./CompraOrden");
        }
    }
}