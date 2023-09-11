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
            //BCancelarModifCliente.Click += new EventHandler(BCancelarModifCliente_Click);
            GroupBoxDatosPerfil = new GroupBox();
            TBModPerfil = new TextBox();
            //TBModPerfil.KeyPress += new KeyPressEventHandler(TBModPerfil_KeyPress);
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
            PanelModMarca.Location = new Point(171, 74);
            PanelModMarca.Margin = new Padding(4);
            PanelModMarca.Name = "PanelModMarca";
            PanelModMarca.Size = new Size(459, 302);
            PanelModMarca.TabIndex = 7;
            // 
            // BCancelarModifCliente
            // 
            BCancelarModifCliente.BackColor = Color.Sienna;
            BCancelarModifCliente.FlatAppearance.BorderSize = 2;
            BCancelarModifCliente.FlatStyle = FlatStyle.Flat;
            BCancelarModifCliente.Font = new Font("Britannic Bold", 13.0f);
            BCancelarModifCliente.ForeColor = Color.White;
            BCancelarModifCliente.Location = new Point(183, 240);
            BCancelarModifCliente.Margin = new Padding(4);
            BCancelarModifCliente.Name = "BCancelarModifCliente";
            BCancelarModifCliente.Size = new Size(98, 42);
            BCancelarModifCliente.TabIndex = 12;
            BCancelarModifCliente.Text = "Volver";
            BCancelarModifCliente.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifCliente.UseVisualStyleBackColor = false;
            // 
            // GroupBoxDatosPerfil
            // 
            GroupBoxDatosPerfil.Controls.Add(TBModPerfil);
            GroupBoxDatosPerfil.Controls.Add(LModPerfil);
            GroupBoxDatosPerfil.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDatosPerfil.ForeColor = Color.White;
            GroupBoxDatosPerfil.Location = new Point(38, 18);
            GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil";
            GroupBoxDatosPerfil.Size = new Size(355, 200);
            GroupBoxDatosPerfil.TabIndex = 19;
            GroupBoxDatosPerfil.TabStop = false;
            GroupBoxDatosPerfil.Text = "Modificar Perfil";
            // 
            // TBModPerfil
            // 
            TBModPerfil.Location = new Point(95, 98);
            TBModPerfil.Name = "TBModPerfil";
            TBModPerfil.Size = new Size(167, 35);
            TBModPerfil.TabIndex = 16;
            // 
            // LModPerfil
            // 
            LModPerfil.AutoSize = true;
            LModPerfil.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LModPerfil.ForeColor = Color.White;
            LModPerfil.Location = new Point(92, 69);
            LModPerfil.Margin = new Padding(6, 0, 6, 0);
            LModPerfil.Name = "LModPerfil";
            LModPerfil.Size = new Size(65, 21);
            LModPerfil.TabIndex = 15;
            LModPerfil.Text = "Perfil: ";
            // 
            // BModificarPerfil
            // 
            BModificarPerfil.BackColor = Color.DarkOliveGreen;
            BModificarPerfil.FlatAppearance.BorderColor = Color.White;
            BModificarPerfil.FlatAppearance.BorderSize = 2;
            BModificarPerfil.FlatStyle = FlatStyle.Flat;
            BModificarPerfil.Font = new Font("Britannic Bold", 13.0f);
            BModificarPerfil.ForeColor = Color.White;
            BModificarPerfil.Location = new Point(295, 240);
            BModificarPerfil.Margin = new Padding(4);
            BModificarPerfil.Name = "BModificarPerfil";
            BModificarPerfil.Size = new Size(98, 42);
            BModificarPerfil.TabIndex = 13;
            BModificarPerfil.Text = "Modificar";
            BModificarPerfil.UseVisualStyleBackColor = false;
            // 
            // ModificarPerfiles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelModMarca);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarPerfiles";
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