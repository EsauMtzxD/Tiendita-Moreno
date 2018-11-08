using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{
    public class Department
    {

        /// <summary>
        /// Is the Primary Key of the Table
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// It's the name of the department
        /// </summary>
        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(50, ErrorMessage = "The field Name must have max length of 50 Characteres")]
        [DataType(DataType.Text, ErrorMessage = "Th field Name must be a string")]
        public string Name { get; set; }

        /// <summary>
        /// It is the description about the department
        /// </summary>
        [Required(ErrorMessage = "The field Description is required")]
        [StringLength(100, ErrorMessage = "The field Description must have max length of 100 Characteres")]
        [DataType(DataType.Text, ErrorMessage = "The field Description must be a string")]
        public string Description { get; set; }

        /// <summary>
        /// It is the relationship between the product table and the department table
        /// </summary>
        public virtual ICollection<Product> Products { get; set; }

    }
}
