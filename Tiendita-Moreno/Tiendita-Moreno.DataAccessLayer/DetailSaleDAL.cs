using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.DataAccessLayer
{
    public class DetailSaleDAL
    {

        public static DataTable DataSourceProducts()
        {

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {

                new DataColumn("Codigo de Barras", typeof(string)),
                new DataColumn("Descripcion", typeof(string)),
                new DataColumn("Importe", typeof(decimal))

            });

            return dt;

        }

    }
}
