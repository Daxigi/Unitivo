namespace Unitivo.Presentacion.Vendedor
{
    partial class ListarProductos
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            GroupBoxBuscarProducto = new GroupBox();
            ComboBox2 = new ComboBox();
            ComboBox1 = new ComboBox();
            BImprimriVentedores = new Button();
            BBuscarProducto = new Button();
            TBBuscar = new TextBox();
            //TBBuscar.KeyPress += new KeyPressEventHandler(TBBuscar_KeyPress);
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            //DataGridViewListaProductos.CellContentClick += new DataGridViewCellEventHandler(DataGridViewListaProductos_CellContentClick);
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
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
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(ComboBox2);
            GroupBoxBuscarProducto.Controls.Add(ComboBox1);
            GroupBoxBuscarProducto.Controls.Add(BImprimriVentedores);
            GroupBoxBuscarProducto.Controls.Add(BBuscarProducto);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Britannic Bold", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(82, 24);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Size = new Size(660, 81);
            GroupBoxBuscarProducto.TabIndex = 19;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Productos";
            // 
            // ComboBox2
            // 
            ComboBox2.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox2.FormattingEnabled = true;
            ComboBox2.Location = new Point(372, 32);
            ComboBox2.Margin = new Padding(2);
            ComboBox2.Name = "ComboBox2";
            ComboBox2.Size = new Size(121, 25);
            ComboBox2.TabIndex = 29;
            ComboBox2.Text = "Marcas";
            // 
            // ComboBox1
            // 
            ComboBox1.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(236, 32);
            ComboBox1.Margin = new Padding(4, 2, 2, 2);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(121, 25);
            ComboBox1.TabIndex = 28;
            ComboBox1.Text = "Categorias";
            // 
            // BImprimriVentedores
            // 
            BImprimriVentedores.BackColor = Color.SteelBlue;
            BImprimriVentedores.FlatAppearance.BorderSize = 2;
            BImprimriVentedores.FlatStyle = FlatStyle.Flat;
            BImprimriVentedores.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BImprimriVentedores.ForeColor = Color.White;
            BImprimriVentedores.Image = Properties.Resources.icons8_imprimir_26;
            BImprimriVentedores.Location = new Point(575, 24);
            BImprimriVentedores.Name = "BImprimriVentedores";
            BImprimriVentedores.Size = new Size(49, 41);
            BImprimriVentedores.TabIndex = 26;
            BImprimriVentedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BImprimriVentedores.UseVisualStyleBackColor = false;
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.FlatAppearance.BorderColor = Color.White;
            BBuscarProducto.FlatAppearance.BorderSize = 2;
            BBuscarProducto.FlatStyle = FlatStyle.Flat;
            BBuscarProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(165, 30);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(40, 35);
            BBuscarProducto.TabIndex = 14;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Britannic Bold", 12.0f);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(17, 35);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(131, 25);
            TBBuscar.TabIndex = 6;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaProductos.Location = new Point(47, 123);
            TabControlListaProductos.Margin = new Padding(2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(719, 294);
            TabControlListaProductos.TabIndex = 18;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 25);
            TabPageListaProducto.Margin = new Padding(2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(2);
            TabPageListaProducto.Size = new Size(711, 265);
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
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = SystemColors.Window;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column1, Column4 });
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(2, 2);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(707, 261);
            DataGridViewListaProductos.TabIndex = 6;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(642, 430);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(124, 38);
            BVolver.TabIndex = 70;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
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
            // ListarProductos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 480);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarProductos";
            Text = "Form1";
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            //Load += new EventHandler(ListarProductos_Load);
            ResumeLayout(false);

        }

        internal GroupBox GroupBoxBuscarProducto;
        internal ComboBox ComboBox2;
        internal ComboBox ComboBox1;
        internal Button BImprimriVentedores;
        internal Button BBuscarProducto;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;
        internal Button BVolver;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Categoria;
        internal DataGridViewTextBoxColumn Stock;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;

        #endregion
    }
}