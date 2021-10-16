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

        public PurchaseOrderItem CreatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            var purchaseOrderItemCreate = appDbContext.PurchaseOrderItems.Add(purchaseOrderItem);
            appDbContext.SaveChanges();
            return purchaseOrderItemCreate.Entity;
        }

        public IEnumerable<PurchaseOrderItem> GetAllPurchaseOrderItems()
        {
            var purchaseOrderItems = appDbContext.PurchaseOrderItems;
            return purchaseOrderItems;
        }

        public PurchaseOrderItem GetPurchaseOrderItemById(int id)
        {
            var purchaseOrderItem = appDbContext.PurchaseOrderItems.FirstOrDefault(x => x.Id == id);
            return purchaseOrderItem;
        }

        public IEnumerable<PurchaseOrderItem> GetPurchaseOrderItemByPurchaseOrderId(int id)
        {
            var purchaseOrderItem = appDbContext.PurchaseOrderItems
                .Where(x => x.PurchaseOrderId == id)
                .Include(x => x.Product)
                .Include(x => x.State);
            return purchaseOrderItem;
        }

        public Boolean UpdatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem)
        {
            var updated = false;

            var purchaseOrderItemFound = appDbContext.PurchaseOrderItems.FirstOrDefault(x => x.Id == purchaseOrderItem.Id);
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
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeletePurchaseOrderItem(int id)
        {
            var deleted = false;

            var purchaseOrderItemFound = appDbContext.PurchaseOrderItems.FirstOrDefault(x => x.Id == id);
            if (purchaseOrderItemFound != null)
            {
                appDbContext.PurchaseOrderItems.Remove(purchaseOrderItemFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
