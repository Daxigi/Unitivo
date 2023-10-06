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
    public partial class ModificarTalle : Form
    {
        public ModificarTalle()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BModificarTalle_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBModTalle.Text))
            {
                // Mostrar un mensaje de error si al menos un campo está vacío.
                MessageBox.Show("El campo es obligatorio. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mostrar un mensaje de éxito.
                MessageBox.Show("Talle modificado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
