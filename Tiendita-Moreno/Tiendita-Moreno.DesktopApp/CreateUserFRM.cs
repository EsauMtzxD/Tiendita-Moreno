using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiendita_Moreno.DesktopApp
{
    public partial class CreateUserFRM : Form
    {
        public CreateUserFRM()
        {
            InitializeComponent();

            txtConfirmPwd.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtUser.Text = string.Empty;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            int QuantityOfUser = BussinessLogicLayer.UserBLL.CheckTheUsers();

            if (QuantityOfUser == 0)
            {

                Application.Exit();

            }
            else
            {

                Login l = new Login();

                l.Show();

                this.Hide();

            }

        }

        private void btnAcept_Click(object sender, EventArgs e)
        {

            string Uid = txtUser.Text.Trim().ToString();
            string Pwd = txtPwd.Text.Trim().ToString();
            string cPwd = txtConfirmPwd.Text.Trim().ToString();

            string msgError = string.Empty;

            msgError = BussinessLogicLayer.UserBLL.CreateUser(Uid, Pwd, cPwd);

            if (string.IsNullOrEmpty(msgError))
            {



            }
            else
            {

                MessageBox.Show(msgError.ToString());

            }

        }
    }
}
