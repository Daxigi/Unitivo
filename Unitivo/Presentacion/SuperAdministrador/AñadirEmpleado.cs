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
    public partial class AñadirEmpleado : Form
    {
        public AñadirEmpleado()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }


        private void BRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreEmpleado.Text) ||
                string.IsNullOrWhiteSpace(TBApellidoEmpleado.Text) ||
                string.IsNullOrWhiteSpace(TBDniEmpleado.Text) ||
                string.IsNullOrWhiteSpace(TBTelEmpleado.Text) ||
                string.IsNullOrWhiteSpace(TBDireccionEmpleado.Text) ||
                string.IsNullOrWhiteSpace(TBCorreoEmpleado.Text))
            {
                // Mostrar un mensaje de error si al menos un campo está vacío.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Todos los campos están llenos, puedes proceder a agregar al empleado al DataGridView.

                // Crear una nueva fila para el DataGridView.
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBNombreEmpleado.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBApellidoEmpleado.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBDniEmpleado.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBTelEmpleado.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBDireccionEmpleado.Text });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = TBCorreoEmpleado.Text });

                // Agregar la fila al DataGridView.
                dgvEmpleados.Rows.Add(row);

                // Limpiar los TextBox después de agregar el empleado.
                LimpiarTextBoxs();

                // Mostrar un mensaje de éxito.
                MessageBox.Show("Empleado registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para limpiar los TextBox después de agregar un empleado.
        private void LimpiarTextBoxs()
        {
            TBNombreEmpleado.Clear();
            TBApellidoEmpleado.Clear();
            TBDniEmpleado.Clear();
            TBTelEmpleado.Clear();
            TBDireccionEmpleado.Clear();
            TBCorreoEmpleado.Clear();
        }




    }
}
