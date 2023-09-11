namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarPerfiles
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
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxGestionPerfil = new GroupBox();
            BBuscarPerfil = new Button();
            TBGestionPerfil = new TextBox();
            TabListaPerfiles = new TabControl();
            TabPagePerfiles = new TabPage();
            dgvPerfiles = new DataGridView();
            BModificarPerfiles = new Button();
            BEliminarPerfiles = new Button();
            BAltaPerfil = new Button();
            GroupBoxGestionPerfil.SuspendLayout();
            TabListaPerfiles.SuspendLayout();
            TabPagePerfiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).BeginInit();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(590, 394);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 85;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // GroupBoxGestionPerfil
            // 
            GroupBoxGestionPerfil.BackColor = Color.Cornsilk;
            GroupBoxGestionPerfil.Controls.Add(BBuscarPerfil);
            GroupBoxGestionPerfil.Controls.Add(TBGestionPerfil);
            GroupBoxGestionPerfil.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionPerfil.ForeColor = Color.Sienna;
            GroupBoxGestionPerfil.Location = new Point(248, 12);
            GroupBoxGestionPerfil.Name = "GroupBoxGestionPerfil";
            GroupBoxGestionPerfil.Size = new Size(305, 93);
            GroupBoxGestionPerfil.TabIndex = 84;
            GroupBoxGestionPerfil.TabStop = false;
            GroupBoxGestionPerfil.Text = "Gestión de Perfiles";
            // 
            // BBuscarPerfil
            // 
            BBuscarPerfil.BackColor = Color.DarkOliveGreen;
            BBuscarPerfil.FlatAppearance.BorderColor = Color.White;
            BBuscarPerfil.FlatAppearance.BorderSize = 2;
            BBuscarPerfil.FlatStyle = FlatStyle.Flat;
            BBuscarPerfil.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarPerfil.ForeColor = Color.White;
            BBuscarPerfil.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarPerfil.Location = new Point(212, 37);
            BBuscarPerfil.Name = "BBuscarPerfil";
            BBuscarPerfil.Size = new Size(45, 41);
            BBuscarPerfil.TabIndex = 14;
            BBuscarPerfil.UseVisualStyleBackColor = false;
            // 
            // TBGestionPerfil
            // 
            TBGestionPerfil.Font = new Font("Britannic Bold", 12.0f);
            TBGestionPerfil.Location = new Point(57, 46);
            TBGestionPerfil.Name = "TBGestionPerfil";
            TBGestionPerfil.Size = new Size(131, 25);
            TBGestionPerfil.TabIndex = 6;
            // 
            // TabListaPerfiles
            // 
            TabListaPerfiles.Controls.Add(TabPagePerfiles);
            TabListaPerfiles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaPerfiles.Location = new Point(27, 110);
            TabListaPerfiles.Margin = new Padding(2);
            TabListaPerfiles.Name = "TabListaPerfiles";
            TabListaPerfiles.SelectedIndex = 0;
            TabListaPerfiles.Size = new Size(669, 269);
            TabListaPerfiles.TabIndex = 83;
            // 
            // TabPagePerfiles
            // 
            TabPagePerfiles.Controls.Add(dgvPerfiles);
            TabPagePerfiles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPagePerfiles.ForeColor = Color.White;
            TabPagePerfiles.Location = new Point(4, 25);
            TabPagePerfiles.Margin = new Padding(2);
            TabPagePerfiles.Name = "TabPagePerfiles";
            TabPagePerfiles.Padding = new Padding(2);
            TabPagePerfiles.Size = new Size(661, 240);
            TabPagePerfiles.TabIndex = 0;
            TabPagePerfiles.Text = "Lista de Perfiles";
            TabPagePerfiles.UseVisualStyleBackColor = true;
            // 
            // dgvPerfiles
            // 
            dgvPerfiles.AllowUserToAddRows = false;
            dgvPerfiles.AllowUserToDeleteRows = false;
            dgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPerfiles.BackgroundColor = Color.RosyBrown;
            dgvPerfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.ForeColor = Color.White;
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvPerfiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            dgvPerfiles.ColumnHeadersHeight = 20;
            dgvPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = SystemColors.Window;
            DataGridViewCellStyle8.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle8.ForeColor = Color.White;
            DataGridViewCellStyle8.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvPerfiles.DefaultCellStyle = DataGridViewCellStyle8;
            dgvPerfiles.Dock = DockStyle.Fill;
            dgvPerfiles.EnableHeadersVisualStyles = false;
            dgvPerfiles.Location = new Point(2, 2);
            dgvPerfiles.Name = "dgvPerfiles";
            dgvPerfiles.ReadOnly = true;
            dgvPerfiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPerfiles.RowHeadersWidth = 51;
            DataGridViewCellStyle9.ForeColor = Color.Black;
            dgvPerfiles.RowsDefaultCellStyle = DataGridViewCellStyle9;
            dgvPerfiles.Size = new Size(657, 236);
            dgvPerfiles.TabIndex = 2;
            // 
            // BModificarPerfiles
            // 
            BModificarPerfiles.BackColor = Color.SteelBlue;
            BModificarPerfiles.ForeColor = Color.White;
            BModificarPerfiles.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarPerfiles.Location = new Point(724, 204);
            BModificarPerfiles.Name = "BModificarPerfiles";
            BModificarPerfiles.Size = new Size(50, 45);
            BModificarPerfiles.TabIndex = 82;
            BModificarPerfiles.UseVisualStyleBackColor = false;
            // 
            // BEliminarPerfiles
            // 
            BEliminarPerfiles.BackColor = Color.Brown;
            BEliminarPerfiles.ForeColor = Color.White;
            BEliminarPerfiles.Image = Properties.Resources.icons8_basura_26;
            BEliminarPerfiles.Location = new Point(724, 265);
            BEliminarPerfiles.Name = "BEliminarPerfiles";
            BEliminarPerfiles.Size = new Size(50, 45);
            BEliminarPerfiles.TabIndex = 81;
            BEliminarPerfiles.UseVisualStyleBackColor = false;
            // 
            // BAltaPerfil
            // 
            BAltaPerfil.BackColor = Color.DarkOliveGreen;
            BAltaPerfil.ForeColor = Color.White;
            BAltaPerfil.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaPerfil.Location = new Point(724, 265);
            BAltaPerfil.Name = "BAltaPerfil";
            BAltaPerfil.Size = new Size(50, 45);
            BAltaPerfil.TabIndex = 86;
            BAltaPerfil.UseVisualStyleBackColor = false;
            // 
            // GestionarPerfiles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionPerfil);
            Controls.Add(TabListaPerfiles);
            Controls.Add(BModificarPerfiles);
            Controls.Add(BEliminarPerfiles);
            Controls.Add(BAltaPerfil);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarPerfiles";
            Text = "Form1";
            GroupBoxGestionPerfil.ResumeLayout(false);
            GroupBoxGestionPerfil.PerformLayout();
            TabListaPerfiles.ResumeLayout(false);
            TabPagePerfiles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).EndInit();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal GroupBox GroupBoxGestionPerfil;
        internal Button BBuscarPerfil;
        internal TextBox TBGestionPerfil;
        internal TabControl TabListaPerfiles;
        internal TabPage TabPagePerfiles;
        internal DataGridView dgvPerfiles;
        internal Button BModificarPerfiles;
        internal Button BEliminarPerfiles;
        internal Button BAltaPerfil;

        #endregion
    }
}