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

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class MenuSA : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        public MenuSA()
        {
            InitializeComponent();
        }

        private void MenuA_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PanelSubMenuUsuarios.Visible = false;
            PanelSubMenuEmpleados.Visible = false;
            PanelSubMenuPerfiles.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void BSalir_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            ask = MessageBox.Show("¿Está seguro de que quiere cerrar sesión?", "Cerrar Aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (ask == DialogResult.Yes)
            {
                Close();

                // Reemplaza "LoginForm" con el nombre de tu formulario de inicio de sesión
                Login loginForm = new Login();
                loginForm.Show();

                // Limpia los campos de usuario y contraseña si es necesario
                loginForm.TBUsuario.Clear();
                loginForm.TBContraseña.Clear();
            }
        }



        private void BCerrarMenuGerente_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = Interaction.MsgBox("¿Esta seguro de que quiere cerrar sesión?", (MsgBoxStyle)((int)Constants.vbExclamation + (int)Constants.vbYesNo), "Cerrar Sesión");
            if (ask == Constants.vbYes)
            {
                Application.Exit();
            }
        }

        private void BMaximizarMenuGerente_Click(object sender, EventArgs e)
        {
            BMaximizarMenuGerente.Visible = false;
            BRestaurarMenuGerente.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenuGerente_Click(object sender, EventArgs e)
        {
            BRestaurarMenuGerente.Visible = false;
            BMaximizarMenuGerente.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void BMinimizarMenuGerente_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraMenuAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenuAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void PanelBarraMenuAdmin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }


        private void BUsuarios_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuUsuarios);
        }

        private void BAñadirUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new AñadirUsuario());
        }

        private void BGestionarUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new GestionarUsuarios());
        }


        private void BEmpleados_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuEmpleados);
        }

        private void BAñadirEmpleado_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new AñadirEmpleado());
        }


        private void BGestionarEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new GestionarEmpleados());
        }

        private void BPerfiles_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuPerfiles);
        }

        private void BAñadirPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new AñadirPerfil());
        }

        private void BGestionarPerfiles_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdministrador(new GestionarPerfiles());
        }



        private Form? formActivoAdministrador;


        private void AbrirFormulariosAdministrador(Form formHijo)
        {
            if (formActivoAdministrador == null)
            {
                PanelFormSuperAdministrador.Controls.Clear();
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;
                formHijo.Visible = true;
                formHijo.AutoScroll = true;
                formHijo.VerticalScroll.Value = 0;
                formHijo.VerticalScroll.Minimum = 0;
                formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100;
                formHijo.HorizontalScroll.Value = 0;
                formHijo.HorizontalScroll.Minimum = 0;
                formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100;
                PanelFormSuperAdministrador.AutoScroll = true;
                PanelFormSuperAdministrador.Controls.Add(formHijo);
                PanelFormSuperAdministrador.Tag = formHijo;
                PanelFormSuperAdministrador.BringToFront();
                formHijo.Show();
                hideSubMenu();
            }
        }
    }
}
