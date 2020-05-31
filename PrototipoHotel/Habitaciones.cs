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
    public partial class Habitaciones : Form
    {
        MenuPrincipal formParent;
        public Habitaciones(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            MenuPrincipal menu = new MenuPrincipal();
            this.Hide();
            menu.Show();
        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new crearHabitacion(formParent));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new VerHabitaciones(formParent));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new modificarHabitaciones(formParent));
        }
    }
}
