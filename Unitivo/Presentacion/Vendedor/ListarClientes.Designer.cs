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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarLC = new ComboBox();
            BEditarCliente = new Button();
            BImprimirClientes = new Button();
            TabControlListaClientes = new TabControl();
            TabPageListaCliente = new TabPage();
            DataGridViewListarClientes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarLC);
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
            TBBuscar.Location = new Point(260, 69);
            TBBuscar.Margin = new Padding(4, 5, 4, 5);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(220, 37);
            TBBuscar.TabIndex = 1;
            // 
            // ComboBoxBuscarLC
            // 
            ComboBoxBuscarLC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarLC.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarLC.FormattingEnabled = true;
            ComboBoxBuscarLC.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscarLC.Location = new Point(49, 74);
            ComboBoxBuscarLC.Margin = new Padding(4, 5, 4, 5);
            ComboBoxBuscarLC.Name = "ComboBoxBuscarLC";
            ComboBoxBuscarLC.Size = new Size(167, 33);
            ComboBoxBuscarLC.TabIndex = 0;
            ComboBoxBuscarLC.Text = "Buscar por:";
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.Goldenrod;
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCliente.Location = new Point(948, 458);
            BEditarCliente.Margin = new Padding(4, 5, 4, 5);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Size = new Size(67, 69);
            BEditarCliente.TabIndex = 4;
            BEditarCliente.UseVisualStyleBackColor = false;
            BEditarCliente.Click += BEditarCliente_Click;
            // 
            // BImprimirClientes
            // 
            BImprimirClientes.BackColor = Color.SteelBlue;
            BImprimirClientes.ForeColor = Color.White;
            BImprimirClientes.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirClientes.Location = new Point(948, 355);
            BImprimirClientes.Margin = new Padding(4, 5, 4, 5);
            BImprimirClientes.Name = "BImprimirClientes";
            BImprimirClientes.Size = new Size(67, 69);
            BImprimirClientes.TabIndex = 3;
            BImprimirClientes.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(79, 267);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(811, 306);
            TabControlListaClientes.TabIndex = 70;
            // 
            // TabPageListaCliente
            // 
            TabPageListaCliente.Controls.Add(DataGridViewListarClientes);
            TabPageListaCliente.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCliente.ForeColor = Color.White;
            TabPageListaCliente.Location = new Point(4, 28);
            TabPageListaCliente.Name = "TabPageListaCliente";
            TabPageListaCliente.Padding = new Padding(3);
            TabPageListaCliente.Size = new Size(803, 274);
            TabPageListaCliente.TabIndex = 0;
            TabPageListaCliente.Text = "Lista de Clientes";
            TabPageListaCliente.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarClientes
            // 
            DataGridViewListarClientes.AllowUserToAddRows = false;
            DataGridViewListarClientes.AllowUserToDeleteRows = false;
            DataGridViewListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            DataGridViewListarClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewListarClientes.BorderStyle = BorderStyle.None;
            DataGridViewListarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle4.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewListarClientes.ColumnHeadersHeight = 20;
            DataGridViewListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            DataGridViewListarClientes.DefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 3);
            DataGridViewListarClientes.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle6.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.Size = new Size(797, 268);
            DataGridViewListarClientes.TabIndex = 6;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
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
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
        }

        internal Button BImprimirClientes;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarLC;
        internal TabPage TabPageListaClientes;
        internal DataGridView DgvListarClientes;
        internal Button BEditarCliente;
        internal Button BVolver;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaCliente;
        internal DataGridView DataGridViewListarClientes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }

    #endregion
}
