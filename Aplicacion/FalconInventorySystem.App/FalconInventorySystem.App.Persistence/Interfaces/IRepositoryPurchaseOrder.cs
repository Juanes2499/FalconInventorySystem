using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryPurchaseOrder
    {
        Task<PurchaseOrder> CreatePurchaseOrder(PurchaseOrder purchaseOrder);
        Task<IEnumerable<PurchaseOrder>> GetAllPurchaseOrders();
        Task<PurchaseOrder> GetPurchaseOrderById(int id);
        Task<Boolean> UpdatePurchaseOrder(PurchaseOrder purchaseOrder);
        Task<Boolean> DeletePurchaseOrder(int id);
    }
}
