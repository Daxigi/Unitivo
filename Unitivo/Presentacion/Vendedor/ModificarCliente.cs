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

        // Private Sub BModCliente_Click(sender As Object, e As EventArgs) Handles BModCliente.Click
        // Dim ask As MsgBoxResult
        // If EspacioEnBlanco() = False Then
        // ask = MsgBox("Seguro que desea modificar a este cliente", vbQuestion + vbYesNo, "Confirmar Modificación")
        // If ask = vbYes Then
        // If objDcliente.modcliente(fila, TBNombreCliente.Text, TBApellidoCliente.Text, CInt(TBDniCliente.Text), CULng(TBTelCliente.Text), TBDireccion.Text, TBCorreoCliente.Text) Then
        // MsgBox("Se han modificado los datos con exito", vbInformation, "Confirmar Modificacion")
        // Me.Close()
        // End If
        // Else
        // TBDniCliente.Focus()
        // End If
        // End If
        // End Sub
        private void TBNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == '.') & !(e.KeyChar == '\b'))
            {
                e.Handled = true;
                Interaction.MsgBox("Solo se aceptan letras", Constants.vbCritical, "Error");
            }
        }

        private void TBApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == '.') & !(e.KeyChar == '\b'))
            {
                e.Handled = true;
                Interaction.MsgBox("Solo se aceptan letras", Constants.vbCritical, "Error");
            }
        }

        private void TBDniCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) & !(e.KeyChar == '.') & !(e.KeyChar == '\b'))
            {
                e.Handled = true;
                Interaction.MsgBox("Solo se aceptan caracteres númericos", Constants.vbCritical, "Error");
            }
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
