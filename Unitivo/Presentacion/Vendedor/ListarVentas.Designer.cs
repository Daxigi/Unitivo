namespace Unitivo.Presentacion.Vendedor
{
    partial class ListarVentas
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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            GroupBoxBuscarProducto = new GroupBox();
            DateTimePicker2 = new DateTimePicker();
            Label2 = new Label();
            Button1 = new Button();
            //Button1.Click += new EventHandler(Button1_Click);
            Label1 = new Label();
            BBuscarVenta = new Button();
            DateTimePicker1 = new DateTimePicker();
            TBBuscar = new TextBox();
            //TBBuscar.KeyPress += new KeyPressEventHandler(TBBuscar_KeyPress);
            TabControlListaProductos = new TabControl();
            TabPageListaProducto = new TabPage();
            DataGridViewListaVentas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxBuscarProducto.SuspendLayout();
            TabControlListaProductos.SuspendLayout();
            TabPageListaProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxBuscarProducto
            // 
            GroupBoxBuscarProducto.BackColor = Color.Cornsilk;
            GroupBoxBuscarProducto.Controls.Add(DateTimePicker2);
            GroupBoxBuscarProducto.Controls.Add(Label2);
            GroupBoxBuscarProducto.Controls.Add(Button1);
            GroupBoxBuscarProducto.Controls.Add(Label1);
            GroupBoxBuscarProducto.Controls.Add(BBuscarVenta);
            GroupBoxBuscarProducto.Controls.Add(DateTimePicker1);
            GroupBoxBuscarProducto.Controls.Add(TBBuscar);
            GroupBoxBuscarProducto.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxBuscarProducto.ForeColor = Color.SaddleBrown;
            GroupBoxBuscarProducto.Location = new Point(29, 24);
            GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto";
            GroupBoxBuscarProducto.Size = new Size(738, 89);
            GroupBoxBuscarProducto.TabIndex = 21;
            GroupBoxBuscarProducto.TabStop = false;
            GroupBoxBuscarProducto.Text = "Ventas";
            // 
            // DateTimePicker2
            // 
            DateTimePicker2.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePicker2.Format = DateTimePickerFormat.Short;
            DateTimePicker2.Location = new Point(205, 44);
            DateTimePicker2.Name = "DateTimePicker2";
            DateTimePicker2.Size = new Size(106, 24);
            DateTimePicker2.TabIndex = 33;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.Location = new Point(202, 25);
            Label2.Name = "Label2";
            Label2.Size = new Size(72, 16);
            Label2.TabIndex = 32;
            Label2.Text = "Fecha Fin:";
            // 
            // Button1
            // 
            Button1.BackColor = Color.Sienna;
            Button1.FlatAppearance.BorderSize = 2;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Font = new Font("Britannic Bold", 13.0f);
            Button1.ForeColor = Color.White;
            Button1.Location = new Point(587, 32);
            Button1.Name = "Button1";
            Button1.Size = new Size(111, 42);
            Button1.TabIndex = 27;
            Button1.Text = "Ver Detalle";
            Button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            Button1.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.Location = new Point(74, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(89, 16);
            Label1.TabIndex = 31;
            Label1.Text = "Fecha Inicio:";
            // 
            // BBuscarVenta
            // 
            BBuscarVenta.BackColor = Color.DarkOliveGreen;
            BBuscarVenta.FlatAppearance.BorderColor = Color.White;
            BBuscarVenta.FlatAppearance.BorderSize = 2;
            BBuscarVenta.FlatStyle = FlatStyle.Flat;
            BBuscarVenta.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarVenta.ForeColor = Color.White;
            BBuscarVenta.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarVenta.Location = new Point(499, 35);
            BBuscarVenta.Name = "BBuscarVenta";
            BBuscarVenta.Size = new Size(50, 38);
            BBuscarVenta.TabIndex = 14;
            BBuscarVenta.UseVisualStyleBackColor = false;
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(77, 44);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(104, 24);
            DateTimePicker1.TabIndex = 30;
            // 
            // TBBuscar
            // 
            TBBuscar.Font = new Font("Britannic Bold", 13.0f);
            TBBuscar.ForeColor = SystemColors.WindowFrame;
            TBBuscar.Location = new Point(350, 41);
            TBBuscar.Name = "TBBuscar";
            TBBuscar.Size = new Size(131, 27);
            TBBuscar.TabIndex = 6;
            // 
            // TabControlListaProductos
            // 
            TabControlListaProductos.Controls.Add(TabPageListaProducto);
            TabControlListaProductos.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaProductos.Location = new Point(29, 133);
            TabControlListaProductos.Margin = new Padding(2);
            TabControlListaProductos.Name = "TabControlListaProductos";
            TabControlListaProductos.SelectedIndex = 0;
            TabControlListaProductos.Size = new Size(738, 292);
            TabControlListaProductos.TabIndex = 20;
            // 
            // TabPageListaProducto
            // 
            TabPageListaProducto.Controls.Add(DataGridViewListaVentas);
            TabPageListaProducto.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaProducto.ForeColor = Color.White;
            TabPageListaProducto.Location = new Point(4, 25);
            TabPageListaProducto.Margin = new Padding(2);
            TabPageListaProducto.Name = "TabPageListaProducto";
            TabPageListaProducto.Padding = new Padding(2);
            TabPageListaProducto.Size = new Size(730, 263);
            TabPageListaProducto.TabIndex = 0;
            TabPageListaProducto.Text = "Lista de Ventas";
            TabPageListaProducto.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListaVentas
            // 
            DataGridViewListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListaVentas.BackgroundColor = Color.RosyBrown;
            DataGridViewListaVentas.BorderStyle = BorderStyle.None;
            DataGridViewListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = SystemColors.Window;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            DataGridViewListaVentas.ColumnHeadersHeight = 20;
            DataGridViewListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListaVentas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column3, Column6 });
            DataGridViewListaVentas.Dock = DockStyle.Fill;
            DataGridViewListaVentas.EnableHeadersVisualStyles = false;
            DataGridViewListaVentas.Location = new Point(2, 2);
            DataGridViewListaVentas.Name = "DataGridViewListaVentas";
            DataGridViewListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = Color.NavajoWhite;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            DataGridViewListaVentas.RowHeadersWidth = 51;
            DataGridViewListaVentas.Size = new Size(726, 259);
            DataGridViewListaVentas.TabIndex = 5;
            // 
            // Column1
            // 
            Column1.HeaderText = "N° Factura";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Fecha";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // Column5
            // 
            Column5.HeaderText = "Cliente";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            // 
            // Column6
            // 
            Column6.HeaderText = "Total";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(661, 450);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 68;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // ListarVentas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 500);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxBuscarProducto);
            Controls.Add(TabControlListaProductos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarVentas";
            Text = "Form1";
            GroupBoxBuscarProducto.ResumeLayout(false);
            GroupBoxBuscarProducto.PerformLayout();
            TabControlListaProductos.ResumeLayout(false);
            TabPageListaProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListaVentas).EndInit();
            ResumeLayout(false);

        }

        internal GroupBox GroupBoxBuscarProducto;
        internal DateTimePicker DateTimePicker2;
        internal Label Label2;
        internal Button Button1;
        internal Label Label1;
        internal Button BBuscarVenta;
        internal DateTimePicker DateTimePicker1;
        internal TextBox TBBuscar;
        internal TabControl TabControlListaProductos;
        internal TabPage TabPageListaProducto;
        internal DataGridView DataGridViewListaVentas;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column5;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column6;
        internal Button BVolver;

        #endregion
    }
}