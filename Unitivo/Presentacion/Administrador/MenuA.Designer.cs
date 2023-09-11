namespace Unitivo.Presentacion.Administrador
{
    partial class MenuA
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
            BSalir = new Button();
            BSalir.Click += new EventHandler(BSalir_Click);
            PanelMenuLateral = new Panel();
            PanelSubMenuClientes = new Panel();
            BGestionarClientes = new Button();
            BGestionarClientes.Click += new EventHandler(BGestionarClientes_Click);
            PanelSubMenuTalles = new Panel();
            BGestionarTalles = new Button();
            BGestionarTalles.Click += new EventHandler(BGestionarTalles_Click);
            BAñadirTalle = new Button();
            BAñadirTalle.Click += new EventHandler(BAñadirTalle_Click);
            PanelSubMenuCategorias = new Panel();
            BGestionarCategorias = new Button();
            BGestionarCategorias.Click += new EventHandler(BGestionarCategorias_Click);
            BAñadirCategoria = new Button();
            BAñadirCategoria.Click += new EventHandler(BAñadirCategoria_Click);
            PanelSubMenuVentas = new Panel();
            BListarVendedoresAdmin = new Button();
            BListarVendedoresAdmin.Click += new EventHandler(BListarVendedoresAdmin_Click);
            BListarVentasAdmin = new Button();
            BListarVentasAdmin.Click += new EventHandler(BListarVentasAdmin_Click);
            PanelSubMenuProductos = new Panel();
            BGestionarProductosAdmin = new Button();
            BGestionarProductosAdmin.Click += new EventHandler(BGestionarProductosAdmin_Click);
            BAñadirProductoAdmin = new Button();
            BAñadirProductoAdmin.Click += new EventHandler(BAñadirProductosAdmin_Click);
            PanelBarraMenu = new Panel();
            PanelBarraMenu.MouseDown += new MouseEventHandler(PanelBarraMenu_MouseDown);
            PanelBarraMenu.MouseUp += new MouseEventHandler(PanelBarraMenu_MouseUp);
            PanelBarraMenu.MouseMove += new MouseEventHandler(PanelBarraMenu_MouseMove);
            PanelFormAdmin = new Panel();
            Label1 = new Label();
            BClientes = new Button();
            BClientes.Click += new EventHandler(BClientes_Click);
            BTalles = new Button();
            BTalles.Click += new EventHandler(BTalles_Click);
            BCategoriasAdmin = new Button();
            BCategoriasAdmin.Click += new EventHandler(BCategoriasAdmin_Click);
            BVentasAdmin = new Button();
            BVentasAdmin.Click += new EventHandler(BVentasAdmin_Click);
            BProductosAdmin = new Button();
            BProductosAdmin.Click += new EventHandler(BProductosAdmin_Click);
            BMaximizarMenuAdmin = new Button();
            BMaximizarMenuAdmin.Click += new EventHandler(BMaximizarMenuAdmin_Click);
            BCerrarMenuAdmin = new Button();
            BCerrarMenuAdmin.Click += new EventHandler(BCerrarMenuAdmin_Click);
            BRestaurarMenuAdmin = new Button();
            BRestaurarMenuAdmin.Click += new EventHandler(BRestaurarMenuAdmin_Click);
            BMinimizarMenuAdmin = new Button();
            BMinimizarMenuAdmin.Click += new EventHandler(BMinimizarMenuAdmin_Click);
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuClientes.SuspendLayout();
            PanelSubMenuTalles.SuspendLayout();
            PanelSubMenuCategorias.SuspendLayout();
            PanelSubMenuVentas.SuspendLayout();
            PanelSubMenuProductos.SuspendLayout();
            PanelBarraMenu.SuspendLayout();
            PanelFormAdmin.SuspendLayout();
            SuspendLayout();
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Sienna;
            BSalir.Dock = DockStyle.Bottom;
            BSalir.FlatAppearance.BorderSize = 2;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSalir.ForeColor = Color.Cornsilk;
            BSalir.Location = new Point(0, 707);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(213, 39);
            BSalir.TabIndex = 8;
            BSalir.Text = "Cerrar Sesión";
            BSalir.TextAlign = ContentAlignment.TopCenter;
            BSalir.UseVisualStyleBackColor = false;
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(PanelSubMenuClientes);
            PanelMenuLateral.Controls.Add(BClientes);
            PanelMenuLateral.Controls.Add(PanelSubMenuTalles);
            PanelMenuLateral.Controls.Add(BTalles);
            PanelMenuLateral.Controls.Add(PanelSubMenuCategorias);
            PanelMenuLateral.Controls.Add(BCategoriasAdmin);
            PanelMenuLateral.Controls.Add(PanelSubMenuVentas);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(BVentasAdmin);
            PanelMenuLateral.Controls.Add(PanelSubMenuProductos);
            PanelMenuLateral.Controls.Add(BProductosAdmin);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 60);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(230, 590);
            PanelMenuLateral.TabIndex = 8;
            // 
            // PanelSubMenuClientes
            // 
            PanelSubMenuClientes.BackColor = Color.FloralWhite;
            PanelSubMenuClientes.Controls.Add(BGestionarClientes);
            PanelSubMenuClientes.Dock = DockStyle.Top;
            PanelSubMenuClientes.Location = new Point(0, 658);
            PanelSubMenuClientes.Name = "PanelSubMenuClientes";
            PanelSubMenuClientes.Size = new Size(213, 49);
            PanelSubMenuClientes.TabIndex = 18;
            // 
            // BGestionarClientes
            // 
            BGestionarClientes.BackColor = Color.FloralWhite;
            BGestionarClientes.Dock = DockStyle.Top;
            BGestionarClientes.FlatAppearance.BorderSize = 0;
            BGestionarClientes.FlatStyle = FlatStyle.Flat;
            BGestionarClientes.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarClientes.ForeColor = Color.Sienna;
            BGestionarClientes.Location = new Point(0, 0);
            BGestionarClientes.Name = "BGestionarClientes";
            BGestionarClientes.Size = new Size(213, 40);
            BGestionarClientes.TabIndex = 1;
            BGestionarClientes.Text = "Gestionar Clientes";
            BGestionarClientes.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuTalles
            // 
            PanelSubMenuTalles.BackColor = Color.FloralWhite;
            PanelSubMenuTalles.Controls.Add(BGestionarTalles);
            PanelSubMenuTalles.Controls.Add(BAñadirTalle);
            PanelSubMenuTalles.Dock = DockStyle.Top;
            PanelSubMenuTalles.Location = new Point(0, 521);
            PanelSubMenuTalles.Name = "PanelSubMenuTalles";
            PanelSubMenuTalles.Size = new Size(213, 85);
            PanelSubMenuTalles.TabIndex = 15;
            // 
            // BGestionarTalles
            // 
            BGestionarTalles.BackColor = Color.FloralWhite;
            BGestionarTalles.Dock = DockStyle.Top;
            BGestionarTalles.FlatAppearance.BorderSize = 0;
            BGestionarTalles.FlatStyle = FlatStyle.Flat;
            BGestionarTalles.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarTalles.ForeColor = Color.Sienna;
            BGestionarTalles.Location = new Point(0, 40);
            BGestionarTalles.Name = "BGestionarTalles";
            BGestionarTalles.Size = new Size(213, 40);
            BGestionarTalles.TabIndex = 2;
            BGestionarTalles.Text = "Gestionar Talles";
            BGestionarTalles.UseVisualStyleBackColor = false;
            // 
            // BAñadirTalle
            // 
            BAñadirTalle.BackColor = Color.FloralWhite;
            BAñadirTalle.Dock = DockStyle.Top;
            BAñadirTalle.FlatAppearance.BorderSize = 0;
            BAñadirTalle.FlatStyle = FlatStyle.Flat;
            BAñadirTalle.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirTalle.ForeColor = Color.Sienna;
            BAñadirTalle.Location = new Point(0, 0);
            BAñadirTalle.Name = "BAñadirTalle";
            BAñadirTalle.Size = new Size(213, 40);
            BAñadirTalle.TabIndex = 1;
            BAñadirTalle.Text = "Añadir Talle";
            BAñadirTalle.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuCategorias
            // 
            PanelSubMenuCategorias.BackColor = Color.FloralWhite;
            PanelSubMenuCategorias.Controls.Add(BGestionarCategorias);
            PanelSubMenuCategorias.Controls.Add(BAñadirCategoria);
            PanelSubMenuCategorias.Dock = DockStyle.Top;
            PanelSubMenuCategorias.Location = new Point(0, 362);
            PanelSubMenuCategorias.Name = "PanelSubMenuCategorias";
            PanelSubMenuCategorias.Size = new Size(213, 100);
            PanelSubMenuCategorias.TabIndex = 13;
            // 
            // BGestionarCategorias
            // 
            BGestionarCategorias.BackColor = Color.FloralWhite;
            BGestionarCategorias.Dock = DockStyle.Top;
            BGestionarCategorias.FlatAppearance.BorderSize = 0;
            BGestionarCategorias.FlatStyle = FlatStyle.Flat;
            BGestionarCategorias.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarCategorias.ForeColor = Color.Sienna;
            BGestionarCategorias.Location = new Point(0, 40);
            BGestionarCategorias.Name = "BGestionarCategorias";
            BGestionarCategorias.Size = new Size(213, 54);
            BGestionarCategorias.TabIndex = 2;
            BGestionarCategorias.Text = "Gestionar Categorias";
            BGestionarCategorias.UseVisualStyleBackColor = false;
            // 
            // BAñadirCategoria
            // 
            BAñadirCategoria.BackColor = Color.FloralWhite;
            BAñadirCategoria.Dock = DockStyle.Top;
            BAñadirCategoria.FlatAppearance.BorderSize = 0;
            BAñadirCategoria.FlatStyle = FlatStyle.Flat;
            BAñadirCategoria.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirCategoria.ForeColor = Color.Sienna;
            BAñadirCategoria.Location = new Point(0, 0);
            BAñadirCategoria.Name = "BAñadirCategoria";
            BAñadirCategoria.Size = new Size(213, 40);
            BAñadirCategoria.TabIndex = 1;
            BAñadirCategoria.Text = "Añadir Categoria";
            BAñadirCategoria.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuVentas
            // 
            PanelSubMenuVentas.BackColor = Color.FloralWhite;
            PanelSubMenuVentas.Controls.Add(BListarVendedoresAdmin);
            PanelSubMenuVentas.Controls.Add(BListarVentasAdmin);
            PanelSubMenuVentas.Dock = DockStyle.Top;
            PanelSubMenuVentas.Location = new Point(0, 218);
            PanelSubMenuVentas.Name = "PanelSubMenuVentas";
            PanelSubMenuVentas.Size = new Size(213, 85);
            PanelSubMenuVentas.TabIndex = 11;
            // 
            // BListarVendedoresAdmin
            // 
            BListarVendedoresAdmin.BackColor = Color.FloralWhite;
            BListarVendedoresAdmin.Dock = DockStyle.Top;
            BListarVendedoresAdmin.FlatAppearance.BorderSize = 0;
            BListarVendedoresAdmin.FlatStyle = FlatStyle.Flat;
            BListarVendedoresAdmin.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BListarVendedoresAdmin.ForeColor = Color.Sienna;
            BListarVendedoresAdmin.Location = new Point(0, 40);
            BListarVendedoresAdmin.Name = "BListarVendedoresAdmin";
            BListarVendedoresAdmin.Size = new Size(213, 40);
            BListarVendedoresAdmin.TabIndex = 2;
            BListarVendedoresAdmin.Text = "Listar Vendedores";
            BListarVendedoresAdmin.UseVisualStyleBackColor = false;
            // 
            // BListarVentasAdmin
            // 
            BListarVentasAdmin.BackColor = Color.FloralWhite;
            BListarVentasAdmin.Dock = DockStyle.Top;
            BListarVentasAdmin.FlatAppearance.BorderSize = 0;
            BListarVentasAdmin.FlatStyle = FlatStyle.Flat;
            BListarVentasAdmin.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BListarVentasAdmin.ForeColor = Color.Sienna;
            BListarVentasAdmin.Location = new Point(0, 0);
            BListarVentasAdmin.Name = "BListarVentasAdmin";
            BListarVentasAdmin.Size = new Size(213, 40);
            BListarVentasAdmin.TabIndex = 1;
            BListarVentasAdmin.Text = "Listar Ventas";
            BListarVentasAdmin.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuProductos
            // 
            PanelSubMenuProductos.BackColor = Color.FloralWhite;
            PanelSubMenuProductos.Controls.Add(BGestionarProductosAdmin);
            PanelSubMenuProductos.Controls.Add(BAñadirProductoAdmin);
            PanelSubMenuProductos.Dock = DockStyle.Top;
            PanelSubMenuProductos.Location = new Point(0, 59);
            PanelSubMenuProductos.Name = "PanelSubMenuProductos";
            PanelSubMenuProductos.Size = new Size(213, 100);
            PanelSubMenuProductos.TabIndex = 9;
            // 
            // BGestionarProductosAdmin
            // 
            BGestionarProductosAdmin.BackColor = Color.FloralWhite;
            BGestionarProductosAdmin.Dock = DockStyle.Top;
            BGestionarProductosAdmin.FlatAppearance.BorderSize = 0;
            BGestionarProductosAdmin.FlatStyle = FlatStyle.Flat;
            BGestionarProductosAdmin.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarProductosAdmin.ForeColor = Color.Sienna;
            BGestionarProductosAdmin.Location = new Point(0, 40);
            BGestionarProductosAdmin.Name = "BGestionarProductosAdmin";
            BGestionarProductosAdmin.Size = new Size(213, 54);
            BGestionarProductosAdmin.TabIndex = 2;
            BGestionarProductosAdmin.Text = "Gestionar Productos";
            BGestionarProductosAdmin.UseVisualStyleBackColor = false;
            // 
            // BAñadirProductoAdmin
            // 
            BAñadirProductoAdmin.BackColor = Color.FloralWhite;
            BAñadirProductoAdmin.Dock = DockStyle.Top;
            BAñadirProductoAdmin.FlatAppearance.BorderSize = 0;
            BAñadirProductoAdmin.FlatStyle = FlatStyle.Flat;
            BAñadirProductoAdmin.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirProductoAdmin.ForeColor = Color.Sienna;
            BAñadirProductoAdmin.Location = new Point(0, 0);
            BAñadirProductoAdmin.Name = "BAñadirProductoAdmin";
            BAñadirProductoAdmin.Size = new Size(213, 40);
            BAñadirProductoAdmin.TabIndex = 1;
            BAñadirProductoAdmin.Text = "Añadir Producto";
            BAñadirProductoAdmin.UseVisualStyleBackColor = false;
            // 
            // PanelBarraMenu
            // 
            PanelBarraMenu.BackColor = Color.Tan;
            PanelBarraMenu.Controls.Add(BMaximizarMenuAdmin);
            PanelBarraMenu.Controls.Add(BCerrarMenuAdmin);
            PanelBarraMenu.Controls.Add(BRestaurarMenuAdmin);
            PanelBarraMenu.Controls.Add(BMinimizarMenuAdmin);
            PanelBarraMenu.Dock = DockStyle.Top;
            PanelBarraMenu.Location = new Point(0, 0);
            PanelBarraMenu.Name = "PanelBarraMenu";
            PanelBarraMenu.Size = new Size(1040, 60);
            PanelBarraMenu.TabIndex = 7;
            // 
            // PanelFormAdmin
            // 
            PanelFormAdmin.Anchor = AnchorStyles.None;
            PanelFormAdmin.BackgroundImage = Properties.Resources.imggrande5;
            PanelFormAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormAdmin.Controls.Add(Label1);
            PanelFormAdmin.Location = new Point(230, 60);
            PanelFormAdmin.Name = "PanelFormAdmin";
            PanelFormAdmin.Size = new Size(810, 590);
            PanelFormAdmin.TabIndex = 9;
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
            // BClientes
            // 
            BClientes.BackColor = Color.RosyBrown;
            BClientes.Dock = DockStyle.Top;
            BClientes.FlatAppearance.BorderSize = 0;
            BClientes.FlatStyle = FlatStyle.Flat;
            BClientes.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BClientes.ForeColor = Color.Cornsilk;
            BClientes.Image = Properties.Resources.icons8_contactos_50__2_;
            BClientes.ImageAlign = ContentAlignment.MiddleLeft;
            BClientes.Location = new Point(0, 606);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(213, 52);
            BClientes.TabIndex = 17;
            BClientes.Text = "Clientes";
            BClientes.TextAlign = ContentAlignment.MiddleLeft;
            BClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BClientes.UseVisualStyleBackColor = false;
            // 
            // BTalles
            // 
            BTalles.BackColor = Color.RosyBrown;
            BTalles.Dock = DockStyle.Top;
            BTalles.FlatAppearance.BorderSize = 0;
            BTalles.FlatStyle = FlatStyle.Flat;
            BTalles.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BTalles.ForeColor = Color.Cornsilk;
            BTalles.Image = Properties.Resources.icons8_patrón_de_la_camisa_a_medida_48;
            BTalles.ImageAlign = ContentAlignment.MiddleLeft;
            BTalles.Location = new Point(0, 462);
            BTalles.Name = "BTalles";
            BTalles.Size = new Size(213, 59);
            BTalles.TabIndex = 14;
            BTalles.Text = "Talles";
            BTalles.TextAlign = ContentAlignment.MiddleLeft;
            BTalles.TextImageRelation = TextImageRelation.ImageBeforeText;
            BTalles.UseVisualStyleBackColor = false;
            // 
            // BCategoriasAdmin
            // 
            BCategoriasAdmin.BackColor = Color.RosyBrown;
            BCategoriasAdmin.Dock = DockStyle.Top;
            BCategoriasAdmin.FlatAppearance.BorderSize = 0;
            BCategoriasAdmin.FlatStyle = FlatStyle.Flat;
            BCategoriasAdmin.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BCategoriasAdmin.ForeColor = Color.Cornsilk;
            BCategoriasAdmin.Image = Properties.Resources.icons8_categorizar_48;
            BCategoriasAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BCategoriasAdmin.Location = new Point(0, 303);
            BCategoriasAdmin.Name = "BCategoriasAdmin";
            BCategoriasAdmin.Size = new Size(213, 59);
            BCategoriasAdmin.TabIndex = 12;
            BCategoriasAdmin.Text = "Categorias";
            BCategoriasAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BCategoriasAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCategoriasAdmin.UseVisualStyleBackColor = false;
            // 
            // BVentasAdmin
            // 
            BVentasAdmin.BackColor = Color.RosyBrown;
            BVentasAdmin.Dock = DockStyle.Top;
            BVentasAdmin.FlatAppearance.BorderSize = 0;
            BVentasAdmin.FlatStyle = FlatStyle.Flat;
            BVentasAdmin.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVentasAdmin.ForeColor = Color.Cornsilk;
            BVentasAdmin.Image = Properties.Resources.icons8_ventas_totales_48;
            BVentasAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BVentasAdmin.Location = new Point(0, 159);
            BVentasAdmin.Name = "BVentasAdmin";
            BVentasAdmin.Size = new Size(213, 59);
            BVentasAdmin.TabIndex = 10;
            BVentasAdmin.Text = "Ventas";
            BVentasAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BVentasAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BVentasAdmin.UseVisualStyleBackColor = false;
            // 
            // BProductosAdmin
            // 
            BProductosAdmin.BackColor = Color.RosyBrown;
            BProductosAdmin.Dock = DockStyle.Top;
            BProductosAdmin.FlatAppearance.BorderSize = 0;
            BProductosAdmin.FlatStyle = FlatStyle.Flat;
            BProductosAdmin.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BProductosAdmin.ForeColor = Color.Cornsilk;
            BProductosAdmin.Image = Properties.Resources.icons8_camiseta_48;
            BProductosAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            BProductosAdmin.Location = new Point(0, 0);
            BProductosAdmin.Name = "BProductosAdmin";
            BProductosAdmin.Size = new Size(213, 59);
            BProductosAdmin.TabIndex = 0;
            BProductosAdmin.Text = "Productos";
            BProductosAdmin.TextAlign = ContentAlignment.MiddleLeft;
            BProductosAdmin.TextImageRelation = TextImageRelation.ImageBeforeText;
            BProductosAdmin.UseVisualStyleBackColor = false;
            // 
            // BMaximizarMenuAdmin
            // 
            BMaximizarMenuAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenuAdmin.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenuAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenuAdmin.FlatAppearance.BorderSize = 0;
            BMaximizarMenuAdmin.FlatStyle = FlatStyle.Flat;
            BMaximizarMenuAdmin.Location = new Point(948, 17);
            BMaximizarMenuAdmin.Name = "BMaximizarMenuAdmin";
            BMaximizarMenuAdmin.Size = new Size(30, 30);
            BMaximizarMenuAdmin.TabIndex = 3;
            BMaximizarMenuAdmin.UseVisualStyleBackColor = true;
            // 
            // BCerrarMenuAdmin
            // 
            BCerrarMenuAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenuAdmin.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenuAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenuAdmin.FlatAppearance.BorderSize = 0;
            BCerrarMenuAdmin.FlatStyle = FlatStyle.Flat;
            BCerrarMenuAdmin.Location = new Point(990, 17);
            BCerrarMenuAdmin.Name = "BCerrarMenuAdmin";
            BCerrarMenuAdmin.Size = new Size(30, 30);
            BCerrarMenuAdmin.TabIndex = 2;
            BCerrarMenuAdmin.UseVisualStyleBackColor = true;
            // 
            // BRestaurarMenuAdmin
            // 
            BRestaurarMenuAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenuAdmin.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenuAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenuAdmin.FlatAppearance.BorderSize = 0;
            BRestaurarMenuAdmin.FlatStyle = FlatStyle.Flat;
            BRestaurarMenuAdmin.Location = new Point(950, 17);
            BRestaurarMenuAdmin.Name = "BRestaurarMenuAdmin";
            BRestaurarMenuAdmin.Size = new Size(30, 30);
            BRestaurarMenuAdmin.TabIndex = 1;
            BRestaurarMenuAdmin.UseVisualStyleBackColor = true;
            // 
            // BMinimizarMenuAdmin
            // 
            BMinimizarMenuAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenuAdmin.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenuAdmin.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenuAdmin.FlatAppearance.BorderSize = 0;
            BMinimizarMenuAdmin.FlatStyle = FlatStyle.Flat;
            BMinimizarMenuAdmin.Location = new Point(910, 17);
            BMinimizarMenuAdmin.Name = "BMinimizarMenuAdmin";
            BMinimizarMenuAdmin.Size = new Size(30, 30);
            BMinimizarMenuAdmin.TabIndex = 0;
            BMinimizarMenuAdmin.UseVisualStyleBackColor = true;
            // 
            // MenuA
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 650);
            Controls.Add(PanelFormAdmin);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuA";
            Text = "Form1";
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuClientes.ResumeLayout(false);
            PanelSubMenuTalles.ResumeLayout(false);
            PanelSubMenuCategorias.ResumeLayout(false);
            PanelSubMenuVentas.ResumeLayout(false);
            PanelSubMenuProductos.ResumeLayout(false);
            PanelBarraMenu.ResumeLayout(false);
            PanelFormAdmin.ResumeLayout(false);
            PanelFormAdmin.PerformLayout();
            Load += new EventHandler(G_Load);
            ResumeLayout(false);

        }

        internal Panel PanelFormAdmin;
        internal Label Label1;
        internal Button BSalir;
        internal Panel PanelMenuLateral;
        internal Panel PanelSubMenuCategorias;
        internal Button BGestionarCategorias;
        internal Button BAñadirCategoria;
        internal Button BCategoriasAdmin;
        internal Panel PanelSubMenuVentas;
        internal Button BListarVendedoresAdmin;
        internal Button BListarVentasAdmin;
        internal Button BVentasAdmin;
        internal Panel PanelSubMenuProductos;
        internal Button BGestionarProductosAdmin;
        internal Button BAñadirProductoAdmin;
        internal Button BProductosAdmin;
        internal Panel PanelBarraMenu;
        internal Button BMaximizarMenuAdmin;
        internal Button BCerrarMenuAdmin;
        internal Button BRestaurarMenuAdmin;
        internal Button BMinimizarMenuAdmin;
        internal Panel PanelSubMenuTalles;
        internal Button BGestionarTalles;
        internal Button BAñadirTalle;
        internal Button BTalles;
        internal Panel PanelSubMenuClientes;
        internal Button BGestionarClientes;
        internal Button BClientes;

        #endregion
    }
}