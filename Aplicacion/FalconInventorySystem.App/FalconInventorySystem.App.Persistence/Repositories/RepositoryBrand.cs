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

        public Brand CreateBrand(Brand brand)
        {
            var brandCreate = appDbContext.Brands.Add(brand);
            appDbContext.SaveChanges();
            return brandCreate.Entity;
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            var brands = appDbContext.Brands;
            return brands;
        }

        public Brand GetBrandById(int id)
        {
            var brandFound = appDbContext.Brands.FirstOrDefault(x => x.Id == id);
            return brandFound;
        }

        public Boolean UpdateBrand(Brand brand)
        {
            var updated = false;

            var brandFound = appDbContext.Brands.FirstOrDefault(x => x.Id == brand.Id);
            if (brandFound != null)
            {
                brandFound.BrandName = brand.BrandName;
                brandFound.ModificationDate = DateTime.Now;

                appDbContext.Brands.Update(brandFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteBrand(int id)
        {
            var deleted = false;

            var brandFound = appDbContext.Brands.FirstOrDefault(x => x.Id == id);
            if (brandFound != null)
            {
                appDbContext.Brands.Remove(brandFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
