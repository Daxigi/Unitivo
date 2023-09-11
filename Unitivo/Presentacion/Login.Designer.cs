namespace Unitivo.Presentacion
{
    partial class Login
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
            PanelBarraMenuLogin = new Panel();
            PanelBarraMenuLogin.MouseDown += new MouseEventHandler(PanelBarraMenuLogin_MouseDown);
            PanelBarraMenuLogin.MouseUp += new MouseEventHandler(PanelBarraMenuLogin_MouseUp);
            PanelBarraMenuLogin.MouseMove += new MouseEventHandler(PanelBarraMenuLogin_MouseMove);
            Panel2 = new Panel();
            TBContraseña = new TextBox();
            TBUsuario = new TextBox();
            TBUsuario.KeyPress += new KeyPressEventHandler(TBUsuario_Keypress);
            TBUsuario.TextChanged += new EventHandler(TBUsuario_TextChanged);
            BLogin = new Button();
            BLogin.Click += new EventHandler(BLogin_Click);
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            PictureBoxContraseña = new PictureBox();
            PictureBoxContraseña.Click += new EventHandler(PictureBoxContraseña_Click);
            BMaximizarMenu = new Button();
            BMaximizarMenu.Click += new EventHandler(BMaximizarMenu_Click);
            BCerrarMenu = new Button();
            BCerrarMenu.Click += new EventHandler(BCerrarMenu_Click);
            BRestaurarMenu = new Button();
            BRestaurarMenu.Click += new EventHandler(BRestaurarMenu_Click);
            BMinimizarMenu = new Button();
            BMinimizarMenu.Click += new EventHandler(BMinimizarMenu_Click);
            Panel1 = new Panel();
            PanelBarraMenuLogin.SuspendLayout();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxContraseña).BeginInit();
            SuspendLayout();
            // 
            // PanelBarraMenuLogin
            // 
            PanelBarraMenuLogin.BackColor = Color.DarkSeaGreen;
            PanelBarraMenuLogin.Controls.Add(BMaximizarMenu);
            PanelBarraMenuLogin.Controls.Add(BCerrarMenu);
            PanelBarraMenuLogin.Controls.Add(BRestaurarMenu);
            PanelBarraMenuLogin.Controls.Add(BMinimizarMenu);
            PanelBarraMenuLogin.Dock = DockStyle.Top;
            PanelBarraMenuLogin.Location = new Point(0, 0);
            PanelBarraMenuLogin.Name = "PanelBarraMenuLogin";
            PanelBarraMenuLogin.Size = new Size(760, 50);
            PanelBarraMenuLogin.TabIndex = 0;
            // 
            // Panel2
            // 
            Panel2.Anchor = AnchorStyles.None;
            Panel2.BackColor = Color.Cornsilk;
            Panel2.Controls.Add(PictureBoxContraseña);
            Panel2.Controls.Add(TBContraseña);
            Panel2.Controls.Add(TBUsuario);
            Panel2.Controls.Add(BLogin);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label1);
            Panel2.Location = new Point(241, 85);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(280, 340);
            Panel2.TabIndex = 1;
            // 
            // TBContraseña
            // 
            TBContraseña.Location = new Point(66, 221);
            TBContraseña.Name = "TBContraseña";
            TBContraseña.Size = new Size(150, 20);
            TBContraseña.TabIndex = 5;
            // 
            // TBUsuario
            // 
            TBUsuario.Location = new Point(66, 146);
            TBUsuario.Name = "TBUsuario";
            TBUsuario.Size = new Size(150, 20);
            TBUsuario.TabIndex = 4;
            // 
            // BLogin
            // 
            BLogin.FlatAppearance.BorderSize = 2;
            BLogin.FlatStyle = FlatStyle.Flat;
            BLogin.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BLogin.ForeColor = Color.HotPink;
            BLogin.Location = new Point(71, 269);
            BLogin.Name = "BLogin";
            BLogin.Size = new Size(141, 39);
            BLogin.TabIndex = 3;
            BLogin.Text = "Ingresar";
            BLogin.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.DarkOliveGreen;
            Label3.Location = new Point(67, 178);
            Label3.Name = "Label3";
            Label3.Size = new Size(151, 27);
            Label3.TabIndex = 2;
            Label3.Text = "Contraseña";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(86, 104);
            Label2.Name = "Label2";
            Label2.Size = new Size(109, 27);
            Label2.TabIndex = 1;
            Label2.Text = "Usuario";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Cooper Black", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.DarkOrange;
            Label1.Location = new Point(13, 26);
            Label1.Name = "Label1";
            Label1.Size = new Size(259, 40);
            Label1.TabIndex = 0;
            Label1.Text = "Iniciar Sesión";
            // 
            // PictureBoxContraseña
            // 
            PictureBoxContraseña.BackColor = Color.White;
            PictureBoxContraseña.BackgroundImage = Properties.Resources.ojo_cerrado;
            PictureBoxContraseña.BackgroundImageLayout = ImageLayout.Stretch;
            PictureBoxContraseña.Location = new Point(189, 223);
            PictureBoxContraseña.Name = "PictureBoxContraseña";
            PictureBoxContraseña.Size = new Size(25, 16);
            PictureBoxContraseña.TabIndex = 6;
            PictureBoxContraseña.TabStop = false;
            // 
            // BMaximizarMenu
            // 
            BMaximizarMenu.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenu.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenu.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenu.FlatAppearance.BorderSize = 0;
            BMaximizarMenu.FlatStyle = FlatStyle.Flat;
            BMaximizarMenu.Location = new Point(670, 12);
            BMaximizarMenu.Name = "BMaximizarMenu";
            BMaximizarMenu.Size = new Size(25, 25);
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
            BCerrarMenu.Location = new Point(710, 12);
            BCerrarMenu.Name = "BCerrarMenu";
            BCerrarMenu.Size = new Size(25, 25);
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
            BRestaurarMenu.Location = new Point(670, 12);
            BRestaurarMenu.Name = "BRestaurarMenu";
            BRestaurarMenu.Size = new Size(25, 25);
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
            BMinimizarMenu.Location = new Point(629, 12);
            BMinimizarMenu.Name = "BMinimizarMenu";
            BMinimizarMenu.Size = new Size(25, 25);
            BMinimizarMenu.TabIndex = 0;
            BMinimizarMenu.UseVisualStyleBackColor = true;
            // 
            // Panel1
            // 
            Panel1.Anchor = AnchorStyles.None;
            Panel1.BackgroundImage = Properties.Resources.imggrande4;
            Panel1.Location = new Point(0, 50);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(760, 410);
            Panel1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 460);
            Controls.Add(Panel2);
            Controls.Add(PanelBarraMenuLogin);
            Controls.Add(Panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            PanelBarraMenuLogin.ResumeLayout(false);
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxContraseña).EndInit();
            Load += new EventHandler(Login_Load);
            ResumeLayout(false);

        }

        internal Panel PanelBarraMenuLogin;
        internal Panel Panel2;
        internal PictureBox PictureBoxContraseña;
        internal TextBox TBContraseña;
        internal TextBox TBUsuario;
        internal Button BLogin;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal Button BMinimizarMenu;
        internal Button BRestaurarMenu;
        internal Button BCerrarMenu;
        internal Button BMaximizarMenu;
        internal Panel Panel1;

        #endregion
    }
}