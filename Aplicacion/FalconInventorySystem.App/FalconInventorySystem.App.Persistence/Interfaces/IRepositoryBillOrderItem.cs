using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBillOrderItem
    {
        Task<BillOrderItem> CreateBillOrderItem(BillOrderItem billOrderItem);
        Task<IEnumerable<BillOrderItem>> GetAllBillOrderItems();
        Task<BillOrderItem> GetBillOrderItemId(int id);
        Task<Boolean> UpdateBillOrderItem(BillOrderItem billOrderItem);
        Task<Boolean> DeleteBillOrderItem(int id);
    }
}
