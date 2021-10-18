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
    public class RepositorySupplier:IRepositorySupplier
    {
        private readonly AppDbContext appDbContext;

        public RepositorySupplier(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Supplier> GetSuppliersAll()
        {
            var SuppliersListed = appDbContext.Suppliers;
            return SuppliersListed;            
        }

        public Supplier AddSuppliers(Supplier supplier)
        {
            var SuppliersCreate = appDbContext.Suppliers.Add(supplier);
            appDbContext.SaveChanges();
            return SuppliersCreate.Entity;
        }

        public Supplier GetSupplierById(int id)
        {
            try
            {
                var supplier = appDbContext.Suppliers.FirstOrDefault(x => x.Id == id);
                return supplier;
            }
            catch
            {
                return new Supplier();
            }
        }

        public Boolean UpdateSupplier(Supplier supplier)
        {
            var updated = false;

            var SupplierFound = appDbContext.Suppliers.FirstOrDefault(x => x.Id == supplier.Id);
            if(SupplierFound != null)
            {
                SupplierFound.SupplierName = supplier.SupplierName;
                SupplierFound.Nit = supplier.Nit;
                SupplierFound.Address = supplier.Address;
                SupplierFound.Phone = supplier.Phone;
                SupplierFound.Email = supplier.Email;
                SupplierFound.ModificationDate = DateTime.Now;
                appDbContext.Suppliers.Update(SupplierFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteSupplier(int id)
        {
            var deleted = false;

            var SupplierFound = appDbContext.Suppliers.FirstOrDefault(x => x.Id == id);
            if (SupplierFound != null)
            {
                appDbContext.Suppliers.Remove(SupplierFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
