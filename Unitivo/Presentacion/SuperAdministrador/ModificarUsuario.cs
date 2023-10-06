using System;
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
    public partial class ModificarUsuario : Form
    {
        public ModificarUsuario()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarPassword((TextBox)sender, e);
        }

        private void BCancelarModif_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BModificarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(TBContraseñaUsuario.Text) ||
                ComboBoxPerfil.SelectedIndex == -1)
            {
                // Mostrar un mensaje de error si al menos un campo está vacío.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mostrar un mensaje de éxito.
                MessageBox.Show("Usuario modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
