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
    public class RepositoryBillOrder : IRepositoryBillOrder
    {
        private readonly AppDbContext appDbContext;

        public RepositoryBillOrder(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public BillOrder CreateBillOrder(BillOrder billOrder)
        {
            var billOrderCreate = appDbContext.BillOrders.Add(billOrder);
            appDbContext.SaveChanges();
            return billOrderCreate.Entity;
        }

        public IEnumerable<BillOrder> GetAllBillOrders()
        {
            var billOrders = appDbContext.BillOrders;
            return billOrders;
        }

        public BillOrder GetBillOrderId(int id)
        {
            var billOrder = appDbContext.BillOrders.FirstOrDefault(x => x.Id == id);
            return billOrder;
        }

        public Boolean UpdateBillOrder(BillOrder billOrder)
        {
            var updated = false;

            var billOrderFound = appDbContext.BillOrders.FirstOrDefault(x => x.Id == billOrder.Id);
            if (billOrderFound != null)
            {
                billOrderFound.OrderCreationDate = billOrder.OrderCreationDate;
                billOrderFound.Client = billOrder.Client;
                billOrderFound.Observation = billOrder.Observation;
                billOrderFound.ModificationDate = DateTime.Now;

                appDbContext.BillOrders.Update(billOrderFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteBillOrder(int id)
        {
            var deleted = false;

            var billOrderFound = appDbContext.BillOrders.FirstOrDefault(x => x.Id == id);
            if (billOrderFound != null)
            {
                var billOrderItemsFound = appDbContext.BillOrderItems.Where(x => x.BillOrderId == id).ToList();

                billOrderItemsFound.ForEach(z =>
                {
                    appDbContext.BillOrderItems.Remove(z);
                    appDbContext.SaveChanges();
                });

                appDbContext.BillOrders.Remove(billOrderFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
