using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FalconInventorySystem.App.Domain.Bases
{
    public class BaseUpdate<T>
    {
        //ID del registro a actulizar
        public int Id { get; set; }

        //Entidad a actualizar
        public T ElementToUpdate { get; set; }
    }
}
