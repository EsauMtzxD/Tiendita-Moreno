using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessEntities
{
    public class Cut
    {
        
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// It is the amount of money with which you start in the box
        /// </summary>
        public decimal InitialAmount{ get; set; }

        /// <summary>
        /// It's the amount of money you end up with
        /// </summary>
        public decimal FinalAmount { get; set; }

        /// <summary>
        /// It is the difference and if it is feasible
        /// </summary>
        public decimal Deference { get; set; }

        /// <summary>
        /// It is the date on which it opens
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

    }
}
