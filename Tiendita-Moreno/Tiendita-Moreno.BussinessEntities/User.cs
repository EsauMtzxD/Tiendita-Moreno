using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{
    public class User
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Uid is required")]
        [StringLength(20, ErrorMessage = "The field Uid must have max lenght of 20 Characteres")]
        [DataType(DataType.Text, ErrorMessage = "The field Uid must be a string")]
        public string Uid { get; set; }

        [Required(ErrorMessage = "The field Pwd is required")]
        [StringLength(20, ErrorMessage = "The field Pwd must have mas lenght of 20 characteres")]
        [DataType(DataType.Text, ErrorMessage = "The field Pwd must be a String")]
        public string Pwd { get; set; }

    }
}
