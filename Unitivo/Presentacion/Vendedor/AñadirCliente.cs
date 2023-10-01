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
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Repositorio.Interfaces;
using Univivo.Repositorios.Implementaciones;
using Unitivo.Modelos;

namespace Unitivo.Presentacion.Vendedor
{
    public partial class AñadirCliente : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();


        public AñadirCliente()
        {
            InitializeComponent();
        }


        private void BRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
            ClienteConstructor cliente = new ClienteConstructor(
                // completar los parametros con los TB de la vista
                nombre: TBNombreCliente.Text,
                apellido: TBApellidoCliente.Text,
                dni: int.Parse(TBDniCliente.Text),
                telefono: TBTelCliente.Text,
                direccion: TBDireccionCliente.Text,
                correo: TBCorreoCliente.Text
            );
                clienteRepositorio.AgregarCliente(cliente);
                MessageBox.Show("Cliente agregado correctamente");
                //quiero que los textbox se limpien despues de agregar el cliente
                LimpiarTextBox();
            }
            catch
            {
                MessageBox.Show("Error al agregar cliente");
            }
        }

        //quiero una funcion que limpie los textbox
        private void LimpiarTextBox()
        {
            TBNombreCliente.Text = "";
            TBApellidoCliente.Text = "";
            TBDniCliente.Text = "";
            TBTelCliente.Text = "";
            TBDireccionCliente.Text = "";
            TBCorreoCliente.Text = "";
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
    }
}

