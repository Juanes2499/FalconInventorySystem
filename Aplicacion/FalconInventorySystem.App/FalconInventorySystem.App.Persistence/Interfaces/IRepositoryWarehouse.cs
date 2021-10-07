using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryWarehouse
    {
        Task<Warehouse> CreateWarehouse(Warehouse warehouse);
        Task<IEnumerable<Warehouse>> GetAllWarehouses();
        Task<Warehouse> GetWarehouseById(int id);
        Task<Boolean> UpdateWarehouse(Warehouse warehouse);
        Task<Boolean> DeleteWarehouse(int id);
    }
}
