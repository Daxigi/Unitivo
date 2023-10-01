namespace Unitivo.Presentacion.Vendedor
{
    partial class BuscarCliente
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
            TabControlListaClientes = new TabControl();
            TabPageListaClientes = new TabPage();
            DgvListarClientes = new DataGridView();
            GroupBoxClientes = new GroupBox();
            BBuscar = new Button();
            TBBuscar = new TextBox();
            ComboBoxBuscarDni = new ComboBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            BSeleccionar = new Button();
            BCancelar = new Button();
            TabControlListaClientes.SuspendLayout();
            TabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).BeginInit();
            GroupBoxClientes.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlListaClientes
            // 
            TabControlListaClientes.Controls.Add(TabPageListaClientes);
            TabControlListaClientes.Font = new Font("Britannic Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaClientes.Location = new Point(30, 206);
            TabControlListaClientes.Margin = new Padding(4, 5, 4, 5);
            TabControlListaClientes.Name = "TabControlListaClientes";
            TabControlListaClientes.SelectedIndex = 0;
            TabControlListaClientes.Size = new Size(780, 331);
            TabControlListaClientes.TabIndex = 3;
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
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.FloralWhite;
            GroupBoxClientes.Controls.Add(BBuscar);
            GroupBoxClientes.Controls.Add(TBBuscar);
            GroupBoxClientes.Controls.Add(ComboBoxBuscarDni);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxClientes.ForeColor = Color.DarkOrange;
            GroupBoxClientes.Location = new Point(105, 30);
            GroupBoxClientes.Margin = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Padding = new Padding(4, 5, 4, 5);
            GroupBoxClientes.Size = new Size(617, 154);
            GroupBoxClientes.TabIndex = 2;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // BBuscar
            // 
            BBuscar.BackColor = Color.DarkOliveGreen;
            BBuscar.ForeColor = Color.White;
            BBuscar.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscar.Location = new Point(526, 56);
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
            // panel1
            // 
            panel1.BackColor = Color.DarkOliveGreen;
            panel1.Location = new Point(0, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 624);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Location = new Point(831, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 622);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkOliveGreen;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(841, 10);
            panel3.TabIndex = 6;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkOliveGreen;
            panel4.Location = new Point(0, 623);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 10);
            panel4.TabIndex = 7;
            // 
            // BSeleccionar
            // 
            BSeleccionar.BackColor = Color.DarkOliveGreen;
            BSeleccionar.FlatAppearance.BorderSize = 2;
            BSeleccionar.FlatStyle = FlatStyle.Flat;
            BSeleccionar.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BSeleccionar.ForeColor = Color.Cornsilk;
            BSeleccionar.Location = new Point(445, 559);
            BSeleccionar.Margin = new Padding(4, 5, 4, 5);
            BSeleccionar.Name = "BSeleccionar";
            BSeleccionar.Size = new Size(181, 41);
            BSeleccionar.TabIndex = 67;
            BSeleccionar.Text = "Seleccionar";
            BSeleccionar.UseVisualStyleBackColor = false;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Cooper Black", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.Cornsilk;
            BCancelar.Location = new Point(217, 559);
            BCancelar.Margin = new Padding(4, 5, 4, 5);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(181, 41);
            BCancelar.TabIndex = 68;
            BCancelar.Text = "Cancelar";
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(840, 634);
            ControlBox = false;
            Controls.Add(BCancelar);
            Controls.Add(BSeleccionar);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(TabControlListaClientes);
            Controls.Add(GroupBoxClientes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BuscarCliente";
            Text = "Form1";
            TabControlListaClientes.ResumeLayout(false);
            TabPageListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvListarClientes).EndInit();
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal TabControl TabControlListaClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView DgvListarClientes;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscar;
        internal TextBox TBBuscar;
        internal ComboBox ComboBoxBuscarDni;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        internal Button BSeleccionar;
        internal Button BCancelar;
    }
}