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
    public partial class Registrar : Form
    {
        MenuPrincipal formParent;
        public Registrar(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VerEmpleados empleados = new VerEmpleados(formParent);
            this.Hide();
            empleados.Show();
        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new CrearEmpleado(formParent));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new ModificarEmpleado(formParent));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new VerEmpleados(formParent));
        }
    }
}
