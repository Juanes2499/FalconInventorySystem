using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string ProductName { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(500, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string Description { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int BrandId { get; set; } // Brand relation - un producto solo puede tener asociado una marca
        public Brand Brand { get; set; }


        [Required(ErrorMessage = "The field {0} is required.")]
        public int CategoryId { get; set; } // Category relation - un producto solo puede tener asociado una categoría
        public Category Category { get; set; }
    }
}
