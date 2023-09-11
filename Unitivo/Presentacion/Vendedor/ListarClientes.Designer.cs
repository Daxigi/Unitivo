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
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            TabControlListaClientes = new TabControl();
            TabPageListaClientes = new TabPage();
            dgvListarClientes = new DataGridView();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            BEditarCliente = new Button();
            BImprimirClientes = new Button();
            BBuscar = new Button();
            GroupBoxClientes.SuspendLayout();
            TabControlListaClientes.SuspendLayout();
            TabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarClientes).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(156, 33);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Size = new Size(463, 100);
            GroupBoxClientes.TabIndex = 0;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // TBBuscar
            // 
            TBBuscar.Location = new Point(195, 45);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(166, 32);
            TBBuscar.TabIndex = 1;
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Location = new Point(44, 47);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(121, 27);
            ComboBoxBuscarDni.TabIndex = 0;
            ComboBoxBuscarDni.Text = "DNI";
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaClientes);
            TabControlListaClientes.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaClientes.Location = new Point(96, 165);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(585, 215);
            TabControlListaClientes.TabIndex = 1;
            // 
            // TabPageListaClientes
            // 
            TabPageListaClientes.Controls.Add(dgvListarClientes);
            TabPageListaClientes.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaClientes.Location = new Point(4, 25);
            TabPageListaClientes.Name = "TabPageListaClientes";
            TabPageListaClientes.Padding = new Padding(3);
            TabPageListaClientes.Size = new Size(577, 186);
            TabPageListaClientes.TabIndex = 0;
            TabPageListaClientes.Text = "Lista de Clientes";
            TabPageListaClientes.UseVisualStyleBackColor = true;
            // 
            // dgvListarClientes
            // 
            dgvListarClientes.BackgroundColor = Color.RosyBrown;
            dgvListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarClientes.Dock = DockStyle.Fill;
            dgvListarClientes.Location = new Point(3, 3);
            dgvListarClientes.Name = "dgvListarClientes";
            dgvListarClientes.Size = new Size(571, 180);
            dgvListarClientes.TabIndex = 0;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(575, 396);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 19;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.Goldenrod;
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCliente.Location = new Point(697, 311);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Size = new Size(50, 45);
            BEditarCliente.TabIndex = 4;
            BEditarCliente.UseVisualStyleBackColor = false;
            // 
            // BImprimirClientes
            // 
            BImprimirClientes.BackColor = Color.SteelBlue;
            BImprimirClientes.ForeColor = Color.White;
            BImprimirClientes.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirClientes.Location = new Point(697, 244);
            BImprimirClientes.Name = "BImprimirClientes";
            BImprimirClientes.Size = new Size(50, 45);
            BImprimirClientes.TabIndex = 3;
            BImprimirClientes.UseVisualStyleBackColor = false;
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(388, 41);
            BBuscar.Name = "BBuscar";
            BBuscar.Size = new Size(45, 40);
            BBuscar.TabIndex = 2;
            BBuscar.UseVisualStyleBackColor = false;
            // 
            // ListarClientes
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BVolver);
            Controls.Add(BEditarCliente);
            Controls.Add(BImprimirClientes);
            Controls.Add(TabControlListaClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarClientes";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarClientes).EndInit();
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
    }

    #endregion
}
