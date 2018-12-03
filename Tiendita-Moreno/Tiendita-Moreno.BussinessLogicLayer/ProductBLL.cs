using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiendita_Moreno.DataAccessLayer;

namespace Tiendita_Moreno.BussinessLogicLayer
{
    public class ProductBLL
    {

        /// <summary>
        /// This Method validation the DataAnnotations
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static bool Validate<T>(T obj, out ICollection<ValidationResult> results)
        {

            results = new List<ValidationResult>();

            return Validator.TryValidateObject(obj, new ValidationContext(obj), results, true);

        }

        public static string _SourceProductByCodeBar(string CodBar)
        {

            string msgError = string.Empty;

            if (string.IsNullOrEmpty(CodBar))
            {

                msgError = "Ingresa el Codigo de Barras";

            }

            bool isFound = DataAccessLayer.ProductDAL._SourceProductByCodeBar(CodBar);

            if(isFound != true)
            {

                msgError = "Producto no Encontrado o Codigo de Barras Incorrecto";

            }

            return msgError;

        }

        public static DataTable SourceProductByCodeBar(string CodBar)
        {

            DataTable dt = new DataTable();

            dt = DataAccessLayer.ProductDAL.SourceProductByCodeBar(CodBar);
        
            return dt;

        }

    }
}
