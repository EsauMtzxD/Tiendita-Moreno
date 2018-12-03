using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita_Moreno.BussinessEntities;

namespace Tiendita_Moreno.DataAccessLayer
{
    public class ProductDAL
    {

        public static bool _SourceProductByCodeBar(string CodBar)
        {

            bool isExist = false;

            using(StoreDbContext dbCtx = new StoreDbContext())
            {

                var obj = dbCtx.Products.Where(x => x.BarCode == CodBar).FirstOrDefault();

                if(obj != null)
                {

                    isExist = true;

                }

            }

            return isExist;

        }

        public static DataTable SourceProductByCodeBar(string CodeBar)
        {

            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[]
            {

                new DataColumn("Codigo de Barras", typeof(string)),
                new DataColumn("Descripcion", typeof(string)),
                new DataColumn("Costo", typeof(decimal)),
                new DataColumn("Almacen", typeof(string))

            });

            using(StoreDbContext dbCtx = new StoreDbContext())
            {

                var product = dbCtx.Products.Where(x => x.BarCode == CodeBar).ToList();

                if(product != null)
                {

                    product.ToList().ForEach(x =>
                    {

                        var Row = dt.NewRow();

                        Row["Codigo de Barras"] = x.BarCode.ToString();
                        Row["Descripcion"] = x.Description.ToString();
                        Row["Costo"] = x.Cost;
                        Row["Almacen"] = x.Current_Quantity;

                        dt.Rows.Add(Row);

                    });

                }

            }

            return dt;

        }

    }
}
