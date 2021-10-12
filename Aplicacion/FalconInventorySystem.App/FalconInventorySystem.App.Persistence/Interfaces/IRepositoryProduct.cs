using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryProduct
    {
        Product CreateProduct(Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        Boolean UpdateProduct(Product product);
        Boolean DeleteProduct(int id);
    }
}
