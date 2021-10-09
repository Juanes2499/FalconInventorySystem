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

        public async Task<Category> CreateCategory(Category category)
        {
            var categoryCreate = appDbContext.Categories.Add(category);
            await appDbContext.SaveChangesAsync();
            return categoryCreate.Entity;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categories = await appDbContext.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategoryById(int id)
        {
            var categoryFound = await appDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
            return categoryFound;
        }

        public async Task<Boolean> UpdateCategory(Category category)
        {
            var updated = false;

            var categoryFound = await appDbContext.Categories.FirstOrDefaultAsync(x => x.Id == category.Id);
            if (categoryFound != null)
            {
                categoryFound.CategoryName = category.CategoryName;
                categoryFound.ModificationDate = DateTime.Now;

                appDbContext.Categories.Update(categoryFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteCategory(int id)
        {
            var deleted = false;

            var categoryFound = await appDbContext.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (categoryFound != null)
            {
                appDbContext.Categories.Remove(categoryFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
