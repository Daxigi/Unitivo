namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirCategoria
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
            BVolver = new Button();
            //BVolver.Click += new EventHandler(Volver_Click);
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            dgvRegistroCategoria = new DataGridView();
            PanelRegCategoria = new Panel();
            BRegistrarCategoria = new Button();
            TBNombreCategoria = new TextBox();
            //TBNombreCategoria.KeyPress += new KeyPressEventHandler(TBNombreCategoria_KeyPress);
            LNombreCategoria = new Label();
            TabControlRegCategoria.SuspendLayout();
            TabPageListaCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).BeginInit();
            PanelRegCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderColor = Color.White;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(568, 430);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(100, 42);
            BVolver.TabIndex = 38;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlRegCategoria.Location = new Point(133, 173);
            TabControlRegCategoria.Margin = new Padding(2);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(535, 242);
            TabControlRegCategoria.TabIndex = 37;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(dgvRegistroCategoria);
            TabPageListaCategoria.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 25);
            TabPageListaCategoria.Margin = new Padding(2);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2);
            TabPageListaCategoria.Size = new Size(527, 213);
            TabPageListaCategoria.TabIndex = 0;
            TabPageListaCategoria.Text = "Lista de Categorias";
            TabPageListaCategoria.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroCategoria
            // 
            dgvRegistroCategoria.AllowUserToAddRows = false;
            dgvRegistroCategoria.AllowUserToDeleteRows = false;
            dgvRegistroCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroCategoria.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroCategoria.BackgroundColor = Color.RosyBrown;
            dgvRegistroCategoria.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(255, 139, 0);
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvRegistroCategoria.ColumnHeadersHeight = 20;
            dgvRegistroCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroCategoria.Dock = DockStyle.Fill;
            dgvRegistroCategoria.EnableHeadersVisualStyles = false;
            dgvRegistroCategoria.Location = new Point(2, 2);
            dgvRegistroCategoria.Margin = new Padding(2);
            dgvRegistroCategoria.Name = "dgvRegistroCategoria";
            dgvRegistroCategoria.ReadOnly = true;
            dgvRegistroCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvRegistroCategoria.RowHeadersWidth = 51;
            dgvRegistroCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroCategoria.RowTemplate.Height = 24;
            dgvRegistroCategoria.Size = new Size(523, 209);
            dgvRegistroCategoria.TabIndex = 0;
            // 
            // PanelRegCategoria
            // 
            PanelRegCategoria.BackColor = Color.Cornsilk;
            PanelRegCategoria.BackgroundImageLayout = ImageLayout.None;
            PanelRegCategoria.Controls.Add(BRegistrarCategoria);
            PanelRegCategoria.Controls.Add(TBNombreCategoria);
            PanelRegCategoria.Controls.Add(LNombreCategoria);
            PanelRegCategoria.Location = new Point(192, 32);
            PanelRegCategoria.Name = "PanelRegCategoria";
            PanelRegCategoria.Size = new Size(433, 112);
            PanelRegCategoria.TabIndex = 36;
            // 
            // BRegistrarCategoria
            // 
            BRegistrarCategoria.BackColor = Color.DarkOliveGreen;
            BRegistrarCategoria.FlatAppearance.BorderColor = Color.White;
            BRegistrarCategoria.FlatAppearance.BorderSize = 2;
            BRegistrarCategoria.FlatStyle = FlatStyle.Flat;
            BRegistrarCategoria.Font = new Font("Britannic Bold", 13.0f);
            BRegistrarCategoria.ForeColor = Color.White;
            BRegistrarCategoria.Location = new Point(318, 48);
            BRegistrarCategoria.Name = "BRegistrarCategoria";
            BRegistrarCategoria.Size = new Size(98, 42);
            BRegistrarCategoria.TabIndex = 13;
            BRegistrarCategoria.Text = "Añadir";
            BRegistrarCategoria.UseVisualStyleBackColor = false;
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Font = new Font("Britannic Bold", 12.0f);
            TBNombreCategoria.Location = new Point(20, 58);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(279, 25);
            TBNombreCategoria.TabIndex = 6;
            // 
            // LNombreCategoria
            // 
            LNombreCategoria.AutoSize = true;
            LNombreCategoria.BackColor = Color.Cornsilk;
            LNombreCategoria.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreCategoria.ForeColor = Color.DarkOrange;
            LNombreCategoria.Location = new Point(17, 10);
            LNombreCategoria.Name = "LNombreCategoria";
            LNombreCategoria.Size = new Size(283, 27);
            LNombreCategoria.TabIndex = 0;
            LNombreCategoria.Text = "Nombre de Categoria :";
            // 
            // AñadirCategoria
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 500);
            Controls.Add(BVolver);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(PanelRegCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirCategoria";
            Text = "Form1";
            TabControlRegCategoria.ResumeLayout(false);
            TabPageListaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).EndInit();
            PanelRegCategoria.ResumeLayout(false);
            PanelRegCategoria.PerformLayout();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal TabControl TabControlRegCategoria;
        internal TabPage TabPageListaCategoria;
        internal DataGridView dgvRegistroCategoria;
        internal Panel PanelRegCategoria;
        internal Button BRegistrarCategoria;
        internal TextBox TBNombreCategoria;
        internal Label LNombreCategoria;

        #endregion
    }
}