using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryItemTransaction
    {
        ItemTransaction CreateItemTransaction(ItemTransaction itemTransaction);
        IEnumerable<ItemTransaction> GetAllItemTransactions();
        ItemTransaction GetItemTransactionId(int id);
        Boolean UpdateItemTransaction(ItemTransaction itemTransaction);
        Boolean DeleteItemTransaction(int id);
    }
}
