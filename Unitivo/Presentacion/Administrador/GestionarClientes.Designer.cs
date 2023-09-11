namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarClientes
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
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            BEditarCliente = new Button();
            BImprimirClientes = new Button();
            TabControlListaClientes = new TabControl();
            TabPageListaClientes = new TabPage();
            dgvListarClientes = new DataGridView();
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            BEliminarClientes = new Button();
            //BEliminarClientes.Click += new EventHandler(BEliminarClientes_Click);
            TabControlListaClientes.SuspendLayout();
            TabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarClientes).BeginInit();
            GroupBoxClientes.SuspendLayout();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(559, 440);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 24;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BEditarCliente
            // 
            BEditarCliente.BackColor = Color.Goldenrod;
            BEditarCliente.ForeColor = Color.White;
            BEditarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BEditarCliente.Location = new Point(705, 286);
            BEditarCliente.Name = "BEditarCliente";
            BEditarCliente.Size = new Size(50, 45);
            BEditarCliente.TabIndex = 23;
            BEditarCliente.UseVisualStyleBackColor = false;
            // 
            // BImprimirClientes
            // 
            BImprimirClientes.BackColor = Color.SteelBlue;
            BImprimirClientes.ForeColor = Color.White;
            BImprimirClientes.Image =   Properties.Resources.icons8_imprimir_26;
            BImprimirClientes.Location = new Point(705, 225);
            BImprimirClientes.Name = "BImprimirClientes";
            BImprimirClientes.Size = new Size(50, 45);
            BImprimirClientes.TabIndex = 22;
            BImprimirClientes.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaClientes);
            TabControlListaClientes.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaClientes.Location = new Point(80, 164);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(585, 256);
            TabControlListaClientes.TabIndex = 21;
            // 
            // TabPageListaClientes
            // 
            TabPageListaClientes.Controls.Add(dgvListarClientes);
            TabPageListaClientes.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaClientes.Location = new Point(4, 25);
            TabPageListaClientes.Name = "TabPageListaClientes";
            TabPageListaClientes.Padding = new Padding(3);
            TabPageListaClientes.Size = new Size(577, 227);
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
            dgvListarClientes.Size = new Size(571, 221);
            dgvListarClientes.TabIndex = 0;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(159, 36);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Size = new Size(463, 100);
            GroupBoxClientes.TabIndex = 20;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
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
            // BEliminarClientes
            // 
            BEliminarClientes.BackColor = Color.Brown;
            BEliminarClientes.FlatAppearance.BorderSize = 2;
            BEliminarClientes.FlatStyle = FlatStyle.Flat;
            BEliminarClientes.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEliminarClientes.ForeColor = Color.White;
            BEliminarClientes.Image = Properties.Resources.icons8_basura_26;
            BEliminarClientes.Location = new Point(705, 348);
            BEliminarClientes.Name = "BEliminarClientes";
            BEliminarClientes.Size = new Size(50, 45);
            BEliminarClientes.TabIndex = 25;
            BEliminarClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarClientes.UseVisualStyleBackColor = false;
            // 
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 500);
            Controls.Add(BEliminarClientes);
            Controls.Add(BVolver);
            Controls.Add(BEditarCliente);
            Controls.Add(BImprimirClientes);
            Controls.Add(TabControlListaClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarClientes";
            Text = "Form1";
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarClientes).EndInit();
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal Button BEditarCliente;
        internal Button BImprimirClientes;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView dgvListarClientes;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        internal Button BEliminarClientes;

        #endregion
    }
}