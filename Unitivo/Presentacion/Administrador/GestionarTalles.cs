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
using Unitivo.Presentacion.Vendedor;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarTalles : Form
    {
        public GestionarTalles()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BModificarTalle_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarTalle
            ModificarTalle modificarTalleForm = new ModificarTalle();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarTalleForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarTalle
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de talle o realizar otras acciones necesarias
                // después de modificar el talle.
            }
        }

        private void BEliminarTalle_Click(object sender, EventArgs e)
        {
            if (dgvListarTalles.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un talle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void BAltaTalle_Click(object sender, EventArgs e)
        {

        }
    }
}
