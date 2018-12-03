using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiendita_Moreno.BussinessEntities;

namespace Tiendita_Moreno.DesktopApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Uid = txtUser.Text.Trim().ToString();
            string Pwd = txtPwd.Text.Trim().ToString();

            string msgError = string.Empty;

            msgError = BussinessLogicLayer.UserBLL.Login(Uid, Pwd);

            if (string.IsNullOrEmpty(msgError))
            {

                MessageBox.Show("Bienvenido", "Tiendita Moreno", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                StoreFRM st = new StoreFRM();
                st.Show();
                this.Hide();

            }
            else
            {

                MessageBox.Show(msgError.ToString());

            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int QuantityOfRegisters = BussinessLogicLayer.UserBLL.CheckTheUsers();

            if(QuantityOfRegisters == 5)
            {

                MessageBox.Show("No puedes crear mas cinco un usuario");

            }
            else
            {

                CreateUserFRM c = new CreateUserFRM();

                c.Show();
                this.Hide();

            }

        }
    }
}
