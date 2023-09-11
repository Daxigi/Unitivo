namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class MenuSA
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
            PanelSubMenuPerfiles = new Panel();
            BGestionarPerfiles = new Button();
            BGestionarPerfiles.Click += new EventHandler(BGestionarPerfiles_Click);
            BAñadirPerfil = new Button();
            BAñadirPerfil.Click += new EventHandler(BAñadirPerfil_Click);
            PanelSubMenuEmpleados = new Panel();
            BGestionarEmpleados = new Button();
            BGestionarEmpleados.Click += new EventHandler(BGestionarEmpleados_Click);
            BAñadirEmpleado = new Button();
            BAñadirEmpleado.Click += new EventHandler(BAñadirEmpleado_Click);
            PanelSubMenuUsuarios = new Panel();
            BGestionarUsuarios = new Button();
            BGestionarUsuarios.Click += new EventHandler(BGestionarUsuarios_Click);
            BAñadirUsuario = new Button();
            BAñadirUsuario.Click += new EventHandler(BAñadirUsuario_Click);
            PanelBarraMenu = new Panel();
            PanelBarraMenu.MouseDown += new MouseEventHandler(PanelBarraMenuAdmin_MouseDown);
            PanelBarraMenu.MouseUp += new MouseEventHandler(PanelBarraMenuAdmin_MouseUp);
            PanelBarraMenu.MouseMove += new MouseEventHandler(PanelBarraMenuAdmin_MouseMove);
            PanelFormSuperAdministrador = new Panel();
            Label1 = new Label();
            BPerfiles = new Button();
            BPerfiles.Click += new EventHandler(BPerfiles_Click);
            BEmpleados = new Button();
            BEmpleados.Click += new EventHandler(BEmpleados_Click);
            BUsuarios = new Button();
            BUsuarios.Click += new EventHandler(BUsuarios_Click);
            BMaximizarMenuGerente = new Button();
            BMaximizarMenuGerente.Click += new EventHandler(BMaximizarMenuGerente_Click);
            BCerrarMenuGerente = new Button();
            BCerrarMenuGerente.Click += new EventHandler(BCerrarMenuGerente_Click);
            BRestaurarMenuGerente = new Button();
            BRestaurarMenuGerente.Click += new EventHandler(BRestaurarMenuGerente_Click);
            BMinimizarMenuGerente = new Button();
            BMinimizarMenuGerente.Click += new EventHandler(BMinimizarMenuGerente_Click);
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuPerfiles.SuspendLayout();
            PanelSubMenuEmpleados.SuspendLayout();
            PanelSubMenuUsuarios.SuspendLayout();
            PanelBarraMenu.SuspendLayout();
            PanelFormSuperAdministrador.SuspendLayout();
            SuspendLayout();
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
            // PanelMenuLateral
            // 
            PanelMenuLateral.AutoScroll = true;
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(PanelSubMenuPerfiles);
            PanelMenuLateral.Controls.Add(BPerfiles);
            PanelMenuLateral.Controls.Add(PanelSubMenuEmpleados);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(BEmpleados);
            PanelMenuLateral.Controls.Add(PanelSubMenuUsuarios);
            PanelMenuLateral.Controls.Add(BUsuarios);
            PanelMenuLateral.Dock = DockStyle.Left;
            PanelMenuLateral.Location = new Point(0, 60);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(230, 590);
            PanelMenuLateral.TabIndex = 5;
            // 
            // PanelSubMenuPerfiles
            // 
            PanelSubMenuPerfiles.BackColor = Color.FloralWhite;
            PanelSubMenuPerfiles.Controls.Add(BGestionarPerfiles);
            PanelSubMenuPerfiles.Controls.Add(BAñadirPerfil);
            PanelSubMenuPerfiles.Dock = DockStyle.Top;
            PanelSubMenuPerfiles.Location = new Point(0, 326);
            PanelSubMenuPerfiles.Name = "PanelSubMenuPerfiles";
            PanelSubMenuPerfiles.Size = new Size(230, 91);
            PanelSubMenuPerfiles.TabIndex = 13;
            // 
            // BGestionarPerfiles
            // 
            BGestionarPerfiles.BackColor = Color.FloralWhite;
            BGestionarPerfiles.Dock = DockStyle.Top;
            BGestionarPerfiles.FlatAppearance.BorderSize = 0;
            BGestionarPerfiles.FlatStyle = FlatStyle.Flat;
            BGestionarPerfiles.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarPerfiles.ForeColor = Color.Sienna;
            BGestionarPerfiles.Location = new Point(0, 40);
            BGestionarPerfiles.Name = "BGestionarPerfiles";
            BGestionarPerfiles.Size = new Size(230, 40);
            BGestionarPerfiles.TabIndex = 2;
            BGestionarPerfiles.Text = "Gestionar Perfiles";
            BGestionarPerfiles.UseVisualStyleBackColor = false;
            // 
            // BAñadirPerfil
            // 
            BAñadirPerfil.BackColor = Color.FloralWhite;
            BAñadirPerfil.Dock = DockStyle.Top;
            BAñadirPerfil.FlatAppearance.BorderSize = 0;
            BAñadirPerfil.FlatStyle = FlatStyle.Flat;
            BAñadirPerfil.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirPerfil.ForeColor = Color.Sienna;
            BAñadirPerfil.Location = new Point(0, 0);
            BAñadirPerfil.Name = "BAñadirPerfil";
            BAñadirPerfil.Size = new Size(230, 40);
            BAñadirPerfil.TabIndex = 1;
            BAñadirPerfil.Text = "Añadir Perfil";
            BAñadirPerfil.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuEmpleados
            // 
            PanelSubMenuEmpleados.BackColor = Color.FloralWhite;
            PanelSubMenuEmpleados.Controls.Add(BGestionarEmpleados);
            PanelSubMenuEmpleados.Controls.Add(BAñadirEmpleado);
            PanelSubMenuEmpleados.Dock = DockStyle.Top;
            PanelSubMenuEmpleados.Location = new Point(0, 189);
            PanelSubMenuEmpleados.Name = "PanelSubMenuEmpleados";
            PanelSubMenuEmpleados.Size = new Size(230, 85);
            PanelSubMenuEmpleados.TabIndex = 11;
            // 
            // BGestionarEmpleados
            // 
            BGestionarEmpleados.BackColor = Color.FloralWhite;
            BGestionarEmpleados.Dock = DockStyle.Top;
            BGestionarEmpleados.FlatAppearance.BorderSize = 0;
            BGestionarEmpleados.FlatStyle = FlatStyle.Flat;
            BGestionarEmpleados.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarEmpleados.ForeColor = Color.Sienna;
            BGestionarEmpleados.Location = new Point(0, 40);
            BGestionarEmpleados.Name = "BGestionarEmpleados";
            BGestionarEmpleados.Size = new Size(230, 40);
            BGestionarEmpleados.TabIndex = 2;
            BGestionarEmpleados.Text = "Gestionar Empleados";
            BGestionarEmpleados.UseVisualStyleBackColor = false;
            // 
            // BAñadirEmpleado
            // 
            BAñadirEmpleado.BackColor = Color.FloralWhite;
            BAñadirEmpleado.Dock = DockStyle.Top;
            BAñadirEmpleado.FlatAppearance.BorderSize = 0;
            BAñadirEmpleado.FlatStyle = FlatStyle.Flat;
            BAñadirEmpleado.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirEmpleado.ForeColor = Color.Sienna;
            BAñadirEmpleado.Location = new Point(0, 0);
            BAñadirEmpleado.Name = "BAñadirEmpleado";
            BAñadirEmpleado.Size = new Size(230, 40);
            BAñadirEmpleado.TabIndex = 1;
            BAñadirEmpleado.Text = "Añadir Empleado";
            BAñadirEmpleado.UseVisualStyleBackColor = false;
            // 
            // PanelSubMenuUsuarios
            // 
            PanelSubMenuUsuarios.BackColor = Color.FloralWhite;
            PanelSubMenuUsuarios.Controls.Add(BGestionarUsuarios);
            PanelSubMenuUsuarios.Controls.Add(BAñadirUsuario);
            PanelSubMenuUsuarios.Dock = DockStyle.Top;
            PanelSubMenuUsuarios.Location = new Point(0, 52);
            PanelSubMenuUsuarios.Name = "PanelSubMenuUsuarios";
            PanelSubMenuUsuarios.Size = new Size(230, 85);
            PanelSubMenuUsuarios.TabIndex = 9;
            // 
            // BGestionarUsuarios
            // 
            BGestionarUsuarios.BackColor = Color.FloralWhite;
            BGestionarUsuarios.Dock = DockStyle.Top;
            BGestionarUsuarios.FlatAppearance.BorderSize = 0;
            BGestionarUsuarios.FlatStyle = FlatStyle.Flat;
            BGestionarUsuarios.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGestionarUsuarios.ForeColor = Color.Sienna;
            BGestionarUsuarios.Location = new Point(0, 40);
            BGestionarUsuarios.Name = "BGestionarUsuarios";
            BGestionarUsuarios.Size = new Size(230, 40);
            BGestionarUsuarios.TabIndex = 2;
            BGestionarUsuarios.Text = "Gestionar Usuarios";
            BGestionarUsuarios.UseVisualStyleBackColor = false;
            // 
            // BAñadirUsuario
            // 
            BAñadirUsuario.BackColor = Color.FloralWhite;
            BAñadirUsuario.Dock = DockStyle.Top;
            BAñadirUsuario.FlatAppearance.BorderSize = 0;
            BAñadirUsuario.FlatStyle = FlatStyle.Flat;
            BAñadirUsuario.Font = new Font("Cooper Black", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BAñadirUsuario.ForeColor = Color.Sienna;
            BAñadirUsuario.Location = new Point(0, 0);
            BAñadirUsuario.Name = "BAñadirUsuario";
            BAñadirUsuario.Size = new Size(230, 40);
            BAñadirUsuario.TabIndex = 1;
            BAñadirUsuario.Text = "Añadir Usuario";
            BAñadirUsuario.UseVisualStyleBackColor = false;
            // 
            // PanelBarraMenu
            // 
            PanelBarraMenu.BackColor = Color.Tan;
            PanelBarraMenu.Controls.Add(BMaximizarMenuGerente);
            PanelBarraMenu.Controls.Add(BCerrarMenuGerente);
            PanelBarraMenu.Controls.Add(BRestaurarMenuGerente);
            PanelBarraMenu.Controls.Add(BMinimizarMenuGerente);
            PanelBarraMenu.Dock = DockStyle.Top;
            PanelBarraMenu.Location = new Point(0, 0);
            PanelBarraMenu.Name = "PanelBarraMenu";
            PanelBarraMenu.Size = new Size(1040, 60);
            PanelBarraMenu.TabIndex = 4;
            // 
            // PanelFormSuperAdministrador
            // 
            PanelFormSuperAdministrador.Anchor = AnchorStyles.None;
            PanelFormSuperAdministrador.BackgroundImage = Properties.Resources.duenos1;
            PanelFormSuperAdministrador.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormSuperAdministrador.Controls.Add(Label1);
            PanelFormSuperAdministrador.Location = new Point(230, 60);
            PanelFormSuperAdministrador.Name = "PanelFormSuperAdministrador";
            PanelFormSuperAdministrador.Size = new Size(810, 590);
            PanelFormSuperAdministrador.TabIndex = 6;
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
            // BPerfiles
            // 
            BPerfiles.BackColor = Color.RosyBrown;
            BPerfiles.Dock = DockStyle.Top;
            BPerfiles.FlatAppearance.BorderSize = 0;
            BPerfiles.FlatStyle = FlatStyle.Flat;
            BPerfiles.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BPerfiles.ForeColor = Color.Cornsilk;
            BPerfiles.Image = Properties.Resources.icons8_contactos_60;
            BPerfiles.ImageAlign = ContentAlignment.MiddleLeft;
            BPerfiles.Location = new Point(0, 274);
            BPerfiles.Name = "BPerfiles";
            BPerfiles.Size = new Size(230, 52);
            BPerfiles.TabIndex = 12;
            BPerfiles.Text = "Perfiles";
            BPerfiles.TextAlign = ContentAlignment.MiddleLeft;
            BPerfiles.TextImageRelation = TextImageRelation.ImageBeforeText;
            BPerfiles.UseVisualStyleBackColor = false;
            // 
            // BEmpleados
            // 
            BEmpleados.BackColor = Color.RosyBrown;
            BEmpleados.Dock = DockStyle.Top;
            BEmpleados.FlatAppearance.BorderSize = 0;
            BEmpleados.FlatStyle = FlatStyle.Flat;
            BEmpleados.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEmpleados.ForeColor = Color.Cornsilk;
            BEmpleados.Image = Properties.Resources.icons8_contactos_50__2_;
            BEmpleados.ImageAlign = ContentAlignment.MiddleLeft;
            BEmpleados.Location = new Point(0, 137);
            BEmpleados.Name = "BEmpleados";
            BEmpleados.Size = new Size(230, 52);
            BEmpleados.TabIndex = 10;
            BEmpleados.Text = "Empleados";
            BEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            BEmpleados.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEmpleados.UseVisualStyleBackColor = false;
            // 
            // BUsuarios
            // 
            BUsuarios.BackColor = Color.RosyBrown;
            BUsuarios.Dock = DockStyle.Top;
            BUsuarios.FlatAppearance.BorderSize = 0;
            BUsuarios.FlatStyle = FlatStyle.Flat;
            BUsuarios.Font = new Font("Cooper Black", 16.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BUsuarios.ForeColor = Color.Cornsilk;
            BUsuarios.Image = Properties.Resources.icons8_contactos_50__1_;
            BUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            BUsuarios.Location = new Point(0, 0);
            BUsuarios.Name = "BUsuarios";
            BUsuarios.Size = new Size(230, 52);
            BUsuarios.TabIndex = 0;
            BUsuarios.Text = "Usuarios";
            BUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            BUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BUsuarios.UseVisualStyleBackColor = false;
            // 
            // BMaximizarMenuGerente
            // 
            BMaximizarMenuGerente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenuGerente.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenuGerente.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenuGerente.FlatAppearance.BorderSize = 0;
            BMaximizarMenuGerente.FlatStyle = FlatStyle.Flat;
            BMaximizarMenuGerente.Location = new Point(948, 17);
            BMaximizarMenuGerente.Name = "BMaximizarMenuGerente";
            BMaximizarMenuGerente.Size = new Size(30, 30);
            BMaximizarMenuGerente.TabIndex = 3;
            BMaximizarMenuGerente.UseVisualStyleBackColor = true;
            // 
            // BCerrarMenuGerente
            // 
            BCerrarMenuGerente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenuGerente.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenuGerente.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenuGerente.FlatAppearance.BorderSize = 0;
            BCerrarMenuGerente.FlatStyle = FlatStyle.Flat;
            BCerrarMenuGerente.Location = new Point(990, 17);
            BCerrarMenuGerente.Name = "BCerrarMenuGerente";
            BCerrarMenuGerente.Size = new Size(30, 30);
            BCerrarMenuGerente.TabIndex = 2;
            BCerrarMenuGerente.UseVisualStyleBackColor = true;
            // 
            // BRestaurarMenuGerente
            // 
            BRestaurarMenuGerente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenuGerente.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenuGerente.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenuGerente.FlatAppearance.BorderSize = 0;
            BRestaurarMenuGerente.FlatStyle = FlatStyle.Flat;
            BRestaurarMenuGerente.Location = new Point(950, 17);
            BRestaurarMenuGerente.Name = "BRestaurarMenuGerente";
            BRestaurarMenuGerente.Size = new Size(30, 30);
            BRestaurarMenuGerente.TabIndex = 1;
            BRestaurarMenuGerente.UseVisualStyleBackColor = true;
            // 
            // BMinimizarMenuGerente
            // 
            BMinimizarMenuGerente.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenuGerente.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenuGerente.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenuGerente.FlatAppearance.BorderSize = 0;
            BMinimizarMenuGerente.FlatStyle = FlatStyle.Flat;
            BMinimizarMenuGerente.Location = new Point(910, 17);
            BMinimizarMenuGerente.Name = "BMinimizarMenuGerente";
            BMinimizarMenuGerente.Size = new Size(30, 30);
            BMinimizarMenuGerente.TabIndex = 0;
            BMinimizarMenuGerente.UseVisualStyleBackColor = true;
            // 
            // MenuSA
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 650);
            Controls.Add(PanelFormSuperAdministrador);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuSA";
            Text = "Form1";
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuPerfiles.ResumeLayout(false);
            PanelSubMenuEmpleados.ResumeLayout(false);
            PanelSubMenuUsuarios.ResumeLayout(false);
            PanelBarraMenu.ResumeLayout(false);
            PanelFormSuperAdministrador.ResumeLayout(false);
            PanelFormSuperAdministrador.PerformLayout();
            Load += new EventHandler(MenuA_Load);
            ResumeLayout(false);

        }

        internal Button BSalir;
        internal Panel PanelFormSuperAdministrador;
        internal Label Label1;
        internal Panel PanelMenuLateral;
        internal Panel PanelSubMenuPerfiles;
        internal Button BAñadirPerfil;
        internal Button BPerfiles;
        internal Panel PanelSubMenuEmpleados;
        internal Button BGestionarEmpleados;
        internal Button BAñadirEmpleado;
        internal Button BEmpleados;
        internal Panel PanelSubMenuUsuarios;
        internal Button BGestionarUsuarios;
        internal Button BAñadirUsuario;
        internal Button BUsuarios;
        internal Panel PanelBarraMenu;
        internal Button BMaximizarMenuGerente;
        internal Button BCerrarMenuGerente;
        internal Button BRestaurarMenuGerente;
        internal Button BMinimizarMenuGerente;
        internal Button BGestionarPerfiles;

        #endregion
    }
}