using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{
    public class DetailSale
    {

        /// <summary>
        /// Is the Primary Key of the table
        /// </summary>
        [Key]
        public int Id { get; set; }

        [ForeignKey("Sale")]
        public int SaleId { get; set; }
        public Sale Sale { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; } 

        public decimal Amount { get; set; }

    }
}
