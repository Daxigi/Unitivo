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
            TabControlRegCategoria = new TabControl();
            TabPageListaCategoria = new TabPage();
            dgvRegistroCategoria = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
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
            // TabControlRegCategoria
            // 
            TabControlRegCategoria.Controls.Add(TabPageListaCategoria);
            TabControlRegCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegCategoria.Location = new Point(177, 267);
            TabControlRegCategoria.Margin = new Padding(2, 3, 2, 3);
            TabControlRegCategoria.Name = "TabControlRegCategoria";
            TabControlRegCategoria.SelectedIndex = 0;
            TabControlRegCategoria.Size = new Size(713, 372);
            TabControlRegCategoria.TabIndex = 37;
            // 
            // TabPageListaCategoria
            // 
            TabPageListaCategoria.Controls.Add(dgvRegistroCategoria);
            TabPageListaCategoria.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCategoria.ForeColor = Color.White;
            TabPageListaCategoria.Location = new Point(4, 29);
            TabPageListaCategoria.Margin = new Padding(2, 3, 2, 3);
            TabPageListaCategoria.Name = "TabPageListaCategoria";
            TabPageListaCategoria.Padding = new Padding(2, 3, 2, 3);
            TabPageListaCategoria.Size = new Size(705, 339);
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
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistroCategoria.ColumnHeadersHeight = 20;
            dgvRegistroCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroCategoria.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvRegistroCategoria.Dock = DockStyle.Fill;
            dgvRegistroCategoria.EnableHeadersVisualStyles = false;
            dgvRegistroCategoria.Location = new Point(2, 3);
            dgvRegistroCategoria.Margin = new Padding(2, 3, 2, 3);
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
            dgvRegistroCategoria.Size = new Size(701, 333);
            dgvRegistroCategoria.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripcion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // PanelRegCategoria
            // 
            PanelRegCategoria.BackColor = Color.Cornsilk;
            PanelRegCategoria.BackgroundImageLayout = ImageLayout.None;
            PanelRegCategoria.Controls.Add(BRegistrarCategoria);
            PanelRegCategoria.Controls.Add(TBNombreCategoria);
            PanelRegCategoria.Controls.Add(LNombreCategoria);
            PanelRegCategoria.Location = new Point(253, 39);
            PanelRegCategoria.Margin = new Padding(5, 4, 5, 4);
            PanelRegCategoria.Name = "PanelRegCategoria";
            PanelRegCategoria.Size = new Size(577, 177);
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
            BRegistrarCategoria.Location = new Point(424, 73);
            BRegistrarCategoria.Margin = new Padding(5, 4, 5, 4);
            BRegistrarCategoria.Name = "BRegistrarCategoria";
            BRegistrarCategoria.Size = new Size(130, 64);
            BRegistrarCategoria.TabIndex = 13;
            BRegistrarCategoria.Text = "Añadir";
            BRegistrarCategoria.UseVisualStyleBackColor = false;
            BRegistrarCategoria.Click += BRegistrarCategoria_Click;
            // 
            // TBNombreCategoria
            // 
            TBNombreCategoria.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreCategoria.Location = new Point(23, 88);
            TBNombreCategoria.Margin = new Padding(5, 4, 5, 4);
            TBNombreCategoria.Name = "TBNombreCategoria";
            TBNombreCategoria.Size = new Size(371, 30);
            TBNombreCategoria.TabIndex = 6;
            TBNombreCategoria.KeyPress += String_KeyPress;
            // 
            // LNombreCategoria
            // 
            LNombreCategoria.AutoSize = true;
            LNombreCategoria.BackColor = Color.Cornsilk;
            LNombreCategoria.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LNombreCategoria.ForeColor = Color.DarkOrange;
            LNombreCategoria.Location = new Point(23, 16);
            LNombreCategoria.Margin = new Padding(5, 0, 5, 0);
            LNombreCategoria.Name = "LNombreCategoria";
            LNombreCategoria.Size = new Size(313, 36);
            LNombreCategoria.TabIndex = 0;
            LNombreCategoria.Text = "Nombre de Categoria :";
            // 
            // AñadirCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1066, 769);
            Controls.Add(TabControlRegCategoria);
            Controls.Add(PanelRegCategoria);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "AñadirCategoria";
            Text = "Form1";
            TabControlRegCategoria.ResumeLayout(false);
            TabPageListaCategoria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroCategoria).EndInit();
            PanelRegCategoria.ResumeLayout(false);
            PanelRegCategoria.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegCategoria;
        internal TabPage TabPageListaCategoria;
        internal DataGridView dgvRegistroCategoria;
        internal Panel PanelRegCategoria;
        internal Button BRegistrarCategoria;
        internal TextBox TBNombreCategoria;
        internal Label LNombreCategoria;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}