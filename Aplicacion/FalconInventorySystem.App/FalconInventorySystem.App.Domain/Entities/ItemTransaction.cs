using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class ItemTransaction : BaseEntity
    {

        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime TransactionDate { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int Amount { get; set; }


        public int? PurchaseOrderItemId { get; set; } //PurchaseOrderItem relation - una trasanction puede tener un Item de orden de compra
        public PurchaseOrderItem PurchaseOrderItem { get; set; }


        public int? WarehouseId { get; set; } //Warehouse relation - una trasanction puede tener una bodega asociada
        public Warehouse Warehouse { get; set; }


        public int? BillOrderItemId { get; set; } //BillOrderItem relation - una trasanction puede tener un Item de orden de venta
        public BillOrderItem BillOrderItem { get; set; }


        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Observation { get; set; }
    }
}
