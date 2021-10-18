using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBrand
    {
        Brand CreateBrand(Brand brand);
        IEnumerable<Brand> GetAllBrands();
        Brand GetBrandById(int id);
        Boolean UpdateBrand(Brand brand);
        Boolean DeleteBrand(int id);
    }
}
