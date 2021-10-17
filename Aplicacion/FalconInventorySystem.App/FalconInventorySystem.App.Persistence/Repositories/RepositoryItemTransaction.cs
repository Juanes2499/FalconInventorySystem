using System;
using System.Collections.Generic;
using System.Text;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;


namespace FalconInventorySystem.App.Persistence.Repositories
{
    public class RepositoryItemTransaction : IRepositoryItemTransaction
    {
        private readonly AppDbContext appDbContext;

        public RepositoryItemTransaction(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public ItemTransaction CreateItemTransaction(ItemTransaction itemTransaction)
        {
            var createItemTransaction = itemTransaction;
            createItemTransaction.PurchaseOrderItemId = createItemTransaction.PurchaseOrderItemId == 0 ? null : createItemTransaction.PurchaseOrderItemId;
            createItemTransaction.WarehouseId = createItemTransaction.WarehouseId == 0 ? null : createItemTransaction.WarehouseId;
            createItemTransaction.BillOrderItemId = createItemTransaction.BillOrderItemId == 0 ? null : createItemTransaction.BillOrderItemId;

            var itemTransactionCreate = appDbContext.ItemTransactions.Add(createItemTransaction);
            appDbContext.SaveChanges();
            return itemTransactionCreate.Entity;
        }

        public IEnumerable<ItemTransaction> GetAllItemTransactions()
        {
            var ItemTransactions = appDbContext.ItemTransactions;
            return ItemTransactions;
        }

        public ItemTransaction GetItemTransactionId(int id)
        {
            var itemTransaction = appDbContext.ItemTransactions.FirstOrDefault(x => x.Id == id);
            return itemTransaction;
        }

        public Boolean UpdateItemTransaction(ItemTransaction itemTransaction)
        {
            var updated = false;

            itemTransaction.PurchaseOrderItemId = itemTransaction.PurchaseOrderItemId == 0 ? null : itemTransaction.PurchaseOrderItemId;
            itemTransaction.WarehouseId = itemTransaction.WarehouseId == 0 ? null : itemTransaction.WarehouseId;
            itemTransaction.BillOrderItemId = itemTransaction.BillOrderItemId == 0 ? null : itemTransaction.BillOrderItemId;

            var itemTransactionFound = appDbContext.ItemTransactions.FirstOrDefault(x => x.Id == itemTransaction.Id);
            if (itemTransactionFound != null)
            {
                itemTransactionFound.TransactionDate = itemTransaction.TransactionDate;
                itemTransactionFound.Amount = itemTransaction.Amount;
                itemTransactionFound.PurchaseOrderItemId = itemTransaction.PurchaseOrderItemId;
                itemTransactionFound.WarehouseId = itemTransaction.WarehouseId;
                itemTransactionFound.BillOrderItemId = itemTransaction.BillOrderItemId;
                itemTransactionFound.ModificationDate = DateTime.Now;

                appDbContext.ItemTransactions.Update(itemTransactionFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteItemTransaction(int id)
        {
            var deleted = false;

            var itemTransactionsFound = appDbContext.ItemTransactions.FirstOrDefault(x => x.Id == id);
            if (itemTransactionsFound != null)
            {
                appDbContext.ItemTransactions.Remove(itemTransactionsFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
