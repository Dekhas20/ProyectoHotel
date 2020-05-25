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
        public Reportes()
        {
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
    }
}
