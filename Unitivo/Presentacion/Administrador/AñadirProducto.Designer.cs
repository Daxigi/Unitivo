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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaProductos = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            DataGridViewRegistroCategorias = new DataGridView();
            Label1 = new Label();
            Panel2 = new Panel();
            BAgregarImagen = new Button();
            pictureBoxProducto = new PictureBox();
            BAñadirProducto = new Button();
            CBCategoria = new ComboBox();
            LImagen = new Label();
            CBTalle = new ComboBox();
            Label6 = new Label();
            Label3 = new Label();
            TBNombreProducto = new TextBox();
            Label2 = new Label();
            Label5 = new Label();
            TBPrecio = new TextBox();
            Label4 = new Label();
            TBStock = new TextBox();
            talleBindingSource = new BindingSource(components);
            categoriaBindingSource = new BindingSource(components);
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).BeginInit();
            Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)talleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaProductos.Location = new Point(30, 286);
            TabControlListaProductos.Margin = new Padding(2, 2, 2, 2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(892, 220);
            TabControlListaProductos.TabIndex = 17;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaProductos);
            TabPageListaProducto.Controls.Add(DataGridViewRegistroCategorias);
            TabPageListaProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 26);
            TabPageListaProducto.Margin = new Padding(2, 2, 2, 2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(2, 2, 2, 2);
            TabPageListaProducto.Size = new Size(884, 190);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Producto";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaProductos
            // 
            DataGridViewListaProductos.AllowUserToAddRows = false;
            DataGridViewListaProductos.AllowUserToDeleteRows = false;
            DataGridViewListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaProductos.BackgroundColor = Color.RosyBrown;
            DataGridViewListaProductos.BorderStyle = BorderStyle.None;
            DataGridViewListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewListaProductos.ColumnHeadersHeight = 20;
            DataGridViewListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column4, Talle });
            DataGridViewListaProductos.Dock = DockStyle.Fill;
            DataGridViewListaProductos.EnableHeadersVisualStyles = false;
            DataGridViewListaProductos.Location = new Point(2, 2);
            DataGridViewListaProductos.Margin = new Padding(4, 3, 4, 3);
            DataGridViewListaProductos.Name = "DataGridViewListaProductos";
            DataGridViewListaProductos.ReadOnly = true;
            DataGridViewListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.NavajoWhite;
            dataGridViewCellStyle8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            DataGridViewListaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewListaProductos.RowHeadersWidth = 51;
            DataGridViewListaProductos.Size = new Size(880, 186);
            DataGridViewListaProductos.TabIndex = 7;
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
            // DataGridViewRegistroCategorias
            // 
            DataGridViewRegistroCategorias.AllowUserToAddRows = false;
            DataGridViewRegistroCategorias.AllowUserToDeleteRows = false;
            DataGridViewRegistroCategorias.BackgroundColor = Color.FromArgb(31, 31, 69);
            DataGridViewRegistroCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            DataGridViewRegistroCategorias.DefaultCellStyle = dataGridViewCellStyle10;
            DataGridViewRegistroCategorias.Dock = DockStyle.Fill;
            DataGridViewRegistroCategorias.EnableHeadersVisualStyles = false;
            DataGridViewRegistroCategorias.Location = new Point(2, 2);
            DataGridViewRegistroCategorias.Margin = new Padding(4, 3, 4, 3);
            DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias";
            DataGridViewRegistroCategorias.ReadOnly = true;
            DataGridViewRegistroCategorias.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            DataGridViewRegistroCategorias.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            DataGridViewRegistroCategorias.RowHeadersWidth = 51;
            dataGridViewCellStyle12.ForeColor = Color.Black;
            DataGridViewRegistroCategorias.RowsDefaultCellStyle = dataGridViewCellStyle12;
            DataGridViewRegistroCategorias.Size = new Size(880, 186);
            DataGridViewRegistroCategorias.TabIndex = 2;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(278, 23);
            Label1.Margin = new Padding(5, 0, 5, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(337, 40);
            Label1.TabIndex = 15;
            Label1.Text = "Añadir Producto :";
            // 
            // Panel2
            // 
            Panel2.BackColor = Color.Cornsilk;
            Panel2.Controls.Add(BAgregarImagen);
            Panel2.Controls.Add(pictureBoxProducto);
            Panel2.Controls.Add(BAñadirProducto);
            Panel2.Controls.Add(CBCategoria);
            Panel2.Controls.Add(LImagen);
            Panel2.Controls.Add(CBTalle);
            Panel2.Controls.Add(Label6);
            Panel2.Controls.Add(Label3);
            Panel2.Controls.Add(TBNombreProducto);
            Panel2.Controls.Add(Label2);
            Panel2.Controls.Add(Label5);
            Panel2.Controls.Add(TBPrecio);
            Panel2.Controls.Add(Label4);
            Panel2.Controls.Add(TBStock);
            Panel2.Location = new Point(30, 92);
            Panel2.Margin = new Padding(2, 2, 2, 2);
            Panel2.Name = "Panel2";
            Panel2.Size = new Size(892, 158);
            Panel2.TabIndex = 16;
            // 
            // BAgregarImagen
            // 
            BAgregarImagen.Location = new Point(400, 115);
            BAgregarImagen.Margin = new Padding(3, 2, 3, 2);
            BAgregarImagen.Name = "BAgregarImagen";
            BAgregarImagen.Size = new Size(158, 22);
            BAgregarImagen.TabIndex = 20;
            BAgregarImagen.Text = "Agregar";
            BAgregarImagen.UseVisualStyleBackColor = true;
            BAgregarImagen.Click += btnCargarImagen_Click;
            // 
            // pictureBoxProducto
            // 
            pictureBoxProducto.BackColor = Color.RosyBrown;
            pictureBoxProducto.Location = new Point(612, 34);
            pictureBoxProducto.Margin = new Padding(3, 2, 3, 2);
            pictureBoxProducto.Name = "pictureBoxProducto";
            pictureBoxProducto.Size = new Size(124, 92);
            pictureBoxProducto.TabIndex = 19;
            pictureBoxProducto.TabStop = false;
            // 
            // BAñadirProducto
            // 
            BAñadirProducto.BackColor = Color.DarkOliveGreen;
            BAñadirProducto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BAñadirProducto.ForeColor = Color.White;
            BAñadirProducto.Location = new Point(773, 55);
            BAñadirProducto.Margin = new Padding(2, 2, 2, 2);
            BAñadirProducto.Name = "BAñadirProducto";
            BAñadirProducto.Size = new Size(105, 47);
            BAñadirProducto.TabIndex = 2;
            BAñadirProducto.Text = "Añadir";
            BAñadirProducto.UseVisualStyleBackColor = false;
            BAñadirProducto.Click += BAñadirProducto_Click;
            // 
            // CBCategoria
            // 
            CBCategoria.DataSource = categoriaBindingSource;
            CBCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            CBCategoria.FormattingEnabled = true;
            CBCategoria.Location = new Point(122, 66);
            CBCategoria.Margin = new Padding(2, 2, 2, 2);
            CBCategoria.Name = "CBCategoria";
            CBCategoria.Size = new Size(153, 23);
            CBCategoria.TabIndex = 15;
            // 
            // LImagen
            // 
            LImagen.AutoSize = true;
            LImagen.BackColor = Color.Cornsilk;
            LImagen.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LImagen.ForeColor = Color.SaddleBrown;
            LImagen.Location = new Point(300, 112);
            LImagen.Margin = new Padding(5, 0, 5, 0);
            LImagen.Name = "LImagen";
            LImagen.Size = new Size(83, 24);
            LImagen.TabIndex = 13;
            LImagen.Text = "Imagen: ";
            // 
            // CBTalle
            // 
            CBTalle.DataSource = talleBindingSource;
            CBTalle.DropDownStyle = ComboBoxStyle.DropDownList;
            CBTalle.FormattingEnabled = true;
            CBTalle.Location = new Point(405, 68);
            CBTalle.Margin = new Padding(2, 2, 2, 2);
            CBTalle.Name = "CBTalle";
            CBTalle.Size = new Size(153, 23);
            CBTalle.TabIndex = 11;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = Color.Cornsilk;
            Label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(298, 67);
            Label6.Margin = new Padding(5, 0, 5, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(61, 24);
            Label6.TabIndex = 10;
            Label6.Text = "Talle: ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Cornsilk;
            Label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(15, 64);
            Label3.Margin = new Padding(5, 0, 5, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(100, 24);
            Label3.TabIndex = 1;
            Label3.Text = "Categoría: ";
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Location = new Point(122, 21);
            TBNombreProducto.Margin = new Padding(5, 5, 5, 5);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(153, 23);
            TBNombreProducto.TabIndex = 5;
            TBNombreProducto.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Cornsilk;
            Label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(15, 19);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(84, 24);
            Label2.TabIndex = 0;
            Label2.Text = "Nombre:";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = Color.Cornsilk;
            Label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(300, 21);
            Label5.Margin = new Padding(5, 0, 5, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(74, 24);
            Label5.TabIndex = 3;
            Label5.Text = "Precio: ";
            // 
            // TBPrecio
            // 
            TBPrecio.Location = new Point(405, 21);
            TBPrecio.Margin = new Padding(5, 5, 5, 5);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(153, 23);
            TBPrecio.TabIndex = 8;
            TBPrecio.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = Color.Cornsilk;
            Label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(15, 112);
            Label4.Margin = new Padding(5, 0, 5, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(61, 24);
            Label4.TabIndex = 2;
            Label4.Text = "Stock:";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(122, 115);
            TBStock.Margin = new Padding(5, 5, 5, 5);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(153, 23);
            TBStock.TabIndex = 7;
            TBStock.KeyPress += Num_KeyPress;
            // 
            // talleBindingSource
            // 
            talleBindingSource.DataSource = typeof(Modelos.Talle);
            // 
            // categoriaBindingSource
            // 
            categoriaBindingSource.DataSource = typeof(Modelos.Categoria);
            // 
            // AñadirProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(945, 570);
            Controls.Add(TabControlListaProductos);
            Controls.Add(Label1);
            Controls.Add(Panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "AñadirProducto";
            Text = "     ";
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroCategorias).EndInit();
            Panel2.ResumeLayout(false);
            Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)talleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriaBindingSource).EndInit();
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
        internal Label LImagen;
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

        private PictureBox pictureBoxProducto;
        private Button BAgregarImagen;
        private BindingSource categoriaBindingSource;
        private BindingSource talleBindingSource;
    }


}