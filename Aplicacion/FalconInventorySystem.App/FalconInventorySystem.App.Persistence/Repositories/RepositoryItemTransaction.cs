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

        public async Task<ItemTransaction> CreateItemTransaction(ItemTransaction itemTransaction)
        {
            var itemTransactionCreate = appDbContext.ItemTransactions.Add(itemTransaction);
            await appDbContext.SaveChangesAsync();
            return itemTransactionCreate.Entity;
        }

        public async Task<IEnumerable<ItemTransaction>> GetAllItemTransactions()
        {
            var ItemTransactions = await appDbContext.ItemTransactions.ToListAsync();
            return ItemTransactions;
        }

        public async Task<ItemTransaction> GetItemTransactionId(int id)
        {
            var itemTransaction = await appDbContext.ItemTransactions.FirstOrDefaultAsync(x => x.Id == id);
            return itemTransaction;
        }

        public async Task<Boolean> UpdateItemTransaction(ItemTransaction itemTransaction)
        {
            var updated = false;

            var itemTransactionFound = await appDbContext.ItemTransactions.FirstOrDefaultAsync(x => x.Id == itemTransaction.Id);
            if (itemTransactionFound != null)
            {
                itemTransactionFound.TransactionDate = itemTransaction.TransactionDate;
                itemTransactionFound.Amount = itemTransaction.Amount;
                itemTransactionFound.PurchaseOrderItemId = itemTransaction.PurchaseOrderItemId;
                itemTransactionFound.WarehouseId = itemTransaction.WarehouseId;
                itemTransactionFound.BillOrderItemId = itemTransaction.BillOrderItemId;
                itemTransactionFound.ModificationDate = DateTime.Now;

                appDbContext.ItemTransactions.Update(itemTransactionFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteItemTransaction(int id)
        {
            var deleted = false;

            var itemTransactionsFound = await appDbContext.ItemTransactions.FirstOrDefaultAsync(x => x.Id == id);
            if (itemTransactionsFound != null)
            {
                appDbContext.ItemTransactions.Remove(itemTransactionsFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
