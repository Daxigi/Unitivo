namespace Unitivo.Presentacion.Administrador
{
    partial class ModificarCategoria
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
            PanelModCategoria = new Panel();
            BCancelar = new Button();
            GroupBoxDatosCategoria = new GroupBox();
            TBNombreCategoria = new TextBox();
            LModCategoria = new Label();
            BModificarCategoria = new Button();
            PanelModCategoria.SuspendLayout();
            GroupBoxDatosCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // PanelModCategoria
            // 
            PanelModCategoria.BackColor = Color.RosyBrown;
            PanelModCategoria.BackgroundImageLayout = ImageLayout.None;
            PanelModCategoria.Controls.Add(BCancelar);
            PanelModCategoria.Controls.Add(GroupBoxDatosCategoria);
            PanelModCategoria.Controls.Add(BModificarCategoria);
            PanelModCategoria.Location = new Point(101, 90);
            PanelModCategoria.Margin = new Padding(5, 6, 5, 6);
            PanelModCategoria.Name = "PanelModCategoria";
            PanelModCategoria.Size = new Size(612, 465);
            PanelModCategoria.TabIndex = 8;
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
            // GroupBoxDatosCategoria
            // 
            GroupBoxDatosCategoria.Controls.Add(TBNombreCategoria);
            GroupBoxDatosCategoria.Controls.Add(LModCategoria);
            GroupBoxDatosCategoria.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCategoria.ForeColor = Color.White;
            GroupBoxDatosCategoria.Location = new Point(51, 28);
            GroupBoxDatosCategoria.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCategoria.Name = "GroupBoxDatosCategoria";
            GroupBoxDatosCategoria.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCategoria.Size = new Size(473, 308);
            GroupBoxDatosCategoria.TabIndex = 19;
            GroupBoxDatosCategoria.TabStop = false;
            GroupBoxDatosCategoria.Text = "Modificar Categoria";
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Location = new Point(127, 151);
            TBNombreCategoria.Margin = new Padding(4, 5, 4, 5);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(221, 42);
            TBNombreCategoria.TabIndex = 16;
            TBNombreCategoria.KeyPress += StrNum_KeyPress;
            // 
            // LModCategoria
            // 
            LModCategoria.AutoSize = true;
            LModCategoria.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModCategoria.ForeColor = Color.White;
            LModCategoria.Location = new Point(123, 106);
            LModCategoria.Margin = new Padding(8, 0, 8, 0);
            LModCategoria.Name = "LModCategoria";
            LModCategoria.Size = new Size(136, 27);
            LModCategoria.TabIndex = 15;
            LModCategoria.Text = "Categoria : ";
            // 
            // BModificarCategoria
            // 
            BModificarCategoria.BackColor = Color.DarkOliveGreen;
            BModificarCategoria.FlatAppearance.BorderColor = Color.White;
            BModificarCategoria.FlatAppearance.BorderSize = 2;
            BModificarCategoria.FlatStyle = FlatStyle.Flat;
            BModificarCategoria.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarCategoria.ForeColor = Color.White;
            BModificarCategoria.Location = new Point(393, 369);
            BModificarCategoria.Margin = new Padding(5, 6, 5, 6);
            BModificarCategoria.Name = "BModificarCategoria";
            BModificarCategoria.Size = new Size(131, 65);
            BModificarCategoria.TabIndex = 13;
            BModificarCategoria.Text = "Modificar";
            BModificarCategoria.UseVisualStyleBackColor = false;
            BModificarCategoria.Click += BModificarCategoria_Click;
            // 
            // ModificarCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(876, 635);
            Controls.Add(PanelModCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarCategoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelModCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        internal Panel PanelModCategoria;
        internal Button BCancelar;
        internal GroupBox GroupBoxDatosCategoria;
        internal TextBox TBNombreCategoria;
        internal Label LModCategoria;
        internal Button BModificarCategoria;

        #endregion
    }
}