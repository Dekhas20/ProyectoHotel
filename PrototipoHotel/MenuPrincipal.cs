using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoHotel
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CheckIn checkIn = new CheckIn();
            this.Hide();
            checkIn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckOut check = new CheckOut();
            this.Hide();
            check.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones();
            this.Hide();
            habitaciones.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            VerEmpleados verEmpleados = new VerEmpleados();
            this.Hide();
            verEmpleados.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes();
            this.Hide();
            reportes.Show();
        }

        private void btCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizarMenu_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btExpandir_Click(object sender, EventArgs e)
        {
            if (panelMenuLeft.Width == 210)
            {
                panelMenuLeft.Width = 60;
            }else
            {
                panelMenuLeft.Width = 210;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        ///////////////////// ponemos el un form dentro de otro/////////
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)

                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CheckIn());
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CheckOut());
        }

        private void btHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Habitaciones());
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar());
        }

        private void btReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reportes());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

    }
}
