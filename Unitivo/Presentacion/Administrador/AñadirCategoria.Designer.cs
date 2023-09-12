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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BVolver = new Button();
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            dgvRegistroCategoria = new DataGridView();
            PanelRegCategoria = new Panel();
            BRegistrarCategoria = new Button();
            TBNombreCategoria = new TextBox();
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
            BVolver.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(663, 496);
            BVolver.Margin = new Padding(4, 3, 4, 3);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(117, 48);
            BVolver.TabIndex = 38;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegCategoria.Location = new Point(155, 200);
            TabControlRegCategoria.Margin = new Padding(2);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(624, 279);
            TabControlRegCategoria.TabIndex = 37;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(dgvRegistroCategoria);
            TabPageListaCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 26);
            TabPageListaCategoria.Margin = new Padding(2);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2);
            TabPageListaCategoria.Size = new Size(616, 249);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 139, 0);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistroCategoria.ColumnHeadersHeight = 20;
            dgvRegistroCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroCategoria.Dock = DockStyle.Fill;
            dgvRegistroCategoria.EnableHeadersVisualStyles = false;
            dgvRegistroCategoria.Location = new Point(2, 2);
            dgvRegistroCategoria.Margin = new Padding(2);
            dgvRegistroCategoria.Name = "dgvRegistroCategoria";
            dgvRegistroCategoria.ReadOnly = true;
            dgvRegistroCategoria.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistroCategoria.RowHeadersWidth = 51;
            dgvRegistroCategoria.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroCategoria.RowTemplate.Height = 24;
            dgvRegistroCategoria.Size = new Size(612, 245);
            dgvRegistroCategoria.TabIndex = 0;
            // 
            // PanelRegCategoria
            // 
            PanelRegCategoria.BackColor = Color.Cornsilk;
            PanelRegCategoria.BackgroundImageLayout = ImageLayout.None;
            PanelRegCategoria.Controls.Add(BRegistrarCategoria);
            PanelRegCategoria.Controls.Add(TBNombreCategoria);
            PanelRegCategoria.Controls.Add(LNombreCategoria);
            PanelRegCategoria.Location = new Point(221, 29);
            PanelRegCategoria.Margin = new Padding(4, 3, 4, 3);
            PanelRegCategoria.Name = "PanelRegCategoria";
            PanelRegCategoria.Size = new Size(505, 133);
            PanelRegCategoria.TabIndex = 36;
            // 
            // BRegistrarCategoria
            // 
            BRegistrarCategoria.BackColor = Color.DarkOliveGreen;
            BRegistrarCategoria.FlatAppearance.BorderColor = Color.White;
            BRegistrarCategoria.FlatAppearance.BorderSize = 2;
            BRegistrarCategoria.FlatStyle = FlatStyle.Flat;
            BRegistrarCategoria.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarCategoria.ForeColor = Color.White;
            BRegistrarCategoria.Location = new Point(371, 55);
            BRegistrarCategoria.Margin = new Padding(4, 3, 4, 3);
            BRegistrarCategoria.Name = "BRegistrarCategoria";
            BRegistrarCategoria.Size = new Size(114, 48);
            BRegistrarCategoria.TabIndex = 13;
            BRegistrarCategoria.Text = "Añadir";
            BRegistrarCategoria.UseVisualStyleBackColor = false;
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreCategoria.Location = new Point(20, 66);
            TBNombreCategoria.Margin = new Padding(4, 3, 4, 3);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(325, 26);
            TBNombreCategoria.TabIndex = 6;
            TBNombreCategoria.KeyPress += TBNombreCategoria_KeyPress;
            // 
            // LNombreCategoria
            // 
            LNombreCategoria.AutoSize = true;
            LNombreCategoria.BackColor = Color.Cornsilk;
            LNombreCategoria.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCategoria.ForeColor = Color.DarkOrange;
            LNombreCategoria.Location = new Point(20, 12);
            LNombreCategoria.Margin = new Padding(4, 0, 4, 0);
            LNombreCategoria.Name = "LNombreCategoria";
            LNombreCategoria.Size = new Size(258, 29);
            LNombreCategoria.TabIndex = 0;
            LNombreCategoria.Text = "Nombre de Categoria :";
            // 
            // AñadirCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(933, 577);
            Controls.Add(BVolver);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(PanelRegCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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