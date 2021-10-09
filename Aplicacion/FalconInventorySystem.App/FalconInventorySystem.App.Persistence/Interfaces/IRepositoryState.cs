using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryState
    {
        Task<State> CreateState(State state);
        Task<IEnumerable<State>> GetAllStates();
        Task<State> GetStateById(int id);
        Task<Boolean> UpdateState(State state);
        Task<Boolean> DeleteState(int id);
    }
}
