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
            Check_In checkIn = new Check_In();
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
    }
}
