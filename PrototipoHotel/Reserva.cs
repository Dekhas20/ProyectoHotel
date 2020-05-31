using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PrototipoHotel
{
    public partial class Reserva : Form
    {
        MenuPrincipal formParent;
        public Reserva(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }

        private void btReserva_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new crearReserva(formParent));
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new modificarReserva(formParent));
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            formParent.AbrirFormInPanel(new eliminarReserva(formParent));
        }
    
    }
}
