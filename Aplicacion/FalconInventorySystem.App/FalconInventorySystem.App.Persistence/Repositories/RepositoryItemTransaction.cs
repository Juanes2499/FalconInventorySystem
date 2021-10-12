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
            var itemTransactionCreate = appDbContext.ItemTransactions.Add(itemTransaction);
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
