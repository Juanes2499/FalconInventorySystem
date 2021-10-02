using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        public double MaximumCapacity { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public double MinimumCapacity { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Observation { get; set; }


        //Relation
        public List<ItemTransaction> ItemTransactions { get; set; } //ItemTransactions relation - una bodega puede tener asociada muchas transacciones

    }
}
