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
    public class RepositoryPurchaseOrderItem : IRepositoryPurchaseOrderItem
    {
        private readonly AppDbContext appDbContext;

        public RepositoryPurchaseOrderItem(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<PurchaseOrderItem> CreatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            var purchaseOrderItemCreate = appDbContext.PurchaseOrderItems.Add(purchaseOrderItem);
            await appDbContext.SaveChangesAsync();
            return purchaseOrderItemCreate.Entity;
        }

        public async Task<IEnumerable<PurchaseOrderItem>> GetAllPurchaseOrderItems()
        {
            var purchaseOrderItems = await appDbContext.PurchaseOrderItems.ToListAsync();
            return purchaseOrderItems;
        }

        public async Task<PurchaseOrderItem> GetPurchaseOrderItemById(int id)
        {
            var purchaseOrderItem = await appDbContext.PurchaseOrderItems.FirstOrDefaultAsync(x => x.Id == id);
            return purchaseOrderItem;
        }

        public async Task<Boolean> UpdatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            var updated = false;

            var purchaseOrderItemFound = await appDbContext.PurchaseOrderItems.FirstOrDefaultAsync(x => x.Id == purchaseOrderItem.Id);
            if (purchaseOrderItemFound != null)
            {
                purchaseOrderItemFound.ProductId = purchaseOrderItem.ProductId;
                purchaseOrderItemFound.Amount = purchaseOrderItem.Amount;
                purchaseOrderItemFound.UnitValue = purchaseOrderItem.UnitValue;
                purchaseOrderItemFound.PurchaseOrderId = purchaseOrderItem.PurchaseOrderId;
                purchaseOrderItemFound.StateId = purchaseOrderItem.StateId;
                purchaseOrderItemFound.Observation = purchaseOrderItem.Observation;
                purchaseOrderItemFound.ModificationDate = DateTime.Now;

                appDbContext.PurchaseOrderItems.Update(purchaseOrderItemFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeletePurchaseOrderItem(int id)
        {
            var deleted = false;

            var purchaseOrderItemFound = await appDbContext.PurchaseOrderItems.FirstOrDefaultAsync(x => x.Id == id);
            if (purchaseOrderItemFound != null)
            {
                appDbContext.PurchaseOrderItems.Remove(purchaseOrderItemFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
