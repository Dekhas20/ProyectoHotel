﻿using System;
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
    public partial class modificarReserva : Form
    {
        MenuPrincipal formParent;
        public modificarReserva(MenuPrincipal formParent)
        {
            this.formParent = formParent;
            InitializeComponent();
        }
    }
}
