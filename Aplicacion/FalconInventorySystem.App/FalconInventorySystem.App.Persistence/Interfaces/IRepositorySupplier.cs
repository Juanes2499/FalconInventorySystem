using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositorySupplier
    {
        Task<IEnumerable<Supplier>> GetSuppliersAll();
        Task<Supplier> AddSuppliers(Supplier supplier);
        Task<Supplier> GetSupplierById(int id);
        Task<Boolean> UpdateSupplier(Supplier supplier);
        Task<Boolean> DeleteSupplier(int id);
    }
}
