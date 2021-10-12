using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryCategory
    {
        Category CreateCategory(Category category);
        IEnumerable<Category> GetAllCategories();
        Category GetCategoryById(int id);
        Boolean UpdateCategory(Category category);
        Boolean DeleteCategory(int id);
    }
}
