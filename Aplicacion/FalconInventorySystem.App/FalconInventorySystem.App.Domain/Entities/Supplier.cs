using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class Supplier : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage ="The field {0} has more than {1} characters.")]
        public string SupplierName { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Nit { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Address { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(20, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.EmailAddress)]
        [StringLength(100, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Email { get; set; }

        //Relations
        public List<PurchaseOrder> PurchaseOrders { get; set; } //Purchase Order relation - Un proveedor puede tener asociadas muchas ordenes de compra
    }
}
