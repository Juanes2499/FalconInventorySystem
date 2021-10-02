using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class BillOrder : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime OrderCreationDate { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(100, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Client { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Observation { get; set; }


        //Relations
        public List<BillOrderItem> BillOrderItems { get; set; } //BillOrderItem relation - Una orden de venta puede tener muchos items
    }
}
