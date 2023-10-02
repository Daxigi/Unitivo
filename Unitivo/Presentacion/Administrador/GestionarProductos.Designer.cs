namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarProductos
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
            BEliminarProducto = new Button();
            BModificarProducto = new Button();
            GroupBoxBuscarProducto = new GroupBox();
            comboBox3 = new ComboBox();
            ComboBox2 = new ComboBox();
            ComboBox1 = new ComboBox();
            BBuscarProducto = new Button();
            TBBuscar = new TextBox();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            SuspendLayout();
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.FlatAppearance.BorderSize = 2;
            BEliminarProducto.FlatStyle = FlatStyle.Flat;
            BEliminarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Properties.Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(970, 532);
            BEliminarProducto.Margin = new Padding(4, 5, 4, 5);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(67, 69);
            BEliminarProducto.TabIndex = 12;
            BEliminarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.SteelBlue;
            BModificarProducto.FlatAppearance.BorderColor = Color.White;
            BModificarProducto.FlatAppearance.BorderSize = 2;
            BModificarProducto.FlatStyle = FlatStyle.Flat;
            BModificarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(970, 415);
            BModificarProducto.Margin = new Padding(4, 5, 4, 5);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(67, 69);
            BModificarProducto.TabIndex = 13;
            BModificarProducto.UseVisualStyleBackColor = false;
            BModificarProducto.Click += BModificarProducto_Click;
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(comboBox3);
            GroupBoxBuscarProducto.Controls.Add(ComboBox2);
            GroupBoxBuscarProducto.Controls.Add(ComboBox1);
            GroupBoxBuscarProducto.Controls.Add(BBuscarProducto);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Britannic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(60, 88);
            GroupBoxBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Padding = new Padding(4, 5, 4, 5);
            GroupBoxBuscarProducto.Size = new Size(880, 125);
            GroupBoxBuscarProducto.TabIndex = 82;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Productos";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(681, 49);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(160, 30);
            comboBox3.TabIndex = 30;
            comboBox3.Text = "Talle";
            // 
            // ComboBox2
            // 
            ComboBox2.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Location = new Point(496, 49);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(160, 30);
            ComboBox2.TabIndex = 29;
            ComboBox2.Text = "Marcas";
            // 
            // ComboBox1
            // 
            ComboBox1.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(315, 49);
            ComboBox1.Margin = new Padding(5, 3, 3, 3);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(160, 30);
            ComboBox1.TabIndex = 28;
            ComboBox1.Text = "Categorias";
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.FlatAppearance.BorderColor = Color.White;
            BBuscarProducto.FlatAppearance.BorderSize = 2;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(225, 42);
            BBuscarProducto.Margin = new Padding(4, 5, 4, 5);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(53, 54);
            BBuscarProducto.TabIndex = 14;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(23, 54);
            TBBuscar.Margin = new Padding(4, 5, 4, 5);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(173, 30);
            TBBuscar.TabIndex = 6;
            TBBuscar.KeyPress += NumStr_KeyPress;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(40, 255);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(900, 452);
            TabControlListaProductos.TabIndex = 81;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 28);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(3);
            TabPageListaProducto.Size = new Size(892, 420);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Producto";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaProductos
            // 
            DataGridViewListaProductos.AllowUserToDeleteRows = false;
            DataGridViewListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaProductos.BackgroundColor = Color.RosyBrown;
            DataGridViewListaProductos.BorderStyle = BorderStyle.None;
            DataGridViewListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column1, Column4 });
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(3, 3);
            DataGridViewListaProductos.Margin = new Padding(4, 5, 4, 5);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(886, 414);
            DataGridViewListaProductos.TabIndex = 6;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Producto";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            Stock.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Talle";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // GestionarProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 846);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarProductos";
            Text = "Form1";
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            ResumeLayout(false);
        }

        internal Button BEliminarProducto;
        internal Button BModificarProducto;

        #endregion

        internal GroupBox GroupBoxBuscarProducto;
        internal ComboBox comboBox3;
        internal ComboBox ComboBox2;
        internal ComboBox ComboBox1;
        internal Button BBuscarProducto;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Categoria;
        internal DataGridViewTextBoxColumn Stock;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
    }
}