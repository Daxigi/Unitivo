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
    public partial class ModificarPuesto : Form
    {
        public ModificarPuesto()
        {
            InitializeComponent();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BCancelarModifCliente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BModificarPerfil_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBModPerfil.Text))
            {
                // Mostrar un mensaje de error si al menos un campo está vacío.
                MessageBox.Show("El campo es obligatorio. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Mostrar un mensaje de éxito.
                MessageBox.Show("Puesto registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
