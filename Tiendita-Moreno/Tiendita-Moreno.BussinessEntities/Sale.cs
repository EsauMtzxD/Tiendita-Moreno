using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{
    public class Sale
    {

        [Key]
        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateOfSale { get; set; }

        public decimal Amount { get; set; }

        public int QuantityOfItem { get; set; }

        /// <summary>
        /// It is the relationship between the DetailSale table and the Sale table
        /// </summary>
        public virtual ICollection<DetailSale> DetailSales { get; set; }

    }
}
