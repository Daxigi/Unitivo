namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarTalles
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
            GroupBoxGestionTalles = new GroupBox();
            BBuscarTalle = new Button();
            TBBuscarTalle = new TextBox();
            //TBBuscarTalle.KeyPress += new KeyPressEventHandler(TBBuscarTalle_KeyPress);
            BEditarTalle = new Button();
            BEliminarTalle = new Button();
            TabListaTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            dgvListarTalles = new DataGridView();
            //dgvListarTalles.CellContentClick += new DataGridViewCellEventHandler(dgvListarTalles_CellContentClick);
            BAltaTalle = new Button();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxGestionTalles.SuspendLayout();
            TabListaTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionTalles
            // 
            GroupBoxGestionTalles.BackColor = Color.Cornsilk;
            GroupBoxGestionTalles.Controls.Add(BBuscarTalle);
            GroupBoxGestionTalles.Controls.Add(TBBuscarTalle);
            GroupBoxGestionTalles.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionTalles.ForeColor = Color.SaddleBrown;
            GroupBoxGestionTalles.Location = new Point(255, 27);
            GroupBoxGestionTalles.Name = "GroupBoxGestionTalles";
            GroupBoxGestionTalles.Size = new Size(319, 99);
            GroupBoxGestionTalles.TabIndex = 91;
            GroupBoxGestionTalles.TabStop = false;
            GroupBoxGestionTalles.Text = "Gestión de Talles";
            // 
            // BBuscarTalle
            // 
            BBuscarTalle.BackColor = Color.DarkOliveGreen;
            BBuscarTalle.FlatAppearance.BorderColor = Color.White;
            BBuscarTalle.FlatAppearance.BorderSize = 2;
            BBuscarTalle.FlatStyle = FlatStyle.Flat;
            BBuscarTalle.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarTalle.ForeColor = Color.White;
            BBuscarTalle.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarTalle.Location = new Point(214, 39);
            BBuscarTalle.Name = "BBuscarTalle";
            BBuscarTalle.Size = new Size(49, 41);
            BBuscarTalle.TabIndex = 14;
            BBuscarTalle.UseVisualStyleBackColor = false;
            // 
            // TBBuscarTalle
            // 
            TBBuscarTalle.Font = new Font("Britannic Bold", 12.0f);
            TBBuscarTalle.Location = new Point(49, 49);
            TBBuscarTalle.Name = "TBBuscarTalle";
            TBBuscarTalle.Size = new Size(148, 25);
            TBBuscarTalle.TabIndex = 6;
            // 
            // BEditarTalle
            // 
            BEditarTalle.BackColor = Color.SteelBlue;
            BEditarTalle.FlatAppearance.BorderColor = Color.White;
            BEditarTalle.FlatAppearance.BorderSize = 2;
            BEditarTalle.FlatStyle = FlatStyle.Flat;
            BEditarTalle.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEditarTalle.ForeColor = Color.White;
            BEditarTalle.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarTalle.Location = new Point(730, 260);
            BEditarTalle.Name = "BEditarTalle";
            BEditarTalle.Size = new Size(50, 45);
            BEditarTalle.TabIndex = 89;
            BEditarTalle.UseVisualStyleBackColor = false;
            // 
            // BEliminarTalle
            // 
            BEliminarTalle.BackColor = Color.Brown;
            BEliminarTalle.FlatAppearance.BorderSize = 2;
            BEliminarTalle.FlatStyle = FlatStyle.Flat;
            BEliminarTalle.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEliminarTalle.ForeColor = Color.White;
            BEliminarTalle.Image = Properties.Resources.icons8_basura_26;
            BEliminarTalle.Location = new Point(730, 336);
            BEliminarTalle.Name = "BEliminarTalle";
            BEliminarTalle.Size = new Size(50, 45);
            BEliminarTalle.TabIndex = 88;
            BEliminarTalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarTalle.UseVisualStyleBackColor = false;
            // 
            // TabListaTalles
            // 
            TabListaTalles.Controls.Add(TabPageListaTalles);
            TabListaTalles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaTalles.Location = new Point(21, 141);
            TabListaTalles.Margin = new Padding(2);
            TabListaTalles.Name = "TabListaTalles";
            TabListaTalles.SelectedIndex = 0;
            TabListaTalles.Size = new Size(688, 301);
            TabListaTalles.TabIndex = 90;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(dgvListarTalles);
            TabPageListaTalles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 25);
            TabPageListaTalles.Margin = new Padding(2);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(2);
            TabPageListaTalles.Size = new Size(680, 272);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // dgvListarTalles
            // 
            dgvListarTalles.AllowUserToAddRows = false;
            dgvListarTalles.AllowUserToDeleteRows = false;
            dgvListarTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarTalles.BackgroundColor = Color.RosyBrown;
            dgvListarTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvListarTalles.ColumnHeadersHeight = 20;
            dgvListarTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Window;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarTalles.DefaultCellStyle = DataGridViewCellStyle2;
            dgvListarTalles.Dock = DockStyle.Fill;
            dgvListarTalles.EnableHeadersVisualStyles = false;
            dgvListarTalles.Location = new Point(2, 2);
            dgvListarTalles.Name = "dgvListarTalles";
            dgvListarTalles.ReadOnly = true;
            dgvListarTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
            dgvListarTalles.RowHeadersWidth = 51;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListarTalles.RowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvListarTalles.Size = new Size(676, 268);
            dgvListarTalles.TabIndex = 3;
            // 
            // BAltaTalle
            // 
            BAltaTalle.BackColor = Color.DarkOliveGreen;
            BAltaTalle.ForeColor = Color.White;
            BAltaTalle.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaTalle.Location = new Point(730, 336);
            BAltaTalle.Name = "BAltaTalle";
            BAltaTalle.Size = new Size(50, 45);
            BAltaTalle.TabIndex = 92;
            BAltaTalle.UseVisualStyleBackColor = false;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(603, 468);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 93;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // GestionarTalles
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 550);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionTalles);
            Controls.Add(BEditarTalle);
            Controls.Add(BEliminarTalle);
            Controls.Add(TabListaTalles);
            Controls.Add(BAltaTalle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarTalles";
            Text = "Form1";
            GroupBoxGestionTalles.ResumeLayout(false);
            GroupBoxGestionTalles.PerformLayout();
            TabListaTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).EndInit();
            ResumeLayout(false);

        }

        internal GroupBox GroupBoxGestionTalles;
        internal Button BBuscarTalle;
        internal TextBox TBBuscarTalle;
        internal Button BEditarTalle;
        internal Button BEliminarTalle;
        internal TabControl TabListaTalles;
        internal TabPage TabPageListaTalles;
        internal DataGridView dgvListarTalles;
        internal Button BAltaTalle;
        internal Button BVolver;

        #endregion
    }
}