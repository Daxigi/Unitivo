namespace Unitivo.Presentacion.Vendedor
{
    partial class ListarClientes
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            BEditarCliente = new Button();
            BImprimirClientes = new Button();
            TabControlListaClientes = new TabControl();
            TabPafeListaClientes = new TabPage();
            dgvListarCliente = new DataGridView();
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPafeListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarCliente).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(208, 51);
            GroupBoxClientes.Margin = new Padding(5, 4, 5, 4);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(5, 4, 5, 4);
            GroupBoxClientes.Size = new Size(617, 153);
            GroupBoxClientes.TabIndex = 0;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(518, 63);
            BBuscar.Margin = new Padding(5, 4, 5, 4);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(59, 61);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            BBuscar.Click += BBuscar_Click;
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(259, 69);
            TBBuscar.Margin = new Padding(5, 4, 5, 4);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(220, 37);
            TBBuscar.TabIndex = 1;
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Location = new Point(58, 72);
            ComboBoxBuscarDni.Margin = new Padding(5, 4, 5, 4);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(159, 33);
            ComboBoxBuscarDni.TabIndex = 0;
            ComboBoxBuscarDni.Text = "DNI";
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.Goldenrod;
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCliente.Location = new Point(929, 479);
            BEditarCliente.Margin = new Padding(5, 4, 5, 4);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Size = new Size(66, 69);
            BEditarCliente.TabIndex = 4;
            BEditarCliente.UseVisualStyleBackColor = false;
            // 
            // BImprimirClientes
            // 
            BImprimirClientes.BackColor = Color.SteelBlue;
            BImprimirClientes.ForeColor = Color.White;
            BImprimirClientes.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirClientes.Location = new Point(929, 376);
            BImprimirClientes.Margin = new Padding(5, 4, 5, 4);
            BImprimirClientes.Name = "BImprimirClientes";
            BImprimirClientes.Size = new Size(66, 69);
            BImprimirClientes.TabIndex = 3;
            BImprimirClientes.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPafeListaClientes);
            TabControlListaClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(153, 211);
            TabControlListaClientes.Margin = new Padding(2, 3, 2, 3);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(739, 396);
            TabControlListaClientes.TabIndex = 24;
            // 
            // TabPafeListaClientes
            // 
            TabPafeListaClientes.BackColor = Color.FromArgb(31, 31, 69);
            TabPafeListaClientes.Controls.Add(dgvListarCliente);
            TabPafeListaClientes.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TabPafeListaClientes.ForeColor = Color.White;
            TabPafeListaClientes.Location = new Point(4, 33);
            TabPafeListaClientes.Margin = new Padding(2, 3, 2, 3);
            TabPafeListaClientes.Name = "TabPafeListaClientes";
            TabPafeListaClientes.Padding = new Padding(2, 3, 2, 3);
            TabPafeListaClientes.Size = new Size(731, 359);
            TabPafeListaClientes.TabIndex = 0;
            TabPafeListaClientes.Text = "Lista de Clientes";
            // 
            // dgvListarCliente
            // 
            dgvListarCliente.AllowUserToAddRows = false;
            dgvListarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarCliente.BackgroundColor = Color.RosyBrown;
            dgvListarCliente.BorderStyle = BorderStyle.None;
            dgvListarCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListarCliente.ColumnHeadersHeight = 20;
            dgvListarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarCliente.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn2, Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarCliente.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListarCliente.Dock = DockStyle.Fill;
            dgvListarCliente.EnableHeadersVisualStyles = false;
            dgvListarCliente.Location = new Point(2, 3);
            dgvListarCliente.Margin = new Padding(5, 4, 5, 4);
            dgvListarCliente.Name = "dgvListarCliente";
            dgvListarCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListarCliente.RowHeadersWidth = 51;
            dgvListarCliente.Size = new Size(727, 353);
            dgvListarCliente.TabIndex = 7;
            // 
            // DataGridViewTextBoxColumn2
            // 
            DataGridViewTextBoxColumn2.HeaderText = "ID";
            DataGridViewTextBoxColumn2.MinimumWidth = 6;
            DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "DNI";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Telefono";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Dirección";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1066, 692);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BEditarCliente);
            Controls.Add(BImprimirClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "ListarClientes";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPafeListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarCliente).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView dgvListarClientes;
        internal Button BImprimirClientes;
        internal Button BEditarCliente;
        internal Button BVolver;
        internal TabPage TabPafeListaClientes;
        internal DataGridView dgvListarCliente;
        internal DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Column5;
    }

    #endregion
}
