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
    public partial class AñadirUsuario : Form
    {
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarPassword((TextBox)sender, e);
        }

        private void BRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío o si no se ha seleccionado un perfil.
            if (string.IsNullOrWhiteSpace(TBNombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(TBContraseñaUsuario.Text) ||
                string.IsNullOrWhiteSpace(TBConfirmarPass.Text) ||
                string.IsNullOrWhiteSpace(TBEmpleado.Text) ||
                CBPerfil.SelectedIndex == -1)
            {
                // Mostrar un mensaje de error si algún campo está vacío o si no se ha seleccionado un perfil.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos y seleccione un perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Todos los campos están llenos y se ha seleccionado un perfil, puedes proceder a registrar el usuario.

                // Agregar aquí la lógica para registrar el usuario.

                // Limpiar los TextBox después de registrar el usuario.
                LimpiarTextBoxs();

                // Mostrar un mensaje de éxito.
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para limpiar los TextBox después de registrar un usuario.
        private void LimpiarTextBoxs()
        {
            TBNombreUsuario.Clear();
            TBContraseñaUsuario.Clear();
            TBConfirmarPass.Clear();
            TBEmpleado.Clear();
        }


    }
}
