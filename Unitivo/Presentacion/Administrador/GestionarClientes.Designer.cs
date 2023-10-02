﻿namespace Unitivo.Presentacion.Administrador
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BModificarCliente = new Button();
            BImprimirClientes = new Button();
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            BEliminarClientes = new Button();
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
            // BModificarCliente
            // 
            BModificarCliente.BackColor = Color.Goldenrod;
            BModificarCliente.ForeColor = Color.White;
            BModificarCliente.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarCliente.Location = new Point(945, 472);
            BModificarCliente.Margin = new Padding(4, 5, 4, 5);
            BModificarCliente.Name = "BModificarCliente";
            BModificarCliente.Size = new Size(67, 69);
            BModificarCliente.TabIndex = 23;
            BModificarCliente.UseVisualStyleBackColor = false;
            BModificarCliente.Click += BModificarCliente_Click;
            // 
            // BImprimirClientes
            // 
            BImprimirClientes.BackColor = Color.SteelBlue;
            BImprimirClientes.ForeColor = Color.White;
            BImprimirClientes.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirClientes.Location = new Point(945, 378);
            BImprimirClientes.Margin = new Padding(4, 5, 4, 5);
            BImprimirClientes.Name = "BImprimirClientes";
            BImprimirClientes.Size = new Size(67, 69);
            BImprimirClientes.TabIndex = 22;
            BImprimirClientes.UseVisualStyleBackColor = false;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(212, 55);
            GroupBoxClientes.Margin = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Size = new Size(617, 154);
            GroupBoxClientes.TabIndex = 20;
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
            TBBuscar.KeyPress += NumStr_KeyPress;
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
            // BEliminarClientes
            // 
            BEliminarClientes.BackColor = Color.Brown;
            BEliminarClientes.FlatAppearance.BorderSize = 2;
            BEliminarClientes.FlatStyle = FlatStyle.Flat;
            BEliminarClientes.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarClientes.ForeColor = Color.White;
            BEliminarClientes.Image = Properties.Resources.icons8_basura_26;
            BEliminarClientes.Location = new Point(945, 567);
            BEliminarClientes.Margin = new Padding(4, 5, 4, 5);
            BEliminarClientes.Name = "BEliminarClientes";
            BEliminarClientes.Size = new Size(67, 69);
            BEliminarClientes.TabIndex = 25;
            BEliminarClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarClientes.UseVisualStyleBackColor = false;
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaCliente);
            TabControlListaClientes.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(75, 254);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(811, 458);
            TabControlListaClientes.TabIndex = 71;
            // 
            // TabPageListaCliente
            // 
            TabPageListaCliente.Controls.Add(DataGridViewListarClientes);
            TabPageListaCliente.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaCliente.ForeColor = Color.White;
            TabPageListaCliente.Location = new Point(4, 28);
            TabPageListaCliente.Name = "TabPageListaCliente";
            TabPageListaCliente.Padding = new Padding(3);
            TabPageListaCliente.Size = new Size(803, 426);
            TabPageListaCliente.TabIndex = 0;
            TabPageListaCliente.Text = "Lista de Clientes";
            TabPageListaCliente.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarClientes
            // 
            DataGridViewListarClientes.AllowUserToAddRows = false;
            DataGridViewListarClientes.AllowUserToDeleteRows = false;
            DataGridViewListarClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewListarClientes.BorderStyle = BorderStyle.None;
            DataGridViewListarClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListarClientes.ColumnHeadersHeight = 20;
            DataGridViewListarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarClientes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            DataGridViewListarClientes.Dock = DockStyle.Fill;
            DataGridViewListarClientes.EnableHeadersVisualStyles = false;
            DataGridViewListarClientes.Location = new Point(3, 3);
            DataGridViewListarClientes.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListarClientes.Name = "DataGridViewListarClientes";
            DataGridViewListarClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListarClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListarClientes.RowHeadersWidth = 51;
            DataGridViewListarClientes.Size = new Size(797, 420);
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
            // GestionarClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 769);
            Controls.Add(TabControlListaClientes);
            Controls.Add(BEliminarClientes);
            Controls.Add(BModificarCliente);
            Controls.Add(BImprimirClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarClientes";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaCliente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarClientes).EndInit();
            ResumeLayout(false);
        }

        internal Button BModificarCliente;
        internal Button BImprimirClientes;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        internal Button BEliminarClientes;

        #endregion

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
}