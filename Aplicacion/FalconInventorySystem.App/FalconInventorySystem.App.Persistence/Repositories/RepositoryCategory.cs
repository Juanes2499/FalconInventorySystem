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
    public class RepositoryCategory : IRepositoryCategory
    {
        private readonly AppDbContext appDbContext;

        public RepositoryCategory(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public Category CreateCategory(Category category)
        {
            var categoryCreate = appDbContext.Categories.Add(category);
            appDbContext.SaveChanges();
            return categoryCreate.Entity;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var categories = appDbContext.Categories;
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var categoryFound = appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            return categoryFound;
        }

        public Boolean UpdateCategory(Category category)
        {
            var updated = false;

            var categoryFound = appDbContext.Categories.FirstOrDefault(x => x.Id == category.Id);
            if (categoryFound != null)
            {
                categoryFound.CategoryName = category.CategoryName;
                categoryFound.ModificationDate = DateTime.Now;

                appDbContext.Categories.Update(categoryFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteCategory(int id)
        {
            var deleted = false;

            var categoryFound = appDbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (categoryFound != null)
            {
                appDbContext.Categories.Remove(categoryFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
