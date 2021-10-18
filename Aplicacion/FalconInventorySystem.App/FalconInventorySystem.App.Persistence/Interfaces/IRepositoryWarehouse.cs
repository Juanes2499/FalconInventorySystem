using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryWarehouse
    {
        Warehouse CreateWarehouse(Warehouse warehouse);
        IEnumerable<Warehouse> GetAllWarehouses();
        Warehouse GetWarehouseById(int id);
        Boolean UpdateWarehouse(Warehouse warehouse);
        Boolean DeleteWarehouse(int id);
    }
}
