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
    public partial class VerEmpleados : Form
    {
        MenuPrincipal formParent;
        public VerEmpleados(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar(formParent);
            this.Hide();
            registrar.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
