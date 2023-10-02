namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class ModificarPerfiles
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
            PanelModMarca = new Panel();
            BCancelarModifCliente = new Button();
            GroupBoxDatosPerfil = new GroupBox();
            TBModPerfil = new TextBox();
            LModPerfil = new Label();
            BModificarPerfil = new Button();
            PanelModMarca.SuspendLayout();
            GroupBoxDatosPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // PanelModMarca
            // 
            PanelModMarca.BackColor = Color.RosyBrown;
            PanelModMarca.BackgroundImageLayout = ImageLayout.None;
            PanelModMarca.Controls.Add(BCancelarModifCliente);
            PanelModMarca.Controls.Add(GroupBoxDatosPerfil);
            PanelModMarca.Controls.Add(BModificarPerfil);
            PanelModMarca.Location = new Point(92, 90);
            PanelModMarca.Margin = new Padding(5, 6, 5, 6);
            PanelModMarca.Name = "PanelModMarca";
            PanelModMarca.Size = new Size(612, 465);
            PanelModMarca.TabIndex = 7;
            // 
            // BCancelarModifCliente
            // 
            BCancelarModifCliente.BackColor = Color.Sienna;
            BCancelarModifCliente.FlatAppearance.BorderSize = 2;
            BCancelarModifCliente.FlatStyle = FlatStyle.Flat;
            BCancelarModifCliente.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelarModifCliente.ForeColor = Color.White;
            BCancelarModifCliente.Location = new Point(244, 369);
            BCancelarModifCliente.Margin = new Padding(5, 6, 5, 6);
            BCancelarModifCliente.Name = "BCancelarModifCliente";
            BCancelarModifCliente.Size = new Size(131, 65);
            BCancelarModifCliente.TabIndex = 12;
            BCancelarModifCliente.Text = "Volver";
            BCancelarModifCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifCliente.UseVisualStyleBackColor = false;
            BCancelarModifCliente.Click += BCancelarModifCliente_Click;
            // 
            // GroupBoxDatosPerfil
            // 
            GroupBoxDatosPerfil.Controls.Add(TBModPerfil);
            GroupBoxDatosPerfil.Controls.Add(LModPerfil);
            GroupBoxDatosPerfil.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosPerfil.ForeColor = Color.White;
            GroupBoxDatosPerfil.Location = new Point(51, 28);
            GroupBoxDatosPerfil.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil";
            GroupBoxDatosPerfil.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosPerfil.Size = new Size(473, 308);
            GroupBoxDatosPerfil.TabIndex = 19;
            GroupBoxDatosPerfil.TabStop = false;
            GroupBoxDatosPerfil.Text = "Modificar Perfil";
            // 
            // TBModPerfil
            // 
            TBModPerfil.Location = new Point(127, 151);
            TBModPerfil.Margin = new Padding(4, 5, 4, 5);
            TBModPerfil.Name = "TBModPerfil";
            TBModPerfil.Size = new Size(221, 42);
            TBModPerfil.TabIndex = 16;
            TBModPerfil.KeyPress += String_KeyPress;
            // 
            // LModPerfil
            // 
            LModPerfil.AutoSize = true;
            LModPerfil.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModPerfil.ForeColor = Color.White;
            LModPerfil.Location = new Point(123, 106);
            LModPerfil.Margin = new Padding(8, 0, 8, 0);
            LModPerfil.Name = "LModPerfil";
            LModPerfil.Size = new Size(84, 27);
            LModPerfil.TabIndex = 15;
            LModPerfil.Text = "Perfil: ";
            // 
            // BModificarPerfil
            // 
            BModificarPerfil.BackColor = Color.DarkOliveGreen;
            BModificarPerfil.FlatAppearance.BorderColor = Color.White;
            BModificarPerfil.FlatAppearance.BorderSize = 2;
            BModificarPerfil.FlatStyle = FlatStyle.Flat;
            BModificarPerfil.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarPerfil.ForeColor = Color.White;
            BModificarPerfil.Location = new Point(393, 369);
            BModificarPerfil.Margin = new Padding(5, 6, 5, 6);
            BModificarPerfil.Name = "BModificarPerfil";
            BModificarPerfil.Size = new Size(131, 65);
            BModificarPerfil.TabIndex = 13;
            BModificarPerfil.Text = "Modificar";
            BModificarPerfil.UseVisualStyleBackColor = false;
            // 
            // ModificarPerfiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(839, 647);
            Controls.Add(PanelModMarca);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarPerfiles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelModMarca.ResumeLayout(false);
            GroupBoxDatosPerfil.ResumeLayout(false);
            GroupBoxDatosPerfil.PerformLayout();
            ResumeLayout(false);
        }

        internal Panel PanelModMarca;
        internal Button BCancelarModifCliente;
        internal GroupBox GroupBoxDatosPerfil;
        internal TextBox TBModPerfil;
        internal Label LModPerfil;
        internal Button BModificarPerfil;

        #endregion
    }
}