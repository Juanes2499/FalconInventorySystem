using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositorySupplier
    {
        IEnumerable<Supplier> GetSuppliersAll();
        Supplier AddSuppliers(Supplier supplier);
        Supplier GetSupplierById(int id);
        Boolean UpdateSupplier(Supplier supplier);
        Boolean DeleteSupplier(int id);
    }
}
