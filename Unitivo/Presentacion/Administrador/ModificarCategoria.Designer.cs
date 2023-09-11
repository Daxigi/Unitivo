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
            BCancelarModifCategoria = new Button();
            //BCancelarModifCategoria.Click += new EventHandler(BCancelarModifCategoria_Click);
            GroupBoxDatosCategoria = new GroupBox();
            TBNombreCategoria = new TextBox();
            //TBNombreCategoria.KeyPress += new KeyPressEventHandler(TBNombreCategoria_KeyPress);
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
            PanelModCategoria.Controls.Add(BCancelarModifCategoria);
            PanelModCategoria.Controls.Add(GroupBoxDatosCategoria);
            PanelModCategoria.Controls.Add(BModificarCategoria);
            PanelModCategoria.Location = new Point(171, 74);
            PanelModCategoria.Margin = new Padding(4);
            PanelModCategoria.Name = "PanelModCategoria";
            PanelModCategoria.Size = new Size(459, 302);
            PanelModCategoria.TabIndex = 8;
            // 
            // BCancelarModifCategoria
            // 
            BCancelarModifCategoria.BackColor = Color.Sienna;
            BCancelarModifCategoria.FlatAppearance.BorderSize = 2;
            BCancelarModifCategoria.FlatStyle = FlatStyle.Flat;
            BCancelarModifCategoria.Font = new Font("Britannic Bold", 13.0f);
            BCancelarModifCategoria.ForeColor = Color.White;
            BCancelarModifCategoria.Location = new Point(183, 240);
            BCancelarModifCategoria.Margin = new Padding(4);
            BCancelarModifCategoria.Name = "BCancelarModifCategoria";
            BCancelarModifCategoria.Size = new Size(98, 42);
            BCancelarModifCategoria.TabIndex = 12;
            BCancelarModifCategoria.Text = "Volver";
            BCancelarModifCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelarModifCategoria.UseVisualStyleBackColor = false;
            // 
            // GroupBoxDatosCategoria
            // 
            GroupBoxDatosCategoria.Controls.Add(TBNombreCategoria);
            GroupBoxDatosCategoria.Controls.Add(LModCategoria);
            GroupBoxDatosCategoria.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxDatosCategoria.ForeColor = Color.White;
            GroupBoxDatosCategoria.Location = new Point(38, 18);
            GroupBoxDatosCategoria.Name = "GroupBoxDatosCategoria";
            GroupBoxDatosCategoria.Size = new Size(355, 200);
            GroupBoxDatosCategoria.TabIndex = 19;
            GroupBoxDatosCategoria.TabStop = false;
            GroupBoxDatosCategoria.Text = "Modificar Categoria";
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Location = new Point(95, 98);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(167, 35);
            TBNombreCategoria.TabIndex = 16;
            // 
            // LModCategoria
            // 
            LModCategoria.AutoSize = true;
            LModCategoria.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LModCategoria.ForeColor = Color.White;
            LModCategoria.Location = new Point(92, 69);
            LModCategoria.Margin = new Padding(6, 0, 6, 0);
            LModCategoria.Name = "LModCategoria";
            LModCategoria.Size = new Size(106, 21);
            LModCategoria.TabIndex = 15;
            LModCategoria.Text = "Categoria : ";
            // 
            // BModificarCategoria
            // 
            BModificarCategoria.BackColor = Color.DarkOliveGreen;
            BModificarCategoria.FlatAppearance.BorderColor = Color.White;
            BModificarCategoria.FlatAppearance.BorderSize = 2;
            BModificarCategoria.FlatStyle = FlatStyle.Flat;
            BModificarCategoria.Font = new Font("Britannic Bold", 13.0f);
            BModificarCategoria.ForeColor = Color.White;
            BModificarCategoria.Location = new Point(295, 240);
            BModificarCategoria.Margin = new Padding(4);
            BModificarCategoria.Name = "BModificarCategoria";
            BModificarCategoria.Size = new Size(98, 42);
            BModificarCategoria.TabIndex = 13;
            BModificarCategoria.Text = "Modificar";
            BModificarCategoria.UseVisualStyleBackColor = false;
            // 
            // ModificarCategoria
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelModCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarCategoria";
            Text = "Form1";
            PanelModCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.ResumeLayout(false);
            GroupBoxDatosCategoria.PerformLayout();
            ResumeLayout(false);

        }

        internal Panel PanelModCategoria;
        internal Button BCancelarModifCategoria;
        internal GroupBox GroupBoxDatosCategoria;
        internal TextBox TBNombreCategoria;
        internal Label LModCategoria;
        internal Button BModificarCategoria;

        #endregion
    }
}