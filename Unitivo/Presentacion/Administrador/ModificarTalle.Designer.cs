namespace Unitivo.Presentacion.Administrador
{
    partial class ModificarTalle
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
            PanelModTalle = new Panel();
            BCancelarModifTalle = new Button();
            //BCancelarModifTalle.Click += new EventHandler(BCancelarModifTalle_Click);
            GroupBoxDatosTalles = new GroupBox();
            TBModTalle = new TextBox();
            //TBModTalle.KeyPress += new KeyPressEventHandler(TBModTalle_KeyPress);
            LModTalle = new Label();
            BModificarTalle = new Button();
            PanelModTalle.SuspendLayout();
            GroupBoxDatosTalles.SuspendLayout();
            SuspendLayout();
            // 
            // PanelModTalle
            // 
            PanelModTalle.BackColor = Color.RosyBrown;
            PanelModTalle.BackgroundImageLayout = ImageLayout.None;
            PanelModTalle.Controls.Add(BCancelarModifTalle);
            PanelModTalle.Controls.Add(GroupBoxDatosTalles);
            PanelModTalle.Controls.Add(BModificarTalle);
            PanelModTalle.Location = new Point(171, 74);
            PanelModTalle.Margin = new Padding(4);
            PanelModTalle.Name = "PanelModTalle";
            PanelModTalle.Size = new Size(459, 302);
            PanelModTalle.TabIndex = 9;
            // 
            // BCancelarModifTalle
            // 
            BCancelarModifTalle.BackColor = Color.Sienna;
            BCancelarModifTalle.FlatAppearance.BorderSize = 2;
            BCancelarModifTalle.FlatStyle = FlatStyle.Flat;
            BCancelarModifTalle.Font = new Font("Britannic Bold", 13.0f);
            BCancelarModifTalle.ForeColor = Color.White;
            BCancelarModifTalle.Location = new Point(183, 240);
            BCancelarModifTalle.Margin = new Padding(4);
            BCancelarModifTalle.Name = "BCancelarModifTalle";
            BCancelarModifTalle.Size = new Size(98, 42);
            BCancelarModifTalle.TabIndex = 12;
            BCancelarModifTalle.Text = "Volver";
            BCancelarModifTalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifTalle.UseVisualStyleBackColor = false;
            // 
            // GroupBoxDatosTalles
            // 
            GroupBoxDatosTalles.Controls.Add(TBModTalle);
            GroupBoxDatosTalles.Controls.Add(LModTalle);
            GroupBoxDatosTalles.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDatosTalles.ForeColor = Color.White;
            GroupBoxDatosTalles.Location = new Point(38, 18);
            GroupBoxDatosTalles.Name = "GroupBoxDatosTalles";
            GroupBoxDatosTalles.Size = new Size(355, 200);
            GroupBoxDatosTalles.TabIndex = 19;
            GroupBoxDatosTalles.TabStop = false;
            GroupBoxDatosTalles.Text = "Modificar Talle";
            // 
            // TBModTalle
            // 
            TBModTalle.Location = new Point(95, 98);
            TBModTalle.Name = "TBModTalle";
            TBModTalle.Size = new Size(167, 35);
            TBModTalle.TabIndex = 16;
            // 
            // LModTalle
            // 
            LModTalle.AutoSize = true;
            LModTalle.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LModTalle.ForeColor = Color.White;
            LModTalle.Location = new Point(92, 69);
            LModTalle.Margin = new Padding(6, 0, 6, 0);
            LModTalle.Name = "LModTalle";
            LModTalle.Size = new Size(66, 21);
            LModTalle.TabIndex = 15;
            LModTalle.Text = "Talle : ";
            // 
            // BModificarTalle
            // 
            BModificarTalle.BackColor = Color.DarkOliveGreen;
            BModificarTalle.FlatAppearance.BorderColor = Color.White;
            BModificarTalle.FlatAppearance.BorderSize = 2;
            BModificarTalle.FlatStyle = FlatStyle.Flat;
            BModificarTalle.Font = new Font("Britannic Bold", 13.0f);
            BModificarTalle.ForeColor = Color.White;
            BModificarTalle.Location = new Point(295, 240);
            BModificarTalle.Margin = new Padding(4);
            BModificarTalle.Name = "BModificarTalle";
            BModificarTalle.Size = new Size(98, 42);
            BModificarTalle.TabIndex = 13;
            BModificarTalle.Text = "Modificar";
            BModificarTalle.UseVisualStyleBackColor = false;
            // 
            // ModificarTalle
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelModTalle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarTalle";
            Text = "Form1";
            PanelModTalle.ResumeLayout(false);
            GroupBoxDatosTalles.ResumeLayout(false);
            GroupBoxDatosTalles.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel PanelModTalle;
        internal Button BCancelarModifTalle;
        internal GroupBox GroupBoxDatosTalles;
        internal TextBox TBModTalle;
        internal Label LModTalle;
        internal Button BModificarTalle;

        #endregion
    }
}