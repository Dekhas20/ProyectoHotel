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
    public partial class Reportes : Form
    {
        MenuPrincipal formParent;
        public Reportes(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new ReporteFecha(formParent));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new reporteUsuario(formParent));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new reporteHabitacion(formParent));
        }
    }
}
