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
            CheckIn checkIn = new CheckIn(this);
            this.Hide();
            checkIn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CheckOut check = new CheckOut(this);
            this.Hide();
            check.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Habitaciones habitaciones = new Habitaciones(this);
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
            VerEmpleados verEmpleados = new VerEmpleados(this);
            this.Hide();
            verEmpleados.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Reportes reportes = new Reportes(this);
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
            if (panelMenuLeft.Width == 60)
            {
                panelMenuLeft.Width = 200;
            } else
            {
                panelMenuLeft.Width = 60;
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        ///////////////////// ponemos el un form dentro de otro/////////
        //private void AbrirFormInPanel(object Formhijo)
        //{
        //    if (this.panelContenedor.Controls.Count > 0)

        //        this.panelContenedor.Controls.RemoveAt(0);
        //    Form fh = Formhijo as Form;
        //    fh.TopLevel = false;
        //    fh.Dock = DockStyle.Fill;
        //    this.panelContenedor.Controls.Add(fh);
        //    this.panelContenedor.Tag = fh;
        //    fh.Show();
        //}

        public void AbrirFormInPanel(object FormHijo = null)
        {
            if (this.panelContenedor.Controls.Count > 0 && FormHijo != null)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            if (FormHijo != null)
            {
                Form formChild = FormHijo as Form;
                formChild.TopLevel = false;
                formChild.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(formChild);
                this.panelContenedor.Tag = formChild;
                formChild.Show();
            }
        }

        private void btCheckin_Click(object sender, EventArgs e)
        {
            
            AbrirFormInPanel(new CheckIn(this));
        }

        private void btCheckout_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CheckOut(this));
        }

        private void btHabitaciones_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Habitaciones(this));
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Registrar(this));
        }

        private void btReportes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reportes(this));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.Show();
        }

        private void btCerrarMenu_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizarMenu_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btExpandir_Click_1(object sender, EventArgs e)
        {
            if (panelMenuLeft.Width == 60)
            {
                panelMenuLeft.Width = 200;
            }
            else
            {
                panelMenuLeft.Width = 60;
            }
        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Reserva(this));
        }
    }
}
