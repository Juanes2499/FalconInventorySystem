using FalconInventorySystem.App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Persistence.Interfaces
{
    public interface IRepositoryState
    {
        State CreateState(State state);
        IEnumerable<State> GetAllStates();
        State GetStateById(int id);
        Boolean UpdateState(State state);
        Boolean DeleteState(int id);
    }
}
