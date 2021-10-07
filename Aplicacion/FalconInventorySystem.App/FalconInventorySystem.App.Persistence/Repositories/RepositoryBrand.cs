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
    public class RepositoryBrand : IRepositoryBrand
    {
        private readonly AppDbContext appDbContext;

        public RepositoryBrand(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Brand> CreateBrand(Brand brand)
        {
            var brandCreate = appDbContext.Brands.Add(brand);
            await appDbContext.SaveChangesAsync();
            return brandCreate.Entity;
        }

        public async Task<IEnumerable<Brand>> GetAllBrands()
        {
            var brands = await appDbContext.Brands.ToListAsync();
            return brands;
        }

        public async Task<Brand> GetBrandById(int id)
        {
            var brandFound = await appDbContext.Brands.FirstOrDefaultAsync(x => x.Id == id);
            return brandFound;
        }

        public async Task<Boolean> UpdateBrand(Brand brand)
        {
            var updated = false;

            var brandFound = await appDbContext.Brands.FirstOrDefaultAsync(x => x.Id == brand.Id);
            if (brandFound != null)
            {
                brandFound.BrandName = brand.BrandName;
                brandFound.ModificationDate = DateTime.Now;

                appDbContext.Brands.Update(brandFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteBrand(int id)
        {
            var deleted = false;

            var brandFound = await appDbContext.Brands.FirstOrDefaultAsync(x => x.Id == id);
            if (brandFound != null)
            {
                appDbContext.Brands.Remove(brandFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
