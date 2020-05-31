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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "diego" || tbUsuario.Text == "jesus" && tbContraseña.Text == "1234")
            {
                MenuPrincipal mPrincipal = new MenuPrincipal();
                this.Hide();
                mPrincipal.Show();
            }else if(tbUsuario.Text == "david" && tbContraseña.Text == "1234")
            {
                MenuPrincipal mPrincipal = new MenuPrincipal();
                mPrincipal.btRegistrar.Visible = false;
                mPrincipal.btReportes.Visible = false;
                this.Hide();
                mPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
            }
            
        }

        private void btCerrarLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMinimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
