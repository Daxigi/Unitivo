namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class ModificarUsuario
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
            PanelModUsuarios = new Panel();
            BCancelarModifCliente = new Button();
            //BCancelarModifCliente.Click += new EventHandler(BCancelarModifCliente_Click);
            GroupBoxDatosCliente = new GroupBox();
            ComboBoxPerfil = new ComboBox();
            LDni = new Label();
            TBContraseñaUsuario = new TextBox();
            TBNombreUsuario = new TextBox();
            //TBNombreUsuario.KeyPress += new KeyPressEventHandler(TBNombreUsuario_KeyPress);
            LNombreCliente = new Label();
            LApellidoCliente = new Label();
            BModificarCliente = new Button();
            //BModificarCliente.Click += new EventHandler(BModificarCliente_Click);
            PanelModUsuarios.SuspendLayout();
            GroupBoxDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // PanelModUsuarios
            // 
            PanelModUsuarios.BackColor = Color.RosyBrown;
            PanelModUsuarios.BackgroundImageLayout = ImageLayout.None;
            PanelModUsuarios.Controls.Add(BCancelarModifCliente);
            PanelModUsuarios.Controls.Add(GroupBoxDatosCliente);
            PanelModUsuarios.Controls.Add(BModificarCliente);
            PanelModUsuarios.Location = new Point(173, 30);
            PanelModUsuarios.Margin = new Padding(4);
            PanelModUsuarios.Name = "PanelModUsuarios";
            PanelModUsuarios.Size = new Size(454, 391);
            PanelModUsuarios.TabIndex = 2;
            // 
            // BCancelarModifCliente
            // 
            BCancelarModifCliente.BackColor = Color.Sienna;
            BCancelarModifCliente.FlatAppearance.BorderSize = 2;
            BCancelarModifCliente.FlatStyle = FlatStyle.Flat;
            BCancelarModifCliente.Font = new Font("Britannic Bold", 15.0f);
            BCancelarModifCliente.ForeColor = Color.White;
            BCancelarModifCliente.Location = new Point(114, 323);
            BCancelarModifCliente.Margin = new Padding(4);
            BCancelarModifCliente.Name = "BCancelarModifCliente";
            BCancelarModifCliente.Size = new Size(105, 41);
            BCancelarModifCliente.TabIndex = 12;
            BCancelarModifCliente.Text = "Volver";
            BCancelarModifCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifCliente.UseVisualStyleBackColor = false;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.Controls.Add(ComboBoxPerfil);
            GroupBoxDatosCliente.Controls.Add(LDni);
            GroupBoxDatosCliente.Controls.Add(TBContraseñaUsuario);
            GroupBoxDatosCliente.Controls.Add(TBNombreUsuario);
            GroupBoxDatosCliente.Controls.Add(LNombreCliente);
            GroupBoxDatosCliente.Controls.Add(LApellidoCliente);
            GroupBoxDatosCliente.Font = new Font("Britannic Bold", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(64, 39);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Size = new Size(332, 265);
            GroupBoxDatosCliente.TabIndex = 19;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Datos";
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Items.AddRange(new object[] { "Vendedor", "Gerente" });
            ComboBoxPerfil.Location = new Point(98, 204);
            ComboBoxPerfil.Margin = new Padding(2);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(161, 38);
            ComboBoxPerfil.TabIndex = 20;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Britannic Bold", 12.0f);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(95, 184);
            LDni.Margin = new Padding(4, 0, 4, 0);
            LDni.Name = "LDni";
            LDni.Size = new Size(46, 17);
            LDni.TabIndex = 19;
            LDni.Text = "Perfil";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(98, 136);
            TBContraseñaUsuario.Margin = new Padding(4);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(161, 37);
            TBContraseñaUsuario.TabIndex = 8;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(98, 68);
            TBNombreUsuario.Margin = new Padding(4);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(161, 37);
            TBNombreUsuario.TabIndex = 6;
            // 
            // LNombreCliente
            // 
            LNombreCliente.AutoSize = true;
            LNombreCliente.Font = new Font("Britannic Bold", 12.0f);
            LNombreCliente.ForeColor = Color.White;
            LNombreCliente.Location = new Point(95, 46);
            LNombreCliente.Margin = new Padding(4, 0, 4, 0);
            LNombreCliente.Name = "LNombreCliente";
            LNombreCliente.Size = new Size(69, 17);
            LNombreCliente.TabIndex = 0;
            LNombreCliente.Text = "Nombre:";
            // 
            // LApellidoCliente
            // 
            LApellidoCliente.AutoSize = true;
            LApellidoCliente.Font = new Font("Britannic Bold", 12.0f);
            LApellidoCliente.ForeColor = Color.White;
            LApellidoCliente.Location = new Point(95, 115);
            LApellidoCliente.Margin = new Padding(4, 0, 4, 0);
            LApellidoCliente.Name = "LApellidoCliente";
            LApellidoCliente.Size = new Size(94, 17);
            LApellidoCliente.TabIndex = 4;
            LApellidoCliente.Text = "Contraseña:";
            // 
            // BModificarCliente
            // 
            BModificarCliente.BackColor = Color.DarkOliveGreen;
            BModificarCliente.FlatAppearance.BorderColor = Color.White;
            BModificarCliente.FlatAppearance.BorderSize = 2;
            BModificarCliente.FlatStyle = FlatStyle.Flat;
            BModificarCliente.Font = new Font("Britannic Bold", 15.0f);
            BModificarCliente.ForeColor = Color.White;
            BModificarCliente.Location = new Point(256, 323);
            BModificarCliente.Margin = new Padding(4);
            BModificarCliente.Name = "BModificarCliente";
            BModificarCliente.Size = new Size(107, 41);
            BModificarCliente.TabIndex = 13;
            BModificarCliente.Text = "Modificar";
            BModificarCliente.UseVisualStyleBackColor = false;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelModUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarUsuario";
            Text = "Form1";
            PanelModUsuarios.ResumeLayout(false);
            GroupBoxDatosCliente.ResumeLayout(false);
            GroupBoxDatosCliente.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel PanelModUsuarios;
        internal Button BCancelarModifCliente;
        internal GroupBox GroupBoxDatosCliente;
        internal ComboBox ComboBoxPerfil;
        internal Label LDni;
        internal TextBox TBContraseñaUsuario;
        internal TextBox TBNombreUsuario;
        internal Label LNombreCliente;
        internal Label LApellidoCliente;
        internal Button BModificarCliente;

        #endregion
    }
}