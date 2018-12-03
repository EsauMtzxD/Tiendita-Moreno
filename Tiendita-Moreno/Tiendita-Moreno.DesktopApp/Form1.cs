using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tiendita_Moreno.DesktopApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            btnRes.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btnMaximizar.Visible = false;
            btnRes.Visible = true;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Normal;

            btnRes.Visible = false;
            btnMaximizar.Visible = true;

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        int posY = 0;
        int posX = 0;

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button != MouseButtons.Left)
            {

                posX = e.X;
                posY = e.Y;

            }
            else
            {

                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);

            }


        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {

            subMenuReportes.Visible = false;

        }

        private void btnReporteCompras_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void btnReportePagos_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            subMenuReportes.Visible = true;
        }
    }
}
