using Microsoft.VisualBasic;
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

namespace Unitivo.Presentacion.Vendedor
{
    public partial class ModificarCliente : Form
    {
        public int fila;

        public ModificarCliente()
        {
            InitializeComponent();
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Private Sub BModCliente_Click(sender As Object, e As EventArgs) Handles BModCliente.Click 
        //End Sub

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


        public object EspacioEnBlanco()
        {
            MsgBoxResult Ask;
            string nombre = TBNombreCliente.Text;
            string apellido = TBApellidoCliente.Text;
            string dni = TBDniCliente.Text;
            string tel = TBTelCliente.Text;
            string correo = TBCorreoCliente.Text;
            string domicilio = TBDireccion.Text;
            if (string.IsNullOrWhiteSpace(apellido) | string.IsNullOrWhiteSpace(nombre) | string.IsNullOrWhiteSpace(dni) | string.IsNullOrWhiteSpace(tel) | string.IsNullOrWhiteSpace(correo) | string.IsNullOrWhiteSpace(domicilio))
            {
                Ask = Interaction.MsgBox("Debe Completar todos los campos", Constants.vbCritical, "Error");
                return Ask;
            }
            else
            {
                return false;
            }
        }


    }
}
