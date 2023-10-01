﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Presentacion.Logica;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarUsuarios : Form
    {
        public GestionarUsuarios()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BModificarUsuario_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarUsuario
            ModificarUsuario modificarUsuarioForm = new ModificarUsuario();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarUsuarioForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarUsuario
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de usuarios o realizar otras acciones necesarias
                // después de modificar el usuario.
            }
        }

    }
}
