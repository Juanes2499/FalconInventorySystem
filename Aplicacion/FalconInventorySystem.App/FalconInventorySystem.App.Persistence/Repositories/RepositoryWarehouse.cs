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

        public async Task<Warehouse> CreateWarehouse(Warehouse warehouse)
        {
            var warehouseCreate = appDbContext.Warehouses.Add(warehouse);
            await appDbContext.SaveChangesAsync();
            return warehouseCreate.Entity;
        }

        public async Task<IEnumerable<Warehouse>> GetAllWarehouses()
        {
            var warehouses = await appDbContext.Warehouses.ToListAsync();
            return warehouses;
        }

        public async Task<Warehouse> GetWarehouseById(int id)
        {
            var warehouseFound = await appDbContext.Warehouses.FirstOrDefaultAsync(x => x.Id == id);
            return warehouseFound;
        }

        public async Task<Boolean> UpdateWarehouse(Warehouse warehouse)
        {
            var updated = false;

            var warehouseFound = await appDbContext.Warehouses.FirstOrDefaultAsync(x => x.Id == warehouse.Id);
            if (warehouseFound != null)
            {
                warehouseFound.MaximumCapacity = warehouse.MaximumCapacity;
                warehouseFound.MinimumCapacity = warehouse.MinimumCapacity;
                warehouseFound.Observation = warehouse.Observation;
                warehouseFound.ModificationDate = DateTime.Now;

                appDbContext.Warehouses.Update(warehouseFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteWarehouse(int id)
        {
            var deleted = false;

            var warehouseFound = await appDbContext.Warehouses.FirstOrDefaultAsync(x => x.Id == id);
            if (warehouseFound != null)
            {
                appDbContext.Warehouses.Remove(warehouseFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
