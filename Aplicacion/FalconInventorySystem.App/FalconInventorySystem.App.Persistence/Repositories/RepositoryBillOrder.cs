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

        public async Task<BillOrder> CreateBillOrder(BillOrder billOrder)
        {
            var billOrderCreate = appDbContext.BillOrders.Add(billOrder);
            await appDbContext.SaveChangesAsync();
            return billOrderCreate.Entity;
        }

        public async Task<IEnumerable<BillOrder>> GetAllBillOrders()
        {
            var billOrders = await appDbContext.BillOrders.ToListAsync();
            return billOrders;
        }

        public async Task<BillOrder> GetBillOrderId(int id)
        {
            var billOrder = await appDbContext.BillOrders.FirstOrDefaultAsync(x => x.Id == id);
            return billOrder;
        }

        public async Task<Boolean> UpdateBillOrder(BillOrder billOrder)
        {
            var updated = false;

            var billOrderFound = await appDbContext.BillOrders.FirstOrDefaultAsync(x => x.Id == billOrder.Id);
            if (billOrderFound != null)
            {
                billOrderFound.OrderCreationDate = billOrder.OrderCreationDate;
                billOrderFound.Client = billOrder.Client;
                billOrderFound.Observation = billOrder.Observation;
                billOrderFound.ModificationDate = DateTime.Now;

                appDbContext.BillOrders.Update(billOrderFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteBillOrder(int id)
        {
            var deleted = false;

            var billOrderFound = await appDbContext.BillOrders.FirstOrDefaultAsync(x => x.Id == id);
            if (billOrderFound != null)
            {
                var billOrderItemsFound = await appDbContext.BillOrderItems.Where(x => x.BillOrderId == id).ToListAsync();

                billOrderItemsFound.ForEach(async z =>
                {
                    appDbContext.BillOrderItems.Remove(z);
                    await appDbContext.SaveChangesAsync();
                });

                appDbContext.BillOrders.Remove(billOrderFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
