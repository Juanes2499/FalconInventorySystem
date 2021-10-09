using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryBrand
    {
        Task<Brand> CreateBrand(Brand brand);
        Task<IEnumerable<Brand>> GetAllBrands();
        Task<Brand> GetBrandById(int id);
        Task<Boolean> UpdateBrand(Brand brand);
        Task<Boolean> DeleteBrand(int id);
    }
}
