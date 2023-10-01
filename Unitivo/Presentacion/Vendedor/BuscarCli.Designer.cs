using System.Diagnostics;

namespace Unitivo.Presentacion.Vendedor
{
    partial class BuscarCli
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

        // Requerido por el Diseñador de Windows Forms

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BVolver = new Button();
            BSeleccionar = new Button();
            TabControlListaClientes = new TabControl();
            TabPafeListaClientes = new TabPage();
            dgvListarCliente = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            TabControlListaClientes.SuspendLayout();
            TabPafeListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarCliente).BeginInit();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(366, 619);
            BVolver.Margin = new Padding(5, 4, 5, 4);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(142, 56);
            BVolver.TabIndex = 21;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BSeleccionar
            // 
            BSeleccionar.BackColor = Color.DarkOliveGreen;
            BSeleccionar.FlatAppearance.BorderSize = 2;
            BSeleccionar.FlatStyle = FlatStyle.Flat;
            BSeleccionar.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BSeleccionar.ForeColor = Color.Cornsilk;
            BSeleccionar.Location = new Point(566, 619);
            BSeleccionar.Margin = new Padding(5, 4, 5, 4);
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.Size = new Size(192, 56);
            BSeleccionar.TabIndex = 22;
            BSeleccionar.Text = "Seleccionar";
            BSeleccionar.TextAlign = ContentAlignment.TopCenter;
            BSeleccionar.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPafeListaClientes);
            TabControlListaClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(88, 47);
            TabControlListaClientes.Margin = new Padding(2, 3, 2, 3);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(895, 523);
            TabControlListaClientes.TabIndex = 23;
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
            TabPafeListaClientes.Size = new Size(887, 486);
            TabPafeListaClientes.TabIndex = 0;
            TabPafeListaClientes.Text = "Lista de Clientes";
            // 
            // dgvListarCliente
            // 
            dgvListarCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarCliente.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarCliente.BackgroundColor = Color.RosyBrown;
            dgvListarCliente.BorderStyle = BorderStyle.None;
            dgvListarCliente.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListarCliente.ColumnHeadersHeight = 20;
            dgvListarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarCliente.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, DNI, Telefono, Direccion });
            dgvListarCliente.Dock = DockStyle.Fill;
            dgvListarCliente.EnableHeadersVisualStyles = false;
            dgvListarCliente.Location = new Point(2, 3);
            dgvListarCliente.Margin = new Padding(5, 4, 5, 4);
            dgvListarCliente.Name = "dgvListarCliente";
            dgvListarCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvListarCliente.RowHeadersWidth = 51;
            dgvListarCliente.Size = new Size(883, 480);
            dgvListarCliente.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 6;
            Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            // 
            // BuscarCli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1066, 692);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BSeleccionar);
            Controls.Add(BVolver);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "BuscarCli";
            Text = "Form1";
            TabControlListaClientes.ResumeLayout(false);
            TabPafeListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarCliente).EndInit();
            ResumeLayout(false);
        }

        internal Button BVolver;
        internal Button BSeleccionar;
        internal TabControl TabControlListaClientes;
        internal TabPage TabPafeListaClientes;
        internal DataGridView dgvListarCliente;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Direccion;
    }

    #endregion
}
