namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirProducto
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
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            var DataGridViewCellStyle9 = new DataGridViewCellStyle();
            var DataGridViewCellStyle10 = new DataGridViewCellStyle();
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            DataGridViewRegistroCategorias = new DataGridView();
            Label1 = new Label();
            Panel2 = new Panel();
            CBCategoria = new ComboBox();
            BAñadirProducto = new Button();
            //BAñadirProducto.Click += new EventHandler(BAñadirProducto_Click);
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            //BVolver.Click += new EventHandler(BVolver_Click);
            CBMarca = new ComboBox();
            LMarca = new Label();
            CBTalle = new ComboBox();
            Label6 = new Label();
            Label3 = new Label();
            TBNombreProducto = new TextBox();
            //TBNombreProducto.KeyPress += new KeyPressEventHandler(TBNombreProducto_KeyPress);
            Label2 = new Label();
            Label5 = new Label();
            TBPrecio = new TextBox();
            //TBPrecio.KeyPress += new KeyPressEventHandler(TBPrecio_KeyPress);
            Label4 = new Label();
            TBStock = new TextBox();
            //TBStock.KeyPress += new KeyPressEventHandler(TBPrecio_KeyPress);
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).BeginInit();
            Panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaProductos.Location = new Point(319, 26);
            TabControlListaProductos.Margin = new Padding(2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(476, 423);
            TabControlListaProductos.TabIndex = 17;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Controls.Add(DataGridViewRegistroCategorias);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 25);
            TabPageListaProducto.Margin = new Padding(2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(2);
            TabPageListaProducto.Size = new Size(468, 394);
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
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.ForeColor = SystemColors.Window;
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column4, Talle });
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(2, 2);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle8.BackColor = Color.NavajoWhite;
            DataGridViewCellStyle8.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(464, 390);
            DataGridViewListaProductos.TabIndex = 7;
            // 
            // DataGridViewRegistroCategorias
            // 
            DataGridViewRegistroCategorias.AllowUserToAddRows = false;
            DataGridViewRegistroCategorias.AllowUserToDeleteRows = false;
            DataGridViewRegistroCategorias.BackgroundColor = Color.FromArgb(31, 31, 69);
            DataGridViewRegistroCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle9.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle9.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle9.ForeColor = Color.White;
            DataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9;
            DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle10.BackColor = SystemColors.Window;
            DataGridViewCellStyle10.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle10.ForeColor = Color.White;
            DataGridViewCellStyle10.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DataGridViewRegistroCategorias.DefaultCellStyle = DataGridViewCellStyle10;
            DataGridViewRegistroCategorias.Dock = DockStyle.Fill;
            DataGridViewRegistroCategorias.EnableHeadersVisualStyles = false;
            DataGridViewRegistroCategorias.Location = new Point(2, 2);
            DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias";
            DataGridViewRegistroCategorias.ReadOnly = true;
            DataGridViewRegistroCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle11.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle11;
            DataGridViewRegistroCategorias.RowHeadersWidth = 51;
            DataGridViewCellStyle12.ForeColor = Color.Black;
            DataGridViewRegistroCategorias.RowsDefaultCellStyle = DataGridViewCellStyle12;
            DataGridViewRegistroCategorias.Size = new Size(464, 390);
            DataGridViewRegistroCategorias.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 20.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(24, 25);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(260, 31);
            Label1.TabIndex = 15;
            Label1.Text = "Añadir Producto :";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Cornsilk;
            Panel2.Controls.Add(CBCategoria);
            Panel2.Controls.Add(BAñadirProducto);
            Panel2.Controls.Add(BVolver);
            Panel2.Controls.Add(CBMarca);
            Panel2.Controls.Add(LMarca);
            Panel2.Controls.Add(CBTalle);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(TBNombreProducto);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(TBPrecio);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(TBStock);
            Panel2.Location = new Point(26, 74);
            Panel2.Margin = new Padding(2);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(254, 382);
            Panel2.TabIndex = 16;
            // 
            // CBCategoria
            // 
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(103, 85);
            CBCategoria.Margin = new Padding(2);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(132, 21);
            CBCategoria.TabIndex = 15;
            // 
            // BAñadirProducto
            // 
            BAñadirProducto.BackColor = Color.DarkOliveGreen;
            BAñadirProducto.Font = new Font("Britannic Bold", 13.0f);
            BAñadirProducto.ForeColor = Color.White;
            BAñadirProducto.Location = new Point(144, 323);
            BAñadirProducto.Margin = new Padding(2);
            BAñadirProducto.Name = "BAñadirProducto";
            BAñadirProducto.Size = new Size(90, 41);
            BAñadirProducto.TabIndex = 2;
            BAñadirProducto.Text = "Añadir";
            BAñadirProducto.UseVisualStyleBackColor = false;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.Font = new Font("Britannic Bold", 13.0f);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(25, 323);
            BVolver.Margin = new Padding(2);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(92, 41);
            BVolver.TabIndex = 3;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // CBMarca
            // 
            CBMarca.FormattingEnabled = true;
            CBMarca.Location = new Point(103, 246);
            CBMarca.Margin = new Padding(2);
            CBMarca.Name = "CBMarca";
            CBMarca.Size = new Size(132, 21);
            CBMarca.TabIndex = 14;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.BackColor = Color.Cornsilk;
            LMarca.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LMarca.ForeColor = Color.SaddleBrown;
            LMarca.Location = new Point(13, 247);
            LMarca.Margin = new Padding(4, 0, 4, 0);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(72, 21);
            LMarca.TabIndex = 13;
            LMarca.Text = "Marca: ";
            // 
            // CBTalle
            // 
            CBTalle.FormattingEnabled = true;
            CBTalle.Location = new Point(103, 207);
            CBTalle.Margin = new Padding(2);
            CBTalle.Name = "CBTalle";
            CBTalle.Size = new Size(132, 21);
            CBTalle.TabIndex = 11;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Cornsilk;
            Label6.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(11, 208);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(60, 21);
            Label6.TabIndex = 10;
            Label6.Text = "Talle: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Cornsilk;
            Label3.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(11, 84);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(101, 21);
            Label3.TabIndex = 1;
            Label3.Text = "Categoría: ";
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Location = new Point(103, 46);
            TBNombreProducto.Margin = new Padding(4);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(132, 20);
            TBNombreProducto.TabIndex = 5;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Cornsilk;
            Label2.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(11, 44);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(79, 21);
            Label2.TabIndex = 0;
            Label2.Text = "Nombre:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Cornsilk;
            Label5.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(11, 167);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(73, 21);
            Label5.TabIndex = 3;
            Label5.Text = "Precio: ";
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(103, 168);
            TBPrecio.Margin = new Padding(4);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(132, 20);
            TBPrecio.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Cornsilk;
            Label4.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(11, 126);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(60, 21);
            Label4.TabIndex = 2;
            Label4.Text = "Stock:";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(103, 127);
            TBStock.Margin = new Padding(4);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(132, 20);
            TBStock.TabIndex = 7;
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
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // AñadirProducto
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 500);
            Controls.Add(TabControlListaProductos);
            Controls.Add(Label1);
            Controls.Add(Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirProducto";
            Text = "Form1";
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaProductos;
        internal DataGridView DataGridViewRegistroCategorias;
        internal Label Label1;
        internal Panel Panel2;
        internal ComboBox CBCategoria;
        internal Button BAñadirProducto;
        internal Button BVolver;
        internal ComboBox CBMarca;
        internal Label LMarca;
        internal ComboBox CBTalle;
        internal Label Label6;
        internal Label Label3;
        internal TextBox TBNombreProducto;
        internal Label Label2;
        internal Label Label5;
        internal TextBox TBPrecio;
        internal Label Label4;
        internal TextBox TBStock;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Categoria;
        internal DataGridViewTextBoxColumn Stock;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Talle;

        #endregion
    }
}