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

        public Product CreateProduct(Product product)
        {
            var productCreate = appDbContext.Products.Add(product);
            appDbContext.SaveChanges();
            return productCreate.Entity;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = appDbContext.Products.Include(x => x.Brand).Include(x => x.Category).ToList();
            return products;
        }

        public Product GetProductById(int id)
        {
            var productFound = appDbContext.Products.FirstOrDefault(x => x.Id == id);
            return productFound;
        }

        public Boolean UpdateProduct(Product product)
        {
            var updated = false;

            var productFound = appDbContext.Products.FirstOrDefault(x => x.Id == product.Id);
            if (productFound != null)
            {
                productFound.ProductName = product.ProductName;
                productFound.Description = product.Description;
                productFound.BrandId = product.BrandId;
                productFound.CategoryId = product.CategoryId;
                productFound.ModificationDate = DateTime.Now;

                appDbContext.Products.Update(productFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteProduct(int id)
        {
            var deleted = false;

            var productFound = appDbContext.Products.FirstOrDefault(x => x.Id == id);
            if (productFound != null)
            {
                appDbContext.Products.Remove(productFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
