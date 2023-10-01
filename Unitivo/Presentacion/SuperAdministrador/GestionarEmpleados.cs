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
            ModificarEmpleado modificarEmpleadoForm = new ModificarEmpleado();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarEmpleadoForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarEmpleado
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de empleados o realizar otras acciones necesarias
                // después de modificar el empleado.
            }
        }

    }
}
