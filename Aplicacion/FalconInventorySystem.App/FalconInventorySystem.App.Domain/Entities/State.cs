using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class State : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(50, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string StateName { get; set; }


        //Relation
        public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } //PurchaseOrderItem relation - Un estado tiene muchos items de ordenes de compras asociados
        public List<BillOrderItem> BillOrderItems { get; set; } //BillOrderItem relation - Un estado tiene muchos items de ordenes de ventas asociados
    }
}
