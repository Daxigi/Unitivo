using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class AñadirUsuario : Form
    {
            UsuariosRepositorio usuariosRepositorio = new UsuariosRepositorio();
        public AñadirUsuario()
        {
            InitializeComponent();
        }

        private void Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarEmailKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarPassword((TextBox)sender, e);
        }

        private void BRegistrarUsuario_Click(object sender, EventArgs e)
        {
            // Verificar si algún TextBox está vacío o si no se ha seleccionado un perfil.
            if (!VerificarCamposVacios())
            {
                // Mostrar un mensaje de error si algún campo está vacío o si no se ha seleccionado un perfil.
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos y seleccione un perfil.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(TBContraseñaUsuario.Text != TBConfirmarPass.Text){
                    MessageBox.Show("El password y el re-password deben coincidir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                
                Usuario x = new Usuario();

                x.NombreUsuario = TBNombreUsuario.Text;            
                x.Password = TBContraseñaUsuario.Text;            
                x.IdEmpleado = int.Parse(TBEmpleado.Text);
                x.IdPerfil = int.Parse(CBPerfil.Text);            

                if(usuariosRepositorio.AgregarUsuario(x)){
                    MessageBox.Show("Usuario" + x.NombreUsuario + " agregado con exito!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarTextBoxs();
                    CargarUsuarios();
                }
                LimpiarTextBoxs();

                // Mostrar un mensaje de éxito.
                MessageBox.Show("Usuario registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Método para limpiar los TextBox después de registrar un usuario.
        private void LimpiarTextBoxs()
        {
            TBNombreUsuario.Clear();
            TBContraseñaUsuario.Clear();
            TBConfirmarPass.Clear();
            TBEmpleado.Clear();
        }

        private void CargarUsuarios(){
            List<Usuario> usuarios = usuariosRepositorio.ListarUsuarios();
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach(Usuario usuario in usuarios)
            {
                dgvEmpleados.Rows.Add(usuario.Id, usuario.NombreUsuario, usuario.IdEmpleadoNavigation.Nombre, usuario.IdEmpleadoNavigation.Apellido);
            }

        }

        private bool VerificarCamposVacios(){
            if(
            CommonFunctions.ValidarCamposNoVacios(TBNombreUsuario) ||
            CommonFunctions.ValidarCamposNoVacios(TBContraseñaUsuario) ||
            CommonFunctions.ValidarCamposNoVacios(TBConfirmarPass) ||
            CommonFunctions.ValidarCamposNoVacios(TBEmpleado) ||
            CBPerfil.SelectedIndex == -1)
            {
                return true;
            }
            else{
                return false;
            }
        }


    }
}
