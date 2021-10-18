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

        public PurchaseOrder CreatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            var purchaseOrderCreate = appDbContext.PurchaseOrders.Add(purchaseOrder);
            appDbContext.SaveChanges();
            return purchaseOrderCreate.Entity;
        }

        public IEnumerable<PurchaseOrder> GetAllPurchaseOrders()
        {
            var purchaseOrders = appDbContext.PurchaseOrders;
            return purchaseOrders;
        }

        public PurchaseOrder GetPurchaseOrderById(int id)
        {
            var purchaseOrder = appDbContext.PurchaseOrders.FirstOrDefault(x => x.Id == id);
            return purchaseOrder;
        }

        public Boolean UpdatePurchaseOrder(PurchaseOrder purchaseOrder)
        {
            var updated = false;

            var purchaseOrderFound = appDbContext.PurchaseOrders.FirstOrDefault(x => x.Id == purchaseOrder.Id);
            if (purchaseOrderFound != null)
            {
                purchaseOrderFound.NumberOrder = purchaseOrder.NumberOrder;
                purchaseOrderFound.OrderCreationDate = purchaseOrder.OrderCreationDate;
                purchaseOrderFound.SupplierId = purchaseOrder.SupplierId;
                purchaseOrderFound.Observation = purchaseOrder.Observation;
                purchaseOrderFound.Tax = purchaseOrder.Tax;
                purchaseOrderFound.ModificationDate = DateTime.Now;
                appDbContext.PurchaseOrders.Update(purchaseOrderFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeletePurchaseOrder(int id)
        {
            var deleted = false;

            var purchaseOrderFound = appDbContext.PurchaseOrders.FirstOrDefault(x => x.Id == id);
            if (purchaseOrderFound != null)
            {
                var purchaseOrderItemsFound = appDbContext.PurchaseOrderItems.Where(x => x.PurchaseOrderId == id).ToList();

                purchaseOrderItemsFound.ForEach(z =>
                {
                    appDbContext.PurchaseOrderItems.Remove(z);
                    appDbContext.SaveChanges();
                });

                appDbContext.PurchaseOrders.Remove(purchaseOrderFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }

    }
}
