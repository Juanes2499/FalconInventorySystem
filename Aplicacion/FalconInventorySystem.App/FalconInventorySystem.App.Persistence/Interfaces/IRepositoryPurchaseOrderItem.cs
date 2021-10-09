using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryPurchaseOrderItem
    {
        Task<PurchaseOrderItem> CreatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem);
        Task<IEnumerable<PurchaseOrderItem>> GetAllPurchaseOrderItems();
        Task<PurchaseOrderItem> GetPurchaseOrderItemById(int id);
        Task<Boolean> UpdatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem);
        Task<Boolean> DeletePurchaseOrderItem(int id);
    }
}
