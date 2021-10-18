using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryPurchaseOrder
    {
        PurchaseOrder CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        IEnumerable<PurchaseOrder> GetAllPurchaseOrders();
        PurchaseOrder GetPurchaseOrderById(int id);
        Boolean UpdatePurchaseOrder(PurchaseOrder purchaseOrder);
        Boolean DeletePurchaseOrder(int id);
    }
}
