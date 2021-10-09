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
    public class RepositoryState : IRepositoryState
    {
        private readonly AppDbContext appDbContext;

        public RepositoryState(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<State> CreateState(State state)
        {
            var stateCreate = appDbContext.States.Add(state);
            await appDbContext.SaveChangesAsync();
            return stateCreate.Entity;
        }

        public async Task<IEnumerable<State>> GetAllStates()
        {
            var states = await appDbContext.States.ToListAsync();
            return states;
        }

        public async Task<State> GetStateById(int id)
        {
            var stateFound = await appDbContext.States.FirstOrDefaultAsync(x => x.Id == id);
            return stateFound;
        }

        public async Task<Boolean> UpdateState(State state)
        {
            var updated = false;

            var stateFound = await appDbContext.States.FirstOrDefaultAsync(x => x.Id == state.Id);
            if (stateFound != null)
            {
                stateFound.StateName = state.StateName;
                stateFound.ModificationDate = DateTime.Now;

                appDbContext.States.Update(stateFound);
                await appDbContext.SaveChangesAsync();
                updated = true;
            }

            return updated;
        }

        public async Task<Boolean> DeleteState(int id)
        {
            var deleted = false;

            var stateFound = await appDbContext.States.FirstOrDefaultAsync(x => x.Id == id);
            if (stateFound != null)
            {
                appDbContext.States.Remove(stateFound);
                await appDbContext.SaveChangesAsync();
                deleted = true;
            }

            return deleted;
        }
    }
}
