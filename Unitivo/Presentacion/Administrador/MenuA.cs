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

namespace Unitivo.Presentacion.Administrador
{
    public partial class MenuA : Form
    {

        private int state;
        private int px, py;
        private bool mover;

        public MenuA()
        {
            InitializeComponent();
        }

        private void G_Load(object sender, EventArgs e)
        {
            MinimumSize = new Size(900, 500);
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PanelSubMenuProductos.Visible = false;
            PanelSubMenuCategorias.Visible = false;
            PanelSubMenuVentas.Visible = false;
            PanelSubMenuTalles.Visible = false;
            PanelSubMenuClientes.Visible = false;

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

        private void BProductosAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuProductos);
        }

        private void BAñadirProductosAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirProducto());
        }

        private void BGestionarProductosAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarProductos());
        }

        private void BVentasAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuVentas);
        }

        private void BListarVentasAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new ListarVentasAdmin());
        }

        private void BListarVendedoresAdmin_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new ListarVendedores());
        }

        private void BCategoriasAdmin_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuCategorias);
        }

        private void BAñadirCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirCategoria());
        }

        private void BGestionarCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarCategorias());
        }

        private void BTalles_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuTalles);
        }

        private void BAñadirTalle_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new AñadirTalle());
        }

        private void BGestionarTalles_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarTalles());
        }

        private void BClientes_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelSubMenuClientes);
        }

        private void BGestionarClientes_Click(object sender, EventArgs e)
        {
            AbrirFormulariosAdmin(new GestionarClientes());
        }




        private Form formActivoAdmin = null;
        private void AbrirFormulariosAdmin(Form formHijo)
        {
            if (formActivoAdmin is not null)
            {
                PanelFormAdmin.Controls.Clear();
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
                PanelFormAdmin.Controls.Add(formHijo);
                PanelFormAdmin.Tag = formHijo;
                PanelFormAdmin.BringToFront();
                PanelFormAdmin.AutoScroll = true;
                formHijo.Show();
                hideSubMenu();

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


    private void BCerrarMenuAdmin_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;
            ask = Interaction.MsgBox("¿Esta seguro de que quiere cerrar la aplicación?", (MsgBoxStyle)((int)Constants.vbExclamation + (int)Constants.vbYesNo), "Cerrar Aplicación");
            if (ask == Constants.vbYes)
            {
                Application.Exit();
            }
        }

        private void BMaximizarMenuAdmin_Click(object sender, EventArgs e)
        {
            BMaximizarMenuAdmin.Visible = false;
            BRestaurarMenuAdmin.Visible = true;
            WindowState = FormWindowState.Maximized;
        }

        private void BRestaurarMenuAdmin_Click(object sender, EventArgs e)
        {
            BRestaurarMenuAdmin.Visible = false;
            BMaximizarMenuAdmin.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void BMinimizarMenuAdmin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void PanelBarraMenu_MouseDown(object sender, MouseEventArgs e)
        {
            px = e.X;
            py = e.Y;
            mover = true;
        }

        private void PanelBarraMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mover = false;
        }



        private void PanelBarraMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mover)
            {
                Location = PointToScreen(new Point(MousePosition.X - Location.X - px, MousePosition.Y - Location.Y - py));

            }
        }
    }
}
