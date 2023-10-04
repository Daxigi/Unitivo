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

namespace Unitivo.Presentacion.Gerente
{
    public partial class MenuG : Form
    {
        private int state;
        private int px, py;
        private bool mover;

        public MenuG()
        {
            InitializeComponent();
        }

        private void MenuG_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PanelSubMenuBD.Visible = false;
            PanelSubMenuReportes.Visible = false;
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



        private void BCerrarMenuG_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = Interaction.MsgBox("¿Esta seguro de que quiere cerrar sesión?", (MsgBoxStyle)((int)Constants.vbExclamation + (int)Constants.vbYesNo), "Cerrar Sesión");
            if (ask == Constants.vbYes)
            {
                Application.Exit();
            }
        }

        private void BMaximizarMenuG_Click(object sender, EventArgs e)
        {
            BMaximizarMenuG.Visible = false;
            BRestaurarMenuG.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenuG_Click(object sender, EventArgs e)
        {
            BRestaurarMenuG.Visible = false;
            BMaximizarMenuG.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void BMinimizarMenuG_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraMenuG_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenuG_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }
        private void PanelBarraMenuG_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }


        private void BBaseDeDatos_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuBD);
        }

        private void BFunciones_Click(object sender, EventArgs e)
        {
            AbrirFormulariosG(new ManejoBD());
        }

        private void BReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuReportes);
        }

        private void BVentasCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulariosG(new VentasPorCategoria());
        }





        // Variable para el formulario activo
        private Form? formularioActivo;

        private void BVolver_Click(object sender, EventArgs e)
        {
            // Verificar si hay un formulario activo
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo
                formularioActivo = null;  // Establecer que no hay formulario activo
            }
        }

        private void AbrirFormulariosG(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close(); // Cerrar el formulario activo actual
            }

            // Configurar el formulario hijo como el formulario activo
            formularioActivo = formHijo;

            PanelFormG.Controls.Clear();
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
            PanelFormG.Controls.Add(formHijo);
            PanelFormG.Tag = formHijo;
            PanelFormG.BringToFront();
            PanelFormG.AutoScroll = true;
            formHijo.Show();
            hideSubMenu();

        }

    }
}
