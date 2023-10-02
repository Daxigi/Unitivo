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
            GroupBoxDatosCliente = new GroupBox();
            ComboBoxPerfil = new ComboBox();
            LDni = new Label();
            TBContraseñaUsuario = new TextBox();
            TBNombreUsuario = new TextBox();
            LNombreCliente = new Label();
            LApellidoCliente = new Label();
            BModificarCliente = new Button();
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
            PanelModUsuarios.Location = new Point(91, 50);
            PanelModUsuarios.Margin = new Padding(5, 6, 5, 6);
            PanelModUsuarios.Name = "PanelModUsuarios";
            PanelModUsuarios.Size = new Size(605, 602);
            PanelModUsuarios.TabIndex = 2;
            // 
            // BCancelarModifCliente
            // 
            BCancelarModifCliente.BackColor = Color.Sienna;
            BCancelarModifCliente.FlatAppearance.BorderSize = 2;
            BCancelarModifCliente.FlatStyle = FlatStyle.Flat;
            BCancelarModifCliente.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelarModifCliente.ForeColor = Color.White;
            BCancelarModifCliente.Location = new Point(152, 497);
            BCancelarModifCliente.Margin = new Padding(5, 6, 5, 6);
            BCancelarModifCliente.Name = "BCancelarModifCliente";
            BCancelarModifCliente.Size = new Size(140, 63);
            BCancelarModifCliente.TabIndex = 12;
            BCancelarModifCliente.Text = "Volver";
            BCancelarModifCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifCliente.UseVisualStyleBackColor = false;
            BCancelarModifCliente.Click += BCancelarModif_Click;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.Controls.Add(ComboBoxPerfil);
            GroupBoxDatosCliente.Controls.Add(LDni);
            GroupBoxDatosCliente.Controls.Add(TBContraseñaUsuario);
            GroupBoxDatosCliente.Controls.Add(TBNombreUsuario);
            GroupBoxDatosCliente.Controls.Add(LNombreCliente);
            GroupBoxDatosCliente.Controls.Add(LApellidoCliente);
            GroupBoxDatosCliente.Font = new Font("Britannic Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(85, 60);
            GroupBoxDatosCliente.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Size = new Size(443, 408);
            GroupBoxDatosCliente.TabIndex = 19;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Datos";
            // 
            // ComboBoxPerfil
            // 
            ComboBoxPerfil.FormattingEnabled = true;
            ComboBoxPerfil.Items.AddRange(new object[] { "Vendedor", "Gerente" });
            ComboBoxPerfil.Location = new Point(131, 314);
            ComboBoxPerfil.Name = "ComboBoxPerfil";
            ComboBoxPerfil.Size = new Size(213, 45);
            ComboBoxPerfil.TabIndex = 20;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LDni.ForeColor = Color.White;
            LDni.Location = new Point(127, 283);
            LDni.Margin = new Padding(5, 0, 5, 0);
            LDni.Name = "LDni";
            LDni.Size = new Size(58, 22);
            LDni.TabIndex = 19;
            LDni.Text = "Perfil";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Location = new Point(131, 209);
            TBContraseñaUsuario.Margin = new Padding(5, 6, 5, 6);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(213, 45);
            TBContraseñaUsuario.TabIndex = 8;
            TBContraseñaUsuario.KeyPress += Contraseña_KeyPress;
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Location = new Point(131, 105);
            TBNombreUsuario.Margin = new Padding(5, 6, 5, 6);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(213, 45);
            TBNombreUsuario.TabIndex = 6;
            TBNombreUsuario.KeyPress += String_KeyPress;
            // 
            // LNombreCliente
            // 
            LNombreCliente.AutoSize = true;
            LNombreCliente.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCliente.ForeColor = Color.White;
            LNombreCliente.Location = new Point(127, 71);
            LNombreCliente.Margin = new Padding(5, 0, 5, 0);
            LNombreCliente.Name = "LNombreCliente";
            LNombreCliente.Size = new Size(85, 22);
            LNombreCliente.TabIndex = 0;
            LNombreCliente.Text = "Nombre:";
            // 
            // LApellidoCliente
            // 
            LApellidoCliente.AutoSize = true;
            LApellidoCliente.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LApellidoCliente.ForeColor = Color.White;
            LApellidoCliente.Location = new Point(127, 177);
            LApellidoCliente.Margin = new Padding(5, 0, 5, 0);
            LApellidoCliente.Name = "LApellidoCliente";
            LApellidoCliente.Size = new Size(118, 22);
            LApellidoCliente.TabIndex = 4;
            LApellidoCliente.Text = "Contraseña:";
            // 
            // BModificarCliente
            // 
            BModificarCliente.BackColor = Color.DarkOliveGreen;
            BModificarCliente.FlatAppearance.BorderColor = Color.White;
            BModificarCliente.FlatAppearance.BorderSize = 2;
            BModificarCliente.FlatStyle = FlatStyle.Flat;
            BModificarCliente.Font = new Font("Britannic Bold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarCliente.ForeColor = Color.White;
            BModificarCliente.Location = new Point(341, 497);
            BModificarCliente.Margin = new Padding(5, 6, 5, 6);
            BModificarCliente.Name = "BModificarCliente";
            BModificarCliente.Size = new Size(143, 63);
            BModificarCliente.TabIndex = 13;
            BModificarCliente.Text = "Modificar";
            BModificarCliente.UseVisualStyleBackColor = false;
            // 
            // ModificarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(806, 704);
            Controls.Add(PanelModUsuarios);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
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