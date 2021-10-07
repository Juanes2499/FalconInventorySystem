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
    public class RepositoryPurchaseOrder : IRepositoryPurchaseOrder
    {
        private readonly AppDbContext appDbContext;

        public RepositoryPurchaseOrder(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<PurchaseOrder> CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            var purchaseOrderCreate = appDbContext.PurchaseOrders.Add(purchaseOrder);
            await appDbContext.SaveChangesAsync();
            return purchaseOrderCreate.Entity;
        }

        public async Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrders()
        {
            var purchaseOrder = await appDbContext.PurchaseOrders.ToListAsync();
            return purchaseOrder;
        }

        public async Task<PurchaseOrder> GetPurchaseOrderById(int id)
        {
            var purchaseOrder = await appDbContext.PurchaseOrders.FirstOrDefaultAsync(x => x.Id == id);
            return purchaseOrder;
        }

        public async Task<Boolean> UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            var updated = false;

            var purchaseOrderFound = await appDbContext.PurchaseOrders.FirstOrDefaultAsync(x => x.Id == purchaseOrder.Id);
            if (purchaseOrderFound != null)
            {
                purchaseOrderFound.NumberOrder = purchaseOrder.NumberOrder;
                purchaseOrderFound.OrderCreationDate = purchaseOrder.OrderCreationDate;
                purchaseOrderFound.SupplierId = purchaseOrder.SupplierId;
                purchaseOrderFound.Observation = purchaseOrder.Observation;
                purchaseOrderFound.Tax = purchaseOrder.Tax;
                purchaseOrderFound.ModificationDate = DateTime.Now;
                appDbContext.PurchaseOrders.Update(purchaseOrderFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeletePurchaseOrder(int id)
        {
            var deleted = false;

            var purchaseOrderFound = await appDbContext.PurchaseOrders.FirstOrDefaultAsync(x => x.Id == id);
            if (purchaseOrderFound != null)
            {
                var purchaseOrderItemsFound = await appDbContext.PurchaseOrderItems.Where(x => x.PurchaseOrderId == id).ToListAsync();

                purchaseOrderItemsFound.ForEach(async z =>
                {
                    appDbContext.PurchaseOrderItems.Remove(z);
                    await appDbContext.SaveChangesAsync();
                });

                appDbContext.PurchaseOrders.Remove(purchaseOrderFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }

    }
}
