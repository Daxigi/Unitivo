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
    public partial class GestionarPuestos : Form
    {
        public GestionarPuestos()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BModificarPerfiles_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarPerfiles
            ModificarPuesto modificarPerfilesForm = new ModificarPuesto();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarPerfilesForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarPerfiles
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de perfiles o realizar otras acciones necesarias
                // después de modificar el perfil.
            }
        }

        private void BEliminarPerfiles_Click(object sender, EventArgs e)
        {
            if (dgvRegistroPerfil.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un puesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

    }
}
