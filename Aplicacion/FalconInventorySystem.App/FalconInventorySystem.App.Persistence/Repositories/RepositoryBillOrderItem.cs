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
    public class RepositoryBillOrderItem : IRepositoryBillOrderItem
    {
        private readonly AppDbContext appDbContext;

        public RepositoryBillOrderItem(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public BillOrderItem CreateBillOrderItem(BillOrderItem billOrderItem)
        {
            var billOrderItemCreate = appDbContext.BillOrderItems.Add(billOrderItem);
            appDbContext.SaveChanges();
            return billOrderItemCreate.Entity;
        }

        public IEnumerable<BillOrderItem> GetAllBillOrderItems()
        {
            var billOrderItems = appDbContext.BillOrderItems;
            return billOrderItems;
        }

        public BillOrderItem GetBillOrderItemId(int id)
        {
            var billOrderItem = appDbContext.BillOrderItems.FirstOrDefault(x => x.Id == id);
            return billOrderItem;
        }

        public IEnumerable<BillOrderItem> GetBillOrderItemByBillOrderId(int id)
        {
            var billOrderItem = appDbContext.BillOrderItems
                .Where(x => x.BillOrderId == id)
                .Include(x => x.Product)
                .Include(x => x.State);
            return billOrderItem;
        }

        public Boolean UpdateBillOrderItem(BillOrderItem billOrderItem)
        {
            var updated = false;

            var billOrderItemFound = appDbContext.BillOrderItems.FirstOrDefault(x => x.Id == billOrderItem.Id);
            if (billOrderItemFound != null)
            {
                billOrderItemFound.ProductId = billOrderItem.ProductId;
                billOrderItemFound.Amount = billOrderItem.Amount;
                billOrderItemFound.BillOrderId = billOrderItem.BillOrderId;
                billOrderItemFound.StateId = billOrderItem.StateId;
                billOrderItemFound.Observation = billOrderItem.Observation;
                billOrderItemFound.ModificationDate = DateTime.Now;

                appDbContext.BillOrderItems.Update(billOrderItemFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteBillOrderItem(int id)
        {
            var deleted = false;

            var billOrderItemFound = appDbContext.BillOrderItems.FirstOrDefault(x => x.Id == id);
            if (billOrderItemFound != null)
            {
                appDbContext.BillOrderItems.Remove(billOrderItemFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
