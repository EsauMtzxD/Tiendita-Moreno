using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiendita_Moreno.DesktopApp
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //int QuantityOfUsers = BussinessLogicLayer.UserBLL.CheckTheUsers();

            //if (QuantityOfUsers == 0)
            //{

            //    Application.Run(new CreateUserFRM());

            //}
            //else
            //{

            //    Application.Run(new Login());

            //}

        }
    }
}
