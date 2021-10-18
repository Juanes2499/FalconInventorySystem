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
    public class ItemTransactionEditModel : PageModel
    {
        private readonly IRepositoryItemTransaction repositoryItemTransaction;
        private readonly IRepositoryWarehouse repositoryWarehouse;

        [BindProperty]
        public ItemTransaction ItemTransaction { get; set; }

        public List<ItemTransaction> ItemTransactionsList { get; set; }
        public List<Warehouse> WarehouseList { get; set; }

        public ItemTransactionEditModel(
            IRepositoryItemTransaction repositoryItemTransaction,
            IRepositoryWarehouse repositoryWarehouse
        )
        {
            this.repositoryItemTransaction = repositoryItemTransaction;
            this.repositoryWarehouse = repositoryWarehouse;
        }

        public IEnumerable<ItemTransaction> GetItemTransactions()
        {
            var ItemTransactionsList = repositoryItemTransaction.GetAllItemTransactions();
            return ItemTransactionsList;
        }

        public IEnumerable<Warehouse> GetWarehouses()
        {
            var warehouseList = repositoryWarehouse.GetAllWarehouses();
            return warehouseList;
        }

        public IActionResult OnGet(int itemTransactionId)
        {
            ItemTransaction = repositoryItemTransaction.GetItemTransactionId(itemTransactionId);

            WarehouseList = new List<Warehouse>();
            WarehouseList.AddRange(GetWarehouses());

            return Page();
        }

        public IActionResult OnPost()
        {
            repositoryItemTransaction.UpdateItemTransaction(ItemTransaction);
            return RedirectToPage("ItemTransaction");
        }
    }
}
