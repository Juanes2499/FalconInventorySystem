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
    public class BillOrderModel : PageModel
    {
       private readonly IRepositoryBillOrder repositoryBillOrder;

        [BindProperty]
        public BillOrder BillOrder { get; set; }

        public List<BillOrder> BillOrderList { get; set; }

        public BillOrderModel(IRepositoryBillOrder repositoryBillOrder)
        {
            this.repositoryBillOrder  = repositoryBillOrder ;
        }

        public IEnumerable<BillOrder> GetBillOrders()
        {
            var BillOrderList = repositoryBillOrder.GetAllBillOrders();
            return BillOrderList ;
        }

        public void OnGet()
        {
            BillOrderList = new List<BillOrder>();
            BillOrderList.AddRange(GetBillOrders());

        }

        public IActionResult OnPost()
        {
            var newBillOrder = BillOrder;
            var BillOrderCreated = repositoryBillOrder.CreateBillOrder(newBillOrder);
            BillOrder = null;
            BillOrderList = new List<BillOrder>();
            BillOrderList.AddRange(GetBillOrders());
            return RedirectToPage("BillOrder");
        }
    }
}