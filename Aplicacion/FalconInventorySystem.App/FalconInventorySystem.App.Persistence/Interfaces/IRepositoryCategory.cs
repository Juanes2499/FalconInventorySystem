using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryCategory
    {
        Task<Category> CreateCategory(Category category);
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<Boolean> UpdateCategory(Category category);
        Task<Boolean> DeleteCategory(int id);
    }
}
