using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBillOrder
    {
        BillOrder CreateBillOrder(BillOrder billOrder);
        IEnumerable<BillOrder> GetAllBillOrders();
        BillOrder GetBillOrderId(int id);
        Boolean UpdateBillOrder(BillOrder billOrder);
        Boolean DeleteBillOrder(int id);
    }
}
