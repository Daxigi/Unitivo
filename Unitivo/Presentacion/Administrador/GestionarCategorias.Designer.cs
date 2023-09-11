namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarCategorias
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            GroupBoxGestionCategorias = new GroupBox();
            BBuscarCategoria = new Button();
            TBGestionCategoria = new TextBox();
            //TBGestionCategoria.KeyPress += new KeyPressEventHandler(TBGestionCategoria_KeyPress);
            TabListaCategorias = new TabControl();
            TabPageListaCategorias = new TabPage();
            dgvListarCategorias = new DataGridView();
            //dgvListarCategorias.Click += new EventHandler(dgvListarCategorias_Click);
            //dgvListarCategorias.CellContentClick += new DataGridViewCellEventHandler(dgvListarCategorias_CellContentClick);
            BEditarCategoria = new Button();
            BEliminarCategoria = new Button();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            BAltaCategoria = new Button();
            GroupBoxGestionCategorias.SuspendLayout();
            TabListaCategorias.SuspendLayout();
            TabPageListaCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarCategorias).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionCategorias
            // 
            GroupBoxGestionCategorias.BackColor = Color.Cornsilk;
            GroupBoxGestionCategorias.Controls.Add(BBuscarCategoria);
            GroupBoxGestionCategorias.Controls.Add(TBGestionCategoria);
            GroupBoxGestionCategorias.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionCategorias.ForeColor = Color.SaddleBrown;
            GroupBoxGestionCategorias.Location = new Point(255, 30);
            GroupBoxGestionCategorias.Name = "GroupBoxGestionCategorias";
            GroupBoxGestionCategorias.Size = new Size(319, 99);
            GroupBoxGestionCategorias.TabIndex = 27;
            GroupBoxGestionCategorias.TabStop = false;
            GroupBoxGestionCategorias.Text = "Gestión de Categorias";
            // 
            // BBuscarCategoria
            // 
            BBuscarCategoria.BackColor = Color.DarkOliveGreen;
            BBuscarCategoria.FlatAppearance.BorderColor = Color.White;
            BBuscarCategoria.FlatAppearance.BorderSize = 2;
            BBuscarCategoria.FlatStyle = FlatStyle.Flat;
            BBuscarCategoria.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarCategoria.ForeColor = Color.White;
            BBuscarCategoria.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarCategoria.Location = new Point(214, 39);
            BBuscarCategoria.Name = "BBuscarCategoria";
            BBuscarCategoria.Size = new Size(49, 41);
            BBuscarCategoria.TabIndex = 14;
            BBuscarCategoria.UseVisualStyleBackColor = false;
            // 
            // TBGestionCategoria
            // 
            TBGestionCategoria.Font = new Font("Britannic Bold", 12.0f);
            TBGestionCategoria.Location = new Point(49, 49);
            TBGestionCategoria.Name = "TBGestionCategoria";
            TBGestionCategoria.Size = new Size(148, 25);
            TBGestionCategoria.TabIndex = 6;
            // 
            // TabListaCategorias
            // 
            TabListaCategorias.Controls.Add(TabPageListaCategorias);
            TabListaCategorias.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaCategorias.Location = new Point(21, 144);
            TabListaCategorias.Margin = new Padding(2);
            TabListaCategorias.Name = "TabListaCategorias";
            TabListaCategorias.SelectedIndex = 0;
            TabListaCategorias.Size = new Size(688, 301);
            TabListaCategorias.TabIndex = 26;
            // 
            // TabPageListaCategorias
            // 
            TabPageListaCategorias.Controls.Add(dgvListarCategorias);
            TabPageListaCategorias.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaCategorias.ForeColor = Color.White;
            TabPageListaCategorias.Location = new Point(4, 25);
            TabPageListaCategorias.Margin = new Padding(2);
            TabPageListaCategorias.Name = "TabPageListaCategorias";
            TabPageListaCategorias.Padding = new Padding(2);
            TabPageListaCategorias.Size = new Size(680, 272);
            TabPageListaCategorias.TabIndex = 0;
            TabPageListaCategorias.Text = "Lista de Categorias";
            TabPageListaCategorias.UseVisualStyleBackColor = true;
            // 
            // dgvListarCategorias
            // 
            dgvListarCategorias.AllowUserToAddRows = false;
            dgvListarCategorias.AllowUserToDeleteRows = false;
            dgvListarCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarCategorias.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarCategorias.BackgroundColor = Color.RosyBrown;
            dgvListarCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvListarCategorias.ColumnHeadersHeight = 20;
            dgvListarCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Window;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarCategorias.DefaultCellStyle = DataGridViewCellStyle2;
            dgvListarCategorias.Dock = DockStyle.Fill;
            dgvListarCategorias.EnableHeadersVisualStyles = false;
            dgvListarCategorias.Location = new Point(2, 2);
            dgvListarCategorias.Name = "dgvListarCategorias";
            dgvListarCategorias.ReadOnly = true;
            dgvListarCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
            dgvListarCategorias.RowHeadersWidth = 51;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListarCategorias.RowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvListarCategorias.Size = new Size(676, 268);
            dgvListarCategorias.TabIndex = 3;
            // 
            // BEditarCategoria
            // 
            BEditarCategoria.BackColor = Color.SteelBlue;
            BEditarCategoria.FlatAppearance.BorderColor = Color.White;
            BEditarCategoria.FlatAppearance.BorderSize = 2;
            BEditarCategoria.FlatStyle = FlatStyle.Flat;
            BEditarCategoria.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEditarCategoria.ForeColor = Color.White;
            BEditarCategoria.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCategoria.Location = new Point(730, 263);
            BEditarCategoria.Name = "BEditarCategoria";
            BEditarCategoria.Size = new Size(50, 45);
            BEditarCategoria.TabIndex = 25;
            BEditarCategoria.UseVisualStyleBackColor = false;
            // 
            // BEliminarCategoria
            // 
            BEliminarCategoria.BackColor = Color.Brown;
            BEliminarCategoria.FlatAppearance.BorderSize = 2;
            BEliminarCategoria.FlatStyle = FlatStyle.Flat;
            BEliminarCategoria.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEliminarCategoria.ForeColor = Color.White;
            BEliminarCategoria.Image = Properties.Resources.icons8_basura_26;
            BEliminarCategoria.Location = new Point(730, 339);
            BEliminarCategoria.Name = "BEliminarCategoria";
            BEliminarCategoria.Size = new Size(50, 45);
            BEliminarCategoria.TabIndex = 24;
            BEliminarCategoria.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarCategoria.UseVisualStyleBackColor = false;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(603, 472);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 81;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BAltaCategoria
            // 
            BAltaCategoria.BackColor = Color.DarkOliveGreen;
            BAltaCategoria.ForeColor = Color.White;
            BAltaCategoria.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaCategoria.Location = new Point(730, 339);
            BAltaCategoria.Name = "BAltaCategoria";
            BAltaCategoria.Size = new Size(50, 45);
            BAltaCategoria.TabIndex = 87;
            BAltaCategoria.UseVisualStyleBackColor = false;
            // 
            // GestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 550);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionCategorias);
            Controls.Add(BEditarCategoria);
            Controls.Add(BEliminarCategoria);
            Controls.Add(TabListaCategorias);
            Controls.Add(BAltaCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarCategorias";
            Text = "Form1";
            GroupBoxGestionCategorias.ResumeLayout(false);
            GroupBoxGestionCategorias.PerformLayout();
            TabListaCategorias.ResumeLayout(false);
            TabPageListaCategorias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarCategorias).EndInit();
            ResumeLayout(false);

        }

        internal GroupBox GroupBoxGestionCategorias;
        internal Button BBuscarCategoria;
        internal TextBox TBGestionCategoria;
        internal Button BEditarCategoria;
        internal Button BEliminarCategoria;
        internal TabControl TabListaCategorias;
        internal TabPage TabPageListaCategorias;
        internal DataGridView dgvListarCategorias;
        internal Button BVolver;
        internal Button BAltaCategoria;

        #endregion
    }
}