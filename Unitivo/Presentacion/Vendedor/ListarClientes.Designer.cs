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
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            TabControlListaClientes = new TabControl();
            TabPageListaClientes = new TabPage();
            DgvListarClientes = new DataGridView();
            BEditarCliente = new Button();
            BImprimirClientes = new Button();
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(208, 51);
            GroupBoxClientes.Margin = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Size = new Size(617, 154);
            GroupBoxClientes.TabIndex = 0;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(517, 63);
            BBuscar.Margin = new Padding(4, 5, 4, 5);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(60, 62);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(260, 69);
            TBBuscar.Margin = new Padding(4, 5, 4, 5);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(220, 38);
            TBBuscar.TabIndex = 1;
            TBBuscar.KeyPress += Num_KeyPress;
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Location = new Point(59, 72);
            ComboBoxBuscarDni.Margin = new Padding(4, 5, 4, 5);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(160, 31);
            ComboBoxBuscarDni.TabIndex = 0;
            ComboBoxBuscarDni.Text = "DNI";
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaClientes);
            TabControlListaClientes.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(128, 254);
            TabControlListaClientes.Margin = new Padding(4, 5, 4, 5);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(780, 331);
            TabControlListaClientes.TabIndex = 1;
            // 
            // TabPageListaClientes
            // 
            TabPageListaClientes.Controls.Add(DgvListarClientes);
            TabPageListaClientes.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaClientes.Location = new Point(4, 30);
            TabPageListaClientes.Margin = new Padding(4, 5, 4, 5);
            TabPageListaClientes.Name = "TabPageListaClientes";
            TabPageListaClientes.Padding = new Padding(4, 5, 4, 5);
            TabPageListaClientes.Size = new Size(772, 297);
            TabPageListaClientes.TabIndex = 0;
            TabPageListaClientes.Text = "Lista de Clientes";
            TabPageListaClientes.UseVisualStyleBackColor = true;
            // 
            // DgvListarClientes
            // 
            DgvListarClientes.BackgroundColor = Color.RosyBrown;
            DgvListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvListarClientes.Dock = DockStyle.Fill;
            DgvListarClientes.Location = new Point(4, 5);
            DgvListarClientes.Margin = new Padding(4, 5, 4, 5);
            DgvListarClientes.Name = "DgvListarClientes";
            DgvListarClientes.RowHeadersWidth = 51;
            DgvListarClientes.Size = new Size(764, 287);
            DgvListarClientes.TabIndex = 0;
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
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 692);
            Controls.Add(BEditarCliente);
            Controls.Add(BImprimirClientes);
            Controls.Add(TabControlListaClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ListarClientes";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView DgvListarClientes;
        internal Button BEditarCliente;
        internal Button BImprimirClientes;
    }

    #endregion
}
