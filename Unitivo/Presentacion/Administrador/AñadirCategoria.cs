﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Unitivo.Presentacion.Logica;

namespace Unitivo.Presentacion.Administrador
{

    public partial class AñadirCategoria : Form
    {
        public AñadirCategoria()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }
    }
}
