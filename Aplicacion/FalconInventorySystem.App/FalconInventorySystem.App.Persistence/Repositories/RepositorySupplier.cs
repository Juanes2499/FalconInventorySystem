using System;
using System.Collections.Generic;
using System.Text;
using FalconInventorySystem.App.Domain.Entities;
using FalconInventorySystem.App.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Repositories
{
    public class RepositorySupplier:IRepositorySupplier
    {
        private readonly AppDbContext appDbContext;

        public RepositorySupplier(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<IEnumerable<Supplier>> GetSuppliersAll()
        {
            var SuppliersListed = new List<Supplier>();
            try
            {
                SuppliersListed = await appDbContext.Suppliers.ToListAsync();
                return SuppliersListed;
            }
            catch
            {
                return SuppliersListed;
            }
            
        }

        public async Task<Supplier> AddSuppliers(Supplier supplier)
        {
            try
            {
                var SuppliersCreate = appDbContext.Suppliers.Add(supplier);
                await appDbContext.SaveChangesAsync();
                return SuppliersCreate.Entity;
            }
            catch
            {
                return new Supplier();
            };
        }

        public async Task<Supplier> GetSupplierById(int id)
        {
            try
            {
                var supplier = await appDbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == id);
                return supplier;
            }
            catch
            {
                return new Supplier();
            }
        }

        public async Task<Boolean> UpdateSupplier(Supplier supplier)
        {
            var updated = false;

            var SupplierFound = await appDbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == supplier.Id);
            if(SupplierFound != null)
            {
                SupplierFound.SupplierName = supplier.SupplierName;
                SupplierFound.Nit = supplier.Nit;
                SupplierFound.Address = supplier.Address;
                SupplierFound.Phone = supplier.Phone;
                SupplierFound.Email = supplier.Email;
                SupplierFound.ModificationDate = DateTime.Now;
                appDbContext.Suppliers.Update(SupplierFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteSupplier(int id)
        {
            var deleted = false;

            var SupplierFound = await appDbContext.Suppliers.FirstOrDefaultAsync(x => x.Id == id);
            if (SupplierFound != null)
            {
                appDbContext.Suppliers.Remove(SupplierFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
