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

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarCategorias : Form
    {
        public GestionarCategorias()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BModificarCategoria_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarCategoria
            ModificarCategoria modificarCategoriaForm = new ModificarCategoria();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = modificarCategoriaForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarCategoria
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de categoria o realizar otras acciones necesarias
                // después de modificar el categoria.
            }
        }

    }
}
