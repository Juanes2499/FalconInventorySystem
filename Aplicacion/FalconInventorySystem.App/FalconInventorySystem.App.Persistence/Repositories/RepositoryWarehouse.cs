using System;
using System.Collections.Generic;
using System.Text;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace FalconInventorySystem.App.Persistence.Repositories
{
    public class RepositoryWarehouse : IRepositoryWarehouse
    {
        private readonly AppDbContext appDbContext;

        public RepositoryWarehouse(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Warehouse CreateWarehouse(Warehouse warehouse)
        {
            var warehouseCreate = appDbContext.Warehouses.Add(warehouse);
            appDbContext.SaveChanges();
            return warehouseCreate.Entity;
        }

        public IEnumerable<Warehouse> GetAllWarehouses()
        {
            var warehouses = appDbContext.Warehouses;
            return warehouses;
        }

        public Warehouse GetWarehouseById(int id)
        {
            var warehouseFound = appDbContext.Warehouses.FirstOrDefault(x => x.Id == id);
            return warehouseFound;
        }

        public Boolean UpdateWarehouse(Warehouse warehouse)
        {
            var updated = false;

            var warehouseFound = appDbContext.Warehouses.FirstOrDefault(x => x.Id == warehouse.Id);
            if (warehouseFound != null)
            {
                warehouseFound.MaximumCapacity = warehouse.MaximumCapacity;
                warehouseFound.MinimumCapacity = warehouse.MinimumCapacity;
                warehouseFound.Observation = warehouse.Observation;
                warehouseFound.ModificationDate = DateTime.Now;

                appDbContext.Warehouses.Update(warehouseFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteWarehouse(int id)
        {
            var deleted = false;

            var warehouseFound = appDbContext.Warehouses.FirstOrDefault(x => x.Id == id);
            if (warehouseFound != null)
            {
                appDbContext.Warehouses.Remove(warehouseFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
