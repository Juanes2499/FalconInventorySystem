using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class PurchaseOrder : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string NumberOrder { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DeliveryDate { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int SupplierId { get; set; } //Supplier relations - Una orden puede tener un asociado un solo proveedor
        public Supplier Supplier { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Observation { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [Range(1.00, 100.00, ErrorMessage = "The field {0} must be between {1} and {2}")]
        public double Tax { get; set; }


        //Relations
        public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } //PurchaseOrderItem relation - Una orden de compra puede tener muchos items
    }
}
