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

        public async Task<BillOrderItem> CreateBillOrderItem(BillOrderItem billOrderItem)
        {
            var billOrderItemCreate = appDbContext.BillOrderItems.Add(billOrderItem);
            await appDbContext.SaveChangesAsync();
            return billOrderItemCreate.Entity;
        }

        public async Task<IEnumerable<BillOrderItem>> GetAllBillOrderItems()
        {
            var billOrderItems = await appDbContext.BillOrderItems.ToListAsync();
            return billOrderItems;
        }

        public async Task<BillOrderItem> GetBillOrderItemId(int id)
        {
            var billOrderItem = await appDbContext.BillOrderItems.FirstOrDefaultAsync(x => x.Id == id);
            return billOrderItem;
        }

        public async Task<Boolean> UpdateBillOrderItem(BillOrderItem billOrderItem)
        {
            var updated = false;

            var billOrderItemFound = await appDbContext.BillOrderItems.FirstOrDefaultAsync(x => x.Id == billOrderItem.Id);
            if (billOrderItemFound != null)
            {
                billOrderItemFound.ProductId = billOrderItem.ProductId;
                billOrderItemFound.Amount = billOrderItem.Amount;
                billOrderItemFound.BillOrderId = billOrderItem.BillOrderId;
                billOrderItemFound.StateId = billOrderItem.StateId;
                billOrderItemFound.Observation = billOrderItem.Observation;
                billOrderItemFound.ModificationDate = DateTime.Now;

                appDbContext.BillOrderItems.Update(billOrderItemFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteBillOrderItem(int id)
        {
            var deleted = false;

            var billOrderItemFound = await appDbContext.BillOrderItems.FirstOrDefaultAsync(x => x.Id == id);
            if (billOrderItemFound != null)
            {
                appDbContext.BillOrderItems.Remove(billOrderItemFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
