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

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarEmpleados : Form
    {
        public GestionarEmpleados()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BModificarEmpleado_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarEmpleado
            //ModificarEmpleado modificarEmpleadoForm = new ModificarEmpleado();

            // Mostrar el formulario como un cuadro de diálogo modal
           // DialogResult result = modificarEmpleadoForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarEmpleado
            //if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de empleados o realizar otras acciones necesarias
                // después de modificar el empleado.
            }
        }

        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

    }
}
