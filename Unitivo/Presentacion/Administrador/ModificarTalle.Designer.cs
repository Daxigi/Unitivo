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
            BCancelar = new Button();
            GroupBoxDatosTalles = new GroupBox();
            TBModTalle = new TextBox();
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
            PanelModTalle.Controls.Add(BCancelar);
            PanelModTalle.Controls.Add(GroupBoxDatosTalles);
            PanelModTalle.Controls.Add(BModificarTalle);
            PanelModTalle.Location = new Point(95, 83);
            PanelModTalle.Margin = new Padding(5, 6, 5, 6);
            PanelModTalle.Name = "PanelModTalle";
            PanelModTalle.Size = new Size(612, 465);
            PanelModTalle.TabIndex = 9;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.White;
            BCancelar.Location = new Point(244, 369);
            BCancelar.Margin = new Padding(5, 6, 5, 6);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(131, 65);
            BCancelar.TabIndex = 12;
            BCancelar.Text = "Volver";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // GroupBoxDatosTalles
            // 
            GroupBoxDatosTalles.Controls.Add(TBModTalle);
            GroupBoxDatosTalles.Controls.Add(LModTalle);
            GroupBoxDatosTalles.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosTalles.ForeColor = Color.White;
            GroupBoxDatosTalles.Location = new Point(51, 28);
            GroupBoxDatosTalles.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosTalles.Name = "GroupBoxDatosTalles";
            GroupBoxDatosTalles.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosTalles.Size = new Size(473, 308);
            GroupBoxDatosTalles.TabIndex = 19;
            GroupBoxDatosTalles.TabStop = false;
            GroupBoxDatosTalles.Text = "Modificar Talle";
            // 
            // TBModTalle
            // 
            TBModTalle.Location = new Point(127, 151);
            TBModTalle.Margin = new Padding(4, 5, 4, 5);
            TBModTalle.Name = "TBModTalle";
            TBModTalle.Size = new Size(221, 42);
            TBModTalle.TabIndex = 16;
            // 
            // LModTalle
            // 
            LModTalle.AutoSize = true;
            LModTalle.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModTalle.ForeColor = Color.White;
            LModTalle.Location = new Point(123, 106);
            LModTalle.Margin = new Padding(8, 0, 8, 0);
            LModTalle.Name = "LModTalle";
            LModTalle.Size = new Size(84, 27);
            LModTalle.TabIndex = 15;
            LModTalle.Text = "Talle : ";
            // 
            // BModificarTalle
            // 
            BModificarTalle.BackColor = Color.DarkOliveGreen;
            BModificarTalle.FlatAppearance.BorderColor = Color.White;
            BModificarTalle.FlatAppearance.BorderSize = 2;
            BModificarTalle.FlatStyle = FlatStyle.Flat;
            BModificarTalle.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarTalle.ForeColor = Color.White;
            BModificarTalle.Location = new Point(393, 369);
            BModificarTalle.Margin = new Padding(5, 6, 5, 6);
            BModificarTalle.Name = "BModificarTalle";
            BModificarTalle.Size = new Size(131, 65);
            BModificarTalle.TabIndex = 13;
            BModificarTalle.Text = "Modificar";
            BModificarTalle.UseVisualStyleBackColor = false;
            // 
            // ModificarTalle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(845, 621);
            Controls.Add(PanelModTalle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarTalle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelModTalle.ResumeLayout(false);
            GroupBoxDatosTalles.ResumeLayout(false);
            GroupBoxDatosTalles.PerformLayout();
            ResumeLayout(false);
        }

        internal Panel PanelModTalle;
        internal Button BCancelar;
        internal GroupBox GroupBoxDatosTalles;
        internal TextBox TBModTalle;
        internal Label LModTalle;
        internal Button BModificarTalle;

        #endregion
    }
}