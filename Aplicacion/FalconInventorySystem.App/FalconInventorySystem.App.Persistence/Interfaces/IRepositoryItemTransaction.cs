using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryItemTransaction
    {
        Task<ItemTransaction> CreateItemTransaction(ItemTransaction itemTransaction);
        Task<IEnumerable<ItemTransaction>> GetAllItemTransactions();
        Task<ItemTransaction> GetItemTransactionId(int id);
        Task<Boolean> UpdateItemTransaction(ItemTransaction itemTransaction);
        Task<Boolean> DeleteItemTransaction(int id);
    }
}
