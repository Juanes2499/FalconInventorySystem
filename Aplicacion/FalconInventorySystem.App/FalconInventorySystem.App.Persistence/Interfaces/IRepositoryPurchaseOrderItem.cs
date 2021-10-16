using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryPurchaseOrderItem
    {
        PurchaseOrderItem CreatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem);
        IEnumerable<PurchaseOrderItem> GetAllPurchaseOrderItems();
        PurchaseOrderItem GetPurchaseOrderItemById(int id);
        IEnumerable<PurchaseOrderItem> GetPurchaseOrderItemByPurchaseOrderId(int id);
        Boolean UpdatePurchaseOrderItem(PurchaseOrderItem purchaseOrderItem);
        Boolean DeletePurchaseOrderItem(int id);
    }
}
