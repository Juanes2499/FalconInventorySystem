using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class Storage : BaseEntity
    {

        [Required(ErrorMessage = "The field {0} is required.")]
        public int PurchaseOrderId { get; set; } //PurchaseOrder relation  - un almacenamiento puede tener asociado una sola orden de compra
        public PurchaseOrder PurchaseOrder { get; set; }




        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EntryDate { get; set; }
        
    }
}
