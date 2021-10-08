using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBillOrder
    {
        Task<BillOrder> CreateBillOrder(BillOrder billOrder);
        Task<IEnumerable<BillOrder>> GetAllBillOrders();
        Task<BillOrder> GetBillOrderId(int id);
        Task<Boolean> UpdateBillOrder(BillOrder billOrder);
        Task<Boolean> DeleteBillOrder(int id);
    }
}
