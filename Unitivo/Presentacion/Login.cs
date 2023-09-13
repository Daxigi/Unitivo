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
using Unitivo.Presentacion.Vendedor;
using Unitivo.Presentacion.Administrador;
using Unitivo.Presentacion.SuperAdministrador;

namespace Unitivo.Presentacion
{
    public partial class Login : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        public Login()
        {
            InitializeComponent();
        }
        private void TBUsuario_Keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & !(e.KeyChar == '.') & !(e.KeyChar == '\b'))
            {
                e.Handled = true;
                Interaction.MsgBox("Solo se aceptan letras", Constants.vbCritical, "Error");
            }
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            string usuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;

            if (!EspacioEnBlanco())
            {
                if (usuario == "JUANIV" && contraseña == "123")
                {
                    MenuV menuVForm = new();
                    menuVForm.Show();
                    this.Hide();
                }
                else if (usuario == "JUANISA" && contraseña == "123")
                {
                    this.Hide();
                    MenuSA menuSAForm = new();
                    menuSAForm.Show();
                }
                else if (usuario == "JUANIA" && contraseña == "123")
                {
                    this.Hide();
                    MenuA menuAForm = new();
                    menuAForm.Show();
                }
                else
                {
                    MessageBox.Show("Nombre de Usuario y/o Contraseña no válidos", "Datos inválidos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TBUsuario.Clear();
                    TBContraseña.Clear();
                    TBUsuario.Focus();
                }
            }
        }



        public bool EspacioEnBlanco()
        {
            DialogResult ask;
            string usuario = TBUsuario.Text;
            string contraseña = TBContraseña.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                ask = MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (ask == DialogResult.OK);
            }
            else
            {
                return false;
            }
        }


        private void TBUsuario_TextChanged(object sender, EventArgs e)
        {
            TBUsuario.Text = Strings.UCase(TBUsuario.Text);
            TBUsuario.SelectionStart = Strings.Len(TBUsuario.Text);
        }

        private void PictureBoxContraseña_Click(object sender, EventArgs e)
        {
            if (PictureBoxContraseña.Tag != null && PictureBoxContraseña.Tag.ToString() == "cerrado")
            {
                PictureBoxContraseña.Tag = "abierto";
                TBContraseña.PasswordChar = '\0'; // Mostrar caracteres normales en lugar de *
                PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_abierto;
            }
            else
            {
                PictureBoxContraseña.Tag = "cerrado";
                TBContraseña.PasswordChar = '*'; // Ocultar caracteres con *
                PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_cerrado;
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            TBUsuario.Focus();
        }

        private void PanelBarraMenuLogin_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenuLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }

        private void PanelBarraMenuLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }

        private void BCerrarMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BMaximizarMenu_Click(object sender, EventArgs e)
        {
            BMaximizarMenu.Visible = false;
            BRestaurarMenu.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenu_Click(object sender, EventArgs e)
        {
            BRestaurarMenu.Visible = false;
            BMaximizarMenu.Visible = true;
            WindowState = FormWindowState.Normal;
        }



        private void BMinimizarMenu_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
