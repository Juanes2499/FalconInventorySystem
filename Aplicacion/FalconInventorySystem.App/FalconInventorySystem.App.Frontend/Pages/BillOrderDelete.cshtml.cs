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
    public class BillOrderDeleteModel : PageModel
    {
        private readonly IRepositoryBillOrder repositoryBillOrder;

        [BindProperty]
        public BillOrder BillOrder { get; set; }

        public BillOrderDeleteModel(IRepositoryBillOrder repositoryBillOrder)
        {
            this.repositoryBillOrder = repositoryBillOrder;
        }

        public IActionResult OnGet(int OrderBillId)
        {
            BillOrder = repositoryBillOrder.GetBillOrderId(OrderBillId);
            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryBillOrder.DeleteBillOrder(BillOrder.Id);
            return RedirectToPage("./BillOrder");
        }
    }
}

