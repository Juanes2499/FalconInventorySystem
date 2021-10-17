using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.AspNetCore.Http;


namespace FalnconInventorySystem.App.Frontend.Pages
{
    public class BillOrdeItemDeleteModel : PageModel
    {
        private readonly IRepositoryBillOrderItem repositoryBillOrderItem;

        [BindProperty]
        public BillOrderItem BillOrderItem { get; set; }

        public List<BillOrderItem> BillOrderItemsList { get; set; }

        public BillOrdeItemDeleteModel(
            IRepositoryBillOrderItem repositoryBillOrderItem
        )
        {
            this.repositoryBillOrderItem = repositoryBillOrderItem;
        }

        public IActionResult OnGet(int? billOrderItemId)
        {
            if (billOrderItemId.HasValue)
            {
                BillOrderItem = repositoryBillOrderItem.GetBillOrderItemId(billOrderItemId.Value);
            }
            else
            {
                BillOrderItem = new BillOrderItem();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var DeleteBillOrderItem = BillOrderItem;
            repositoryBillOrderItem.DeleteBillOrderItem(DeleteBillOrderItem.Id);
            return RedirectToPage("BillOrderDetails", new { BillOrderId = DeleteBillOrderItem.BillOrderId });
        }
    }
}
