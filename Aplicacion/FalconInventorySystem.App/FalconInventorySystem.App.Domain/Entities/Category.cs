using FalconInventorySystem.App.Domain.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FalconInventorySystem.App.Domain.Entities
{
    public class Category : BaseEntity
    {
        [Required(ErrorMessage = "The field {0} is required.")]
        [DataType(DataType.Text)]
        [StringLength(50, ErrorMessage = "The field {0} has more than {1} characters.")]
        public string CategoryName { get; set; }


        //Relations
        public List<Product> Products { get; set; } //Product relation - una categoria puede tener asociados muchos productos
    }
}
