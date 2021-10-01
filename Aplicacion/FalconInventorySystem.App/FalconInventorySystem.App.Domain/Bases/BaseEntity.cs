using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FalconInventorySystem.App.Domain.Bases
{
    public class BaseEntity
    {
        //Id autoincrementable del registro
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int Id { get; set; }

        //Fecha de creación del registro
        [Required]
        public DateTime CreationDate { get; set; } = DateTime.Now;

        //Fecha de actualización del registro
        public DateTime ModificationDate { get; set; }
    }
}
