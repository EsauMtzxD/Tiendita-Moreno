using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiendita_Moreno.BussinessLogicLayer
{
    public class DetailSaleBLL
    {

        public static DataTable DataSourceProducts()
        {

            DataTable dt = new DataTable();

            dt = DataAccessLayer.DetailSaleDAL.DataSourceProducts();

            return dt;
            
        }

    }
}
