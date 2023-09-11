namespace Unitivo.Presentacion.Vendedor
{
    partial class MenuV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PanelBarraMenu = new Panel();
            PanelBarraMenu.MouseDown += new MouseEventHandler(PanelBarraMenu_MouseDown);
            PanelBarraMenu.MouseUp += new MouseEventHandler(PanelBarraMenu_MouseUp);
            PanelBarraMenu.MouseMove += new MouseEventHandler(PanelBarraMenu_MouseMove);
            BMaximizarMenu = new Button();
            BMaximizarMenu.Click += new EventHandler(BMaximizarMenu_Click);
            BCerrarMenu = new Button();
            BCerrarMenu.Click += new EventHandler(BCerrarMenu_Click);
            BRestaurarMenu = new Button();
            BRestaurarMenu.Click += new EventHandler(BRestaurarMenu_Click);
            BMinimizarMenu = new Button();
            BMinimizarMenu.Click += new EventHandler(BMinimizarMenu_Click);
            PanelMenuLateral = new Panel();
            PanelSubMenuProductos = new Panel();
            BListarProductos = new Button();
            BListarProductos.Click += new EventHandler(BListarProductos_Click);
            BProductos = new Button();
            BProductos.Click += new EventHandler(BProductos_Click);
            PanelSubMenuFacturación = new Panel();
            BListarVentas = new Button();
            BListarVentas.Click += new EventHandler(BListarVentas_Click);
            BNuevaVenta = new Button();
            BNuevaVenta.Click += new EventHandler(BNuevaVenta_Click);
            BSalir = new Button();
            BSalir.Click += new EventHandler(BSalir_Click);
            BFacturación = new Button();
            BFacturación.Click += new EventHandler(BFacturación_Click);
            PanelSubMenuClientes = new Panel();
            BListaClientes = new Button();
            BListaClientes.Click += new EventHandler(BListaClientes_Click);
            BAñadirClientes = new Button();
            BAñadirClientes.Click += new EventHandler(BAñadirClientes_Click);
            BClientes = new Button();
            BClientes.Click += new EventHandler(BClientes_Click);
            PanelFormVendedor = new Panel();
            Label1 = new Label();
            PanelBarraMenu.SuspendLayout();
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuProductos.SuspendLayout();
            PanelSubMenuFacturación.SuspendLayout();
            PanelSubMenuClientes.SuspendLayout();
            PanelFormVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBarraMenu
            // 
            PanelBarraMenu.BackColor = Color.Tan;
            PanelBarraMenu.Controls.Add(BMaximizarMenu);
            PanelBarraMenu.Controls.Add(BCerrarMenu);
            PanelBarraMenu.Controls.Add(BRestaurarMenu);
            PanelBarraMenu.Controls.Add(BMinimizarMenu);
            PanelBarraMenu.Dock = DockStyle.Top;
            PanelBarraMenu.Location = new Point(0, 0);
            PanelBarraMenu.Name = "PanelBarraMenu";
            PanelBarraMenu.Size = new Size(1040, 60);
            PanelBarraMenu.TabIndex = 1;
            // 
            // BMaximizarMenu
            // 
            BMaximizarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenu.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenu.FlatAppearance.BorderSize = 0;
            BMaximizarMenu.FlatStyle = FlatStyle.Flat;
            BMaximizarMenu.Location = new Point(950, 17);
            BMaximizarMenu.Name = "BMaximizarMenu";
            BMaximizarMenu.Size = new Size(30, 30);
            BMaximizarMenu.TabIndex = 3;
            BMaximizarMenu.UseVisualStyleBackColor = true;
            // 
            // BCerrarMenu
            // 
            BCerrarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenu.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenu.FlatAppearance.BorderSize = 0;
            BCerrarMenu.FlatStyle = FlatStyle.Flat;
            BCerrarMenu.Location = new Point(990, 17);
            BCerrarMenu.Name = "BCerrarMenu";
            BCerrarMenu.Size = new Size(30, 30);
            BCerrarMenu.TabIndex = 2;
            BCerrarMenu.UseVisualStyleBackColor = true;
            // 
            // BRestaurarMenu
            // 
            BRestaurarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenu.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenu.FlatAppearance.BorderSize = 0;
            BRestaurarMenu.FlatStyle = FlatStyle.Flat;
            BRestaurarMenu.Location = new Point(950, 17);
            BRestaurarMenu.Name = "BRestaurarMenu";
            BRestaurarMenu.Size = new Size(30, 30);
            BRestaurarMenu.TabIndex = 1;
            BRestaurarMenu.UseVisualStyleBackColor = true;
            // 
            // BMinimizarMenu
            // 
            BMinimizarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenu.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenu.FlatAppearance.BorderSize = 0;
            BMinimizarMenu.FlatStyle = FlatStyle.Flat;
            BMinimizarMenu.Location = new Point(910, 17);
            BMinimizarMenu.Name = "BMinimizarMenu";
            BMinimizarMenu.Size = new Size(30, 30);
            BMinimizarMenu.TabIndex = 0;
            BMinimizarMenu.UseVisualStyleBackColor = true;
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(PanelSubMenuProductos);
            PanelMenuLateral.Controls.Add(BProductos);
            PanelMenuLateral.Controls.Add(PanelSubMenuFacturación);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(BFacturación);
            PanelMenuLateral.Controls.Add(PanelSubMenuClientes);
            PanelMenuLateral.Controls.Add(BClientes);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 60);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(230, 590);
            PanelMenuLateral.TabIndex = 2;
            // 
            // PanelSubMenuProductos
            // 
            PanelSubMenuProductos.BackColor = Color.FloralWhite;
            PanelSubMenuProductos.Controls.Add(BListarProductos);
            PanelSubMenuProductos.Dock = DockStyle.Top;
            PanelSubMenuProductos.Location = new Point(0, 326);
            PanelSubMenuProductos.Name = "PanelSubMenuProductos";
            PanelSubMenuProductos.Size = new Size(230, 45);
            PanelSubMenuProductos.TabIndex = 13;
            // 
            // BListarProductos
            // 
            BListarProductos.BackColor = Color.FloralWhite;
            BListarProductos.Dock = DockStyle.Top;
            BListarProductos.FlatAppearance.BorderSize = 0;
            BListarProductos.FlatStyle = FlatStyle.Flat;
            BListarProductos.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BListarProductos.ForeColor = Color.Sienna;
            BListarProductos.Location = new Point(0, 0);
            BListarProductos.Name = "BListarProductos";
            BListarProductos.Size = new Size(230, 40);
            BListarProductos.TabIndex = 1;
            BListarProductos.Text = "Listar Productos";
            BListarProductos.UseVisualStyleBackColor = false;
            // 
            // BProductos
            // 
            BProductos.BackColor = Color.RosyBrown;
            BProductos.Dock = DockStyle.Top;
            BProductos.FlatAppearance.BorderSize = 0;
            BProductos.FlatStyle = FlatStyle.Flat;
            BProductos.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BProductos.ForeColor = Color.Cornsilk;
            BProductos.Image = Properties.Resources.icons8_camiseta_48;
            BProductos.ImageAlign = ContentAlignment.MiddleLeft;
            BProductos.Location = new Point(0, 274);
            BProductos.Name = "BProductos";
            BProductos.Size = new Size(230, 52);
            BProductos.TabIndex = 12;
            BProductos.Text = "Productos";
            BProductos.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuFacturación
            // 
            PanelSubMenuFacturación.BackColor = Color.FloralWhite;
            PanelSubMenuFacturación.Controls.Add(BListarVentas);
            PanelSubMenuFacturación.Controls.Add(BNuevaVenta);
            PanelSubMenuFacturación.Dock = DockStyle.Top;
            PanelSubMenuFacturación.Location = new Point(0, 189);
            PanelSubMenuFacturación.Name = "PanelSubMenuFacturación";
            PanelSubMenuFacturación.Size = new Size(230, 85);
            PanelSubMenuFacturación.TabIndex = 11;
            // 
            // BListarVentas
            // 
            BListarVentas.BackColor = Color.FloralWhite;
            BListarVentas.Dock = DockStyle.Top;
            BListarVentas.FlatAppearance.BorderSize = 0;
            BListarVentas.FlatStyle = FlatStyle.Flat;
            BListarVentas.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BListarVentas.ForeColor = Color.Sienna;
            BListarVentas.Location = new Point(0, 40);
            BListarVentas.Name = "BListarVentas";
            BListarVentas.Size = new Size(230, 40);
            BListarVentas.TabIndex = 2;
            BListarVentas.Text = "Listar Ventas";
            BListarVentas.UseVisualStyleBackColor = false;
            // 
            // BNuevaVenta
            // 
            BNuevaVenta.BackColor = Color.FloralWhite;
            BNuevaVenta.Dock = DockStyle.Top;
            BNuevaVenta.FlatAppearance.BorderSize = 0;
            BNuevaVenta.FlatStyle = FlatStyle.Flat;
            BNuevaVenta.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BNuevaVenta.ForeColor = Color.Sienna;
            BNuevaVenta.Location = new Point(0, 0);
            BNuevaVenta.Name = "BNuevaVenta";
            BNuevaVenta.Size = new Size(230, 40);
            BNuevaVenta.TabIndex = 1;
            BNuevaVenta.Text = "Nueva Venta";
            BNuevaVenta.UseVisualStyleBackColor = false;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Sienna;
            BSalir.Dock = DockStyle.Bottom;
            BSalir.FlatAppearance.BorderSize = 2;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSalir.ForeColor = Color.Cornsilk;
            BSalir.Location = new Point(0, 557);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(230, 33);
            BSalir.TabIndex = 8;
            BSalir.Text = "Cerrar Sesión";
            BSalir.TextAlign = ContentAlignment.TopCenter;
            BSalir.UseVisualStyleBackColor = false;
            // 
            // BFacturación
            // 
            BFacturación.BackColor = Color.RosyBrown;
            BFacturación.Dock = DockStyle.Top;
            BFacturación.FlatAppearance.BorderSize = 0;
            BFacturación.FlatStyle = FlatStyle.Flat;
            BFacturación.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BFacturación.ForeColor = Color.Cornsilk;
            BFacturación.Image = Properties.Resources.icons8_cuenta_50;
            BFacturación.ImageAlign = ContentAlignment.MiddleLeft;
            BFacturación.Location = new Point(0, 137);
            BFacturación.Name = "BFacturación";
            BFacturación.Size = new Size(230, 52);
            BFacturación.TabIndex = 10;
            BFacturación.Text = "    Facturación";
            BFacturación.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuClientes
            // 
            PanelSubMenuClientes.BackColor = Color.FloralWhite;
            PanelSubMenuClientes.Controls.Add(BListaClientes);
            PanelSubMenuClientes.Controls.Add(BAñadirClientes);
            PanelSubMenuClientes.Dock = DockStyle.Top;
            PanelSubMenuClientes.Location = new Point(0, 52);
            PanelSubMenuClientes.Name = "PanelSubMenuClientes";
            PanelSubMenuClientes.Size = new Size(230, 85);
            PanelSubMenuClientes.TabIndex = 9;
            // 
            // BListaClientes
            // 
            BListaClientes.BackColor = Color.FloralWhite;
            BListaClientes.Dock = DockStyle.Top;
            BListaClientes.FlatAppearance.BorderSize = 0;
            BListaClientes.FlatStyle = FlatStyle.Flat;
            BListaClientes.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BListaClientes.ForeColor = Color.Sienna;
            BListaClientes.Location = new Point(0, 40);
            BListaClientes.Name = "BListaClientes";
            BListaClientes.Size = new Size(230, 40);
            BListaClientes.TabIndex = 2;
            BListaClientes.Text = "Listar Clientes";
            BListaClientes.UseVisualStyleBackColor = false;
            // 
            // BAñadirClientes
            // 
            BAñadirClientes.BackColor = Color.FloralWhite;
            BAñadirClientes.Dock = DockStyle.Top;
            BAñadirClientes.FlatAppearance.BorderSize = 0;
            BAñadirClientes.FlatStyle = FlatStyle.Flat;
            BAñadirClientes.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirClientes.ForeColor = Color.Sienna;
            BAñadirClientes.Location = new Point(0, 0);
            BAñadirClientes.Name = "BAñadirClientes";
            BAñadirClientes.Size = new Size(230, 40);
            BAñadirClientes.TabIndex = 1;
            BAñadirClientes.Text = "Añadir Clientes";
            BAñadirClientes.UseVisualStyleBackColor = false;
            // 
            // BClientes
            // 
            BClientes.BackColor = Color.RosyBrown;
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BClientes.ForeColor = Color.Cornsilk;
            BClientes.Image = Properties.Resources.icons8_contactos_50__1_;
            BClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BClientes.Location = new Point(0, 0);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(230, 52);
            BClientes.TabIndex = 0;
            BClientes.Text = "Clientes";
            BClientes.UseVisualStyleBackColor = false;
            // 
            // PanelFormVendedor
            // 
            PanelFormVendedor.Anchor = AnchorStyles.None;
            PanelFormVendedor.BackgroundImage = Properties.Resources.ImagenGrandeVendedor;
            PanelFormVendedor.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormVendedor.Controls.Add(Label1);
            PanelFormVendedor.Location = new Point(230, 60);
            PanelFormVendedor.Name = "PanelFormVendedor";
            PanelFormVendedor.Size = new Size(810, 590);
            PanelFormVendedor.TabIndex = 3;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.LightSteelBlue;
            Label1.Font = new Font("Cooper Black", 36.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.DarkRed;
            Label1.Location = new Point(255, 167);
            Label1.Name = "Label1";
            Label1.Size = new Size(0, 55);
            Label1.TabIndex = 4;
            // 
            // MenuV
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 650);
            Controls.Add(PanelFormVendedor);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuV";
            Text = "Form1";
            PanelBarraMenu.ResumeLayout(false);
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuProductos.ResumeLayout(false);
            PanelSubMenuFacturación.ResumeLayout(false);
            PanelSubMenuClientes.ResumeLayout(false);
            PanelFormVendedor.ResumeLayout(false);
            PanelFormVendedor.PerformLayout();
            Load += new EventHandler(MenuV_Load);
            ResumeLayout(false);

        }

        internal Panel PanelBarraMenu;
        internal Button BMaximizarMenu;
        internal Button BCerrarMenu;
        internal Button BRestaurarMenu;
        internal Button BMinimizarMenu;
        internal Panel PanelMenuLateral;
        internal Button BClientes;
        internal Button BSalir;
        internal Button BAñadirClientes;
        internal Panel PanelSubMenuProductos;
        internal Button BListarProductos;
        internal Button BProductos;
        internal Panel PanelSubMenuFacturación;
        internal Button BListarVentas;
        internal Button BNuevaVenta;
        internal Button BFacturación;
        internal Panel PanelSubMenuClientes;
        internal Button BListaClientes;
        internal Label Label1;
        internal Panel PanelFormVendedor;

        #endregion
    }
}