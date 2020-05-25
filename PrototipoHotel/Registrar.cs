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
        public Registrar()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            VerEmpleados empleados = new VerEmpleados();
            this.Hide();
            empleados.Show();
        }
    }
}
