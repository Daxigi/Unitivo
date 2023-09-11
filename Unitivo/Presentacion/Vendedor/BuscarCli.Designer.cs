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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            BSeleccionar = new Button();
            TabControlListaClientes = new TabControl();
            TabPafeListaClientes = new TabPage();
            dgvListarCliente = new DataGridView();
           // dgvListarCliente.CellContentClick += new DataGridViewCellEventHandler(dgvListarCliente_CellContentClick);
            DataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
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
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(274, 402);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 36);
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
            BSeleccionar.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BSeleccionar.ForeColor = Color.Cornsilk;
            BSeleccionar.Location = new Point(424, 402);
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.Size = new Size(144, 36);
            BSeleccionar.TabIndex = 22;
            BSeleccionar.Text = "Seleccionar";
            BSeleccionar.TextAlign = ContentAlignment.TopCenter;
            BSeleccionar.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPafeListaClientes);
            TabControlListaClientes.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaClientes.Location = new Point(66, 30);
            TabControlListaClientes.Margin = new Padding(2);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(671, 340);
            TabControlListaClientes.TabIndex = 23;
            // 
            // TabPafeListaClientes
            // 
            TabPafeListaClientes.BackColor = Color.FromArgb(31, 31, 69);
            TabPafeListaClientes.Controls.Add(dgvListarCliente);
            TabPafeListaClientes.Font = new Font("Britannic Bold", 12.0f);
            TabPafeListaClientes.ForeColor = Color.White;
            TabPafeListaClientes.Location = new Point(4, 25);
            TabPafeListaClientes.Margin = new Padding(2);
            TabPafeListaClientes.Name = "TabPafeListaClientes";
            TabPafeListaClientes.Padding = new Padding(2);
            TabPafeListaClientes.Size = new Size(663, 311);
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
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle3.Font = new Font("Britannic Bold", 12.0f);
            DataGridViewCellStyle3.ForeColor = SystemColors.Window;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            dgvListarCliente.ColumnHeadersHeight = 20;
            dgvListarCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarCliente.Columns.AddRange(new DataGridViewColumn[] { DataGridViewTextBoxColumn2, Column1, Column2, Column3, Column4, Column5 });
            dgvListarCliente.Dock = DockStyle.Fill;
            dgvListarCliente.EnableHeadersVisualStyles = false;
            dgvListarCliente.Location = new Point(2, 2);
            dgvListarCliente.Name = "dgvListarCliente";
            dgvListarCliente.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.NavajoWhite;
            DataGridViewCellStyle4.Font = new Font("Britannic Bold", 12.0f);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListarCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dgvListarCliente.RowHeadersWidth = 51;
            dgvListarCliente.Size = new Size(659, 307);
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
            // BuscarCli
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BSeleccionar);
            Controls.Add(BVolver);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscarCli";
            Text = "Form1";
            TabControlListaClientes.ResumeLayout(false);
            TabPafeListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarCliente).EndInit();
            //Load += new EventHandler(BuscarCli_Load);
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal Button BSeleccionar;
        internal TabControl TabControlListaClientes;
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
