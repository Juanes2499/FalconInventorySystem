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

        public State CreateState(State state)
        {
            var stateCreate = appDbContext.TransactionStates.Add(state);
            appDbContext.SaveChanges();
            return stateCreate.Entity;
        }

        public IEnumerable<State> GetAllStates()
        {
            var statesListed = appDbContext.TransactionStates.ToList();
            return statesListed;
        }

        public State GetStateById(int id)
        {
            var stateFound = appDbContext.TransactionStates.FirstOrDefault(x => x.Id == id);
            return stateFound;
        }

        public Boolean UpdateState(State state)
        {
            var updated = false;

            var stateFound = appDbContext.TransactionStates.FirstOrDefault(x => x.Id == state.Id);
            if (stateFound != null)
            {
                stateFound.StateName = state.StateName;
                stateFound.ModificationDate = DateTime.Now;

                appDbContext.TransactionStates.Update(stateFound);
                appDbContext.SaveChanges();
                updated = true;
            }

            return updated;
        }

        public Boolean DeleteState(int id)
        {
            var deleted = false;

            var stateFound = appDbContext.TransactionStates.FirstOrDefault(x => x.Id == id);
            if (stateFound != null)
            {
                appDbContext.TransactionStates.Remove(stateFound);
                appDbContext.SaveChanges();
                deleted = true;
            }

            return deleted;
        }
    }
}
