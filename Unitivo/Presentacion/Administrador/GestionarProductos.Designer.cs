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
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            GroupBoxGestionProductos = new GroupBox();
            ComboBox1 = new ComboBox();
            BEliminarProducto = new Button();
            //BEliminarProducto.Click += new EventHandler(BEliminarProducto_Click);
            BModificarProducto = new Button();
            //BModificarProducto.Click += new EventHandler(BModificarProducto_Click);
            BBuscarProducto = new Button();
            TBGestionProductos = new TextBox();
            //TBGestionProductos.KeyPress += new KeyPressEventHandler(TBGestionProductos_KeyPress);
            TabListaCategorias = new TabControl();
            TabPageListaTalle = new TabPage();
            dgvListaProductos = new DataGridView();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxGestionProductos.SuspendLayout();
            TabListaCategorias.SuspendLayout();
            TabPageListaTalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionProductos
            // 
            GroupBoxGestionProductos.BackColor = Color.Cornsilk;
            GroupBoxGestionProductos.Controls.Add(ComboBox1);
            GroupBoxGestionProductos.Controls.Add(BBuscarProducto);
            GroupBoxGestionProductos.Controls.Add(TBGestionProductos);
            GroupBoxGestionProductos.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionProductos.ForeColor = Color.SaddleBrown;
            GroupBoxGestionProductos.Location = new Point(193, 24);
            GroupBoxGestionProductos.Name = "GroupBoxGestionProductos";
            GroupBoxGestionProductos.Size = new Size(425, 99);
            GroupBoxGestionProductos.TabIndex = 23;
            GroupBoxGestionProductos.TabStop = false;
            GroupBoxGestionProductos.Text = "Gestión de Productos";
            // 
            // ComboBox1
            // 
            ComboBox1.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox1.FormattingEnabled = true;
            ComboBox1.Location = new Point(267, 49);
            ComboBox1.Margin = new Padding(4, 2, 2, 2);
            ComboBox1.Name = "ComboBox1";
            ComboBox1.Size = new Size(121, 25);
            ComboBox1.TabIndex = 30;
            ComboBox1.Text = "Categorias";
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.FlatAppearance.BorderSize = 2;
            BEliminarProducto.FlatStyle = FlatStyle.Flat;
            BEliminarProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Properties.Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(733, 345);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(50, 45);
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
            BModificarProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(733, 269);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(50, 45);
            BModificarProducto.TabIndex = 13;
            BModificarProducto.UseVisualStyleBackColor = false;
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
            BBuscarProducto.Location = new Point(198, 39);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(49, 41);
            BBuscarProducto.TabIndex = 14;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBGestionProductos
            // 
            TBGestionProductos.Font = new Font("Britannic Bold", 12.0f);
            TBGestionProductos.Location = new Point(49, 49);
            TBGestionProductos.Name = "TBGestionProductos";
            TBGestionProductos.Size = new Size(131, 25);
            TBGestionProductos.TabIndex = 6;
            // 
            // TabListaCategorias
            // 
            TabListaCategorias.Controls.Add(TabPageListaTalle);
            TabListaCategorias.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaCategorias.Location = new Point(24, 150);
            TabListaCategorias.Margin = new Padding(2);
            TabListaCategorias.Name = "TabListaCategorias";
            TabListaCategorias.SelectedIndex = 0;
            TabListaCategorias.Size = new Size(688, 301);
            TabListaCategorias.TabIndex = 22;
            // 
            // TabPageListaTalle
            // 
            TabPageListaTalle.Controls.Add(dgvListaProductos);
            TabPageListaTalle.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaTalle.ForeColor = Color.White;
            TabPageListaTalle.Location = new Point(4, 25);
            TabPageListaTalle.Margin = new Padding(2);
            TabPageListaTalle.Name = "TabPageListaTalle";
            TabPageListaTalle.Padding = new Padding(2);
            TabPageListaTalle.Size = new Size(680, 272);
            TabPageListaTalle.TabIndex = 0;
            TabPageListaTalle.Text = "Lista de Productos";
            TabPageListaTalle.UseVisualStyleBackColor = true;
            // 
            // dgvListaProductos
            // 
            dgvListaProductos.AllowUserToDeleteRows = false;
            dgvListaProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaProductos.BackgroundColor = Color.RosyBrown;
            dgvListaProductos.BorderStyle = BorderStyle.None;
            dgvListaProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.Window;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3;
            dgvListaProductos.ColumnHeadersHeight = 20;
            dgvListaProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaProductos.Columns.AddRange(new DataGridViewColumn[] { Column2, Column3, Categoria, Stock, Column1, Column4, Talle });
            dgvListaProductos.Dock = DockStyle.Fill;
            dgvListaProductos.EnableHeadersVisualStyles = false;
            dgvListaProductos.Location = new Point(2, 2);
            dgvListaProductos.Name = "dgvListaProductos";
            dgvListaProductos.ReadOnly = true;
            dgvListaProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.NavajoWhite;
            DataGridViewCellStyle4.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dgvListaProductos.RowHeadersWidth = 51;
            dgvListaProductos.Size = new Size(676, 268);
            dgvListaProductos.TabIndex = 8;
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
            Column1.HeaderText = "Marca";
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
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(606, 475);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 80;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // GestionarProductos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 550);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionProductos);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            Controls.Add(TabListaCategorias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarProductos";
            Text = "Form1";
            GroupBoxGestionProductos.ResumeLayout(false);
            GroupBoxGestionProductos.PerformLayout();
            TabListaCategorias.ResumeLayout(false);
            TabPageListaTalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaProductos).EndInit();
            ResumeLayout(false);

        }

        internal GroupBox GroupBoxGestionProductos;
        internal ComboBox ComboBox1;
        internal Button BEliminarProducto;
        internal Button BModificarProducto;
        internal Button BBuscarProducto;
        internal TextBox TBGestionProductos;
        internal TabControl TabListaCategorias;
        internal TabPage TabPageListaTalle;
        internal DataGridView dgvListaProductos;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Categoria;
        internal DataGridViewTextBoxColumn Stock;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column4;
        internal DataGridViewTextBoxColumn Talle;
        internal Button BVolver;

        #endregion
    }
}