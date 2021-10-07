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
    public class RepositoryProduct : IRepositoryProduct
    {
        private readonly AppDbContext appDbContext;

        public RepositoryProduct(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Product> CreateProduct(Product product)
        {
            var productCreate = appDbContext.Products.Add(product);
            await appDbContext.SaveChangesAsync();
            return productCreate.Entity;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await appDbContext.Products.ToListAsync();
            return products;
        }

        public async Task<Product> GetProductById(int id)
        {
            var productFound = await appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            return productFound;
        }

        public async Task<Boolean> UpdateProduct(Product product)
        {
            var updated = false;

            var productFound = await appDbContext.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            if (productFound != null)
            {
                productFound.ProductName = product.ProductName;
                productFound.Description = product.Description;
                productFound.BrandId = product.BrandId;
                productFound.CategoryId = product.CategoryId;
                productFound.ModificationDate = DateTime.Now;

                appDbContext.Products.Update(productFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteProduct(int id)
        {
            var deleted = false;

            var productFound = await appDbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (productFound != null)
            {
                appDbContext.Products.Remove(productFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
