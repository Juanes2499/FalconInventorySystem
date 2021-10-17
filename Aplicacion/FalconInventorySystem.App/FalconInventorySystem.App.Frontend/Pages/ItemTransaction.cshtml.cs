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
    public class ItemTransactionModel : PageModel
    {
        private readonly IRepositoryItemTransaction repositoryItemTransaction;
        private readonly IRepositoryWarehouse repositoryWarehouse;

        [BindProperty]
        public ItemTransaction ItemTransaction { get; set; }

        public List<ItemTransaction> ItemTransactionsList { get; set; }
        public List<Warehouse> WarehouseList { get; set; }

        public ItemTransactionModel(
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

        public void OnGet()
        {
            ItemTransactionsList = new List<ItemTransaction>();
            ItemTransactionsList.AddRange(GetItemTransactions());

            WarehouseList = new List<Warehouse>();
            WarehouseList.AddRange(GetWarehouses());
        }

        public IActionResult OnPost()
        {
            var newItemTransaction = ItemTransaction;
            newItemTransaction.PurchaseOrderItemId = newItemTransaction.PurchaseOrderItemId == 0 ? null : newItemTransaction.PurchaseOrderItemId;
            var brandCreated = repositoryItemTransaction.CreateItemTransaction(newItemTransaction);
            newItemTransaction = null;

            ItemTransactionsList = new List<ItemTransaction>();
            ItemTransactionsList.AddRange(GetItemTransactions());

            WarehouseList = new List<Warehouse>();
            WarehouseList.AddRange(GetWarehouses());

            return RedirectToPage("ItemTransaction");
        }
    }
}
