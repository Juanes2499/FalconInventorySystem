using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class PurchaseOrderItem : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        public int ProductId { get; set; } //Product relation  - un item puede tener asociado un solo producto
        public Product Product { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int Amount { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public double UnitValue { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int PurchaseOrderId { get; set; } //PurchaseOrder relation  - un item puede tener asociado una sola orden de compra
        public PurchaseOrder PurchaseOrder { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int StateId { get; set; } //State relation  - un item puede tener asociado un solo estado
        public State State { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Observation { get; set; }


        //Relations
        public List<ItemTransaction> ItemTransactions { get; set; } //ItemTransaction relation - Un Item puede tener asociado muchas transacciones
    }
}
