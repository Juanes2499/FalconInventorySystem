using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBillOrderItem
    {
        BillOrderItem CreateBillOrderItem(BillOrderItem billOrderItem);
        IEnumerable<BillOrderItem> GetAllBillOrderItems();
        BillOrderItem GetBillOrderItemId(int id);
        Boolean UpdateBillOrderItem(BillOrderItem billOrderItem);
        Boolean DeleteBillOrderItem(int id);
    }
}
