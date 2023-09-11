using Unitivo.Properties;

namespace Unitivo.Formularios.Vendedor
{
    partial class AñadirVentas
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
            Label1 = new Label();
            TBVendedor = new TextBox();
            LVendedor = new Label();
            DateTimePicker1 = new DateTimePicker();
            LFecha = new Label();
            LNumeroFactura = new Label();
            TBNroFactura = new TextBox();
            GroupBoxClientes = new GroupBox();
            Label5 = new Label();
            TBTelCliVenta = new TextBox();
            Label4 = new Label();
            TBApellidoCliVenta = new TextBox();
            Label3 = new Label();
            TBNombreCliVenta = new TextBox();
            Label2 = new Label();
            BBuscarCliente = new Button();
            // BBuscarCliente.Click += new EventHandler(BBuscarCliente_Click);
            TBDniCliVenta = new TextBox();
            GroupBoxArticulos = new GroupBox();
            Label10 = new Label();
            TBCantidad = new TextBox();
            // TBCantidad.KeyPress += new KeyPressEventHandler(Cantidad_KeyPress);
            Label6 = new Label();
            TBTalle = new TextBox();
            Label7 = new Label();
            TBStock = new TextBox();
            Label8 = new Label();
            TBPrecio = new TextBox();
            Label9 = new Label();
            BBuscarProducto = new Button();
            // BBuscarProducto.Click += new EventHandler(BBuscarProducto_Click);
            TBProductoVenta = new TextBox();
            dgvListaVentas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Talle = new DataGridViewTextBoxColumn();
            LTotalVenta = new Label();
            TBApellidoCliente = new TextBox();
            BVolver = new Button();
            // BVolver.Click += new EventHandler(BVolver_Click);
            // BVolver.Click += new EventHandler(BVolver_Click_1);
            BGuardar = new Button();
            BModificarProducto = new Button();
            BEliminarProducto = new Button();
            GroupBoxClientes.SuspendLayout();
            GroupBoxArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.DarkOliveGreen;
            Label1.Font = new Font("Cooper Black", 24.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.SeaShell;
            Label1.Location = new Point(273, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(224, 36);
            Label1.TabIndex = 2;
            Label1.Text = "Nueva Venta";
            // 
            // TBVendedor
            // 
            TBVendedor.Enabled = false;
            TBVendedor.Font = new Font("Britannic Bold", 10.0f);
            TBVendedor.Location = new Point(600, 72);
            TBVendedor.Margin = new Padding(5);
            TBVendedor.Name = "TBVendedor";
            TBVendedor.Size = new Size(131, 22);
            TBVendedor.TabIndex = 57;
            // 
            // LVendedor
            // 
            LVendedor.AutoSize = true;
            LVendedor.BackColor = Color.SaddleBrown;
            LVendedor.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LVendedor.ForeColor = Color.White;
            LVendedor.Location = new Point(511, 74);
            LVendedor.Margin = new Padding(5, 0, 5, 0);
            LVendedor.Name = "LVendedor";
            LVendedor.Size = new Size(81, 17);
            LVendedor.TabIndex = 60;
            LVendedor.Text = "Vendedor:";
            // 
            // DateTimePicker1
            // 
            DateTimePicker1.Enabled = false;
            DateTimePicker1.Font = new Font("Britannic Bold", 10.0f);
            DateTimePicker1.Format = DateTimePickerFormat.Short;
            DateTimePicker1.Location = new Point(362, 71);
            DateTimePicker1.Margin = new Padding(4);
            DateTimePicker1.Name = "DateTimePicker1";
            DateTimePicker1.Size = new Size(129, 22);
            DateTimePicker1.TabIndex = 59;
            // 
            // LFecha
            // 
            LFecha.AutoSize = true;
            LFecha.BackColor = Color.SaddleBrown;
            LFecha.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LFecha.ForeColor = Color.White;
            LFecha.Location = new Point(298, 74);
            LFecha.Margin = new Padding(5, 0, 5, 0);
            LFecha.Name = "LFecha";
            LFecha.Size = new Size(54, 17);
            LFecha.TabIndex = 58;
            LFecha.Text = "Fecha:";
            // 
            // LNumeroFactura
            // 
            LNumeroFactura.AutoSize = true;
            LNumeroFactura.BackColor = Color.SaddleBrown;
            LNumeroFactura.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNumeroFactura.ForeColor = Color.White;
            LNumeroFactura.Location = new Point(60, 73);
            LNumeroFactura.Margin = new Padding(5, 0, 5, 0);
            LNumeroFactura.Name = "LNumeroFactura";
            LNumeroFactura.Size = new Size(88, 17);
            LNumeroFactura.TabIndex = 55;
            LNumeroFactura.Text = "N° Factura:";
            // 
            // TBNroFactura
            // 
            TBNroFactura.CausesValidation = false;
            TBNroFactura.Enabled = false;
            TBNroFactura.Font = new Font("Britannic Bold", 10.0f);
            TBNroFactura.Location = new Point(156, 71);
            TBNroFactura.Margin = new Padding(5);
            TBNroFactura.Name = "TBNroFactura";
            TBNroFactura.Size = new Size(123, 22);
            TBNroFactura.TabIndex = 56;
            // 
            // GroupBoxClientes
            // 
            GroupBoxClientes.BackColor = Color.Cornsilk;
            GroupBoxClientes.Controls.Add(Label5);
            GroupBoxClientes.Controls.Add(TBTelCliVenta);
            GroupBoxClientes.Controls.Add(Label4);
            GroupBoxClientes.Controls.Add(TBApellidoCliVenta);
            GroupBoxClientes.Controls.Add(Label3);
            GroupBoxClientes.Controls.Add(TBNombreCliVenta);
            GroupBoxClientes.Controls.Add(Label2);
            GroupBoxClientes.Controls.Add(BBuscarCliente);
            GroupBoxClientes.Controls.Add(TBDniCliVenta);
            GroupBoxClientes.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxClientes.ForeColor = Color.SaddleBrown;
            GroupBoxClientes.Location = new Point(20, 121);
            GroupBoxClientes.Name = "GroupBoxClientes";
            GroupBoxClientes.Size = new Size(766, 106);
            GroupBoxClientes.TabIndex = 61;
            GroupBoxClientes.TabStop = false;
            GroupBoxClientes.Text = "Clientes";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.SaddleBrown;
            Label5.Location = new Point(582, 34);
            Label5.Name = "Label5";
            Label5.Size = new Size(89, 19);
            Label5.TabIndex = 9;
            Label5.Text = "Telefono :";
            // 
            // TBTelCliVenta
            // 
            TBTelCliVenta.Location = new Point(586, 57);
            TBTelCliVenta.Name = "TBTelCliVenta";
            TBTelCliVenta.Size = new Size(118, 32);
            TBTelCliVenta.TabIndex = 8;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.SaddleBrown;
            Label4.Location = new Point(437, 34);
            Label4.Name = "Label4";
            Label4.Size = new Size(88, 19);
            Label4.TabIndex = 7;
            Label4.Text = "Apellido :";
            // 
            // TBApellidoCliVenta
            // 
            TBApellidoCliVenta.Location = new Point(441, 57);
            TBApellidoCliVenta.Name = "TBApellidoCliVenta";
            TBApellidoCliVenta.Size = new Size(118, 32);
            TBApellidoCliVenta.TabIndex = 6;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.SaddleBrown;
            Label3.Location = new Point(292, 34);
            Label3.Name = "Label3";
            Label3.Size = new Size(83, 19);
            Label3.TabIndex = 5;
            Label3.Text = "Nombre :";
            // 
            // TBNombreCliVenta
            // 
            TBNombreCliVenta.Location = new Point(296, 57);
            TBNombreCliVenta.Name = "TBNombreCliVenta";
            TBNombreCliVenta.Size = new Size(118, 32);
            TBNombreCliVenta.TabIndex = 4;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.SaddleBrown;
            Label2.Location = new Point(67, 34);
            Label2.Name = "Label2";
            Label2.Size = new Size(51, 19);
            Label2.TabIndex = 3;
            Label2.Text = "DNI :";
            // 
            // BBuscarCliente
            // 
            BBuscarCliente.BackColor = Color.DarkOliveGreen;
            BBuscarCliente.ForeColor = Color.White;
            // add icons8_búsqueda_26 from resources
            BBuscarCliente.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarCliente.Location = new Point(218, 50);
            BBuscarCliente.Name = "BBuscarCliente";
            BBuscarCliente.Size = new Size(45, 40);
            BBuscarCliente.TabIndex = 2;
            BBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // TBDniCliVenta
            // 
            TBDniCliVenta.Location = new Point(71, 57);
            TBDniCliVenta.Name = "TBDniCliVenta";
            TBDniCliVenta.Size = new Size(118, 32);
            TBDniCliVenta.TabIndex = 1;
            // 
            // GroupBoxArticulos
            // 
            GroupBoxArticulos.BackColor = Color.Cornsilk;
            GroupBoxArticulos.Controls.Add(Label10);
            GroupBoxArticulos.Controls.Add(TBCantidad);
            GroupBoxArticulos.Controls.Add(Label6);
            GroupBoxArticulos.Controls.Add(TBTalle);
            GroupBoxArticulos.Controls.Add(Label7);
            GroupBoxArticulos.Controls.Add(TBStock);
            GroupBoxArticulos.Controls.Add(Label8);
            GroupBoxArticulos.Controls.Add(TBPrecio);
            GroupBoxArticulos.Controls.Add(Label9);
            GroupBoxArticulos.Controls.Add(BBuscarProducto);
            GroupBoxArticulos.Controls.Add(TBProductoVenta);
            GroupBoxArticulos.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxArticulos.ForeColor = Color.SaddleBrown;
            GroupBoxArticulos.Location = new Point(20, 245);
            GroupBoxArticulos.Name = "GroupBoxArticulos";
            GroupBoxArticulos.Size = new Size(766, 106);
            GroupBoxArticulos.TabIndex = 62;
            GroupBoxArticulos.TabStop = false;
            GroupBoxArticulos.Text = "Articulos";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.SaddleBrown;
            Label10.Location = new Point(645, 35);
            Label10.Name = "Label10";
            Label10.Size = new Size(92, 19);
            Label10.TabIndex = 11;
            Label10.Text = "Cantidad :";
            // 
            // TBCantidad
            // 
            TBCantidad.Location = new Point(649, 58);
            TBCantidad.Name = "TBCantidad";
            TBCantidad.Size = new Size(105, 32);
            TBCantidad.TabIndex = 10;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.SaddleBrown;
            Label6.Location = new Point(509, 35);
            Label6.Name = "Label6";
            Label6.Size = new Size(58, 19);
            Label6.TabIndex = 9;
            Label6.Text = "Talle :";
            // 
            // TBTalle
            // 
            TBTalle.Location = new Point(513, 58);
            TBTalle.Name = "TBTalle";
            TBTalle.Size = new Size(105, 32);
            TBTalle.TabIndex = 8;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.SaddleBrown;
            Label7.Location = new Point(370, 35);
            Label7.Name = "Label7";
            Label7.Size = new Size(65, 19);
            Label7.TabIndex = 7;
            Label7.Text = "Stock :";
            // 
            // TBStock
            // 
            TBStock.Location = new Point(374, 58);
            TBStock.Name = "TBStock";
            TBStock.Size = new Size(105, 32);
            TBStock.TabIndex = 6;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.SaddleBrown;
            Label8.Location = new Point(231, 35);
            Label8.Name = "Label8";
            Label8.Size = new Size(70, 19);
            Label8.TabIndex = 5;
            Label8.Text = "Precio :";
            // 
            // TBPrecio
            // 
            TBPrecio.Font = new Font("Britannic Bold", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBPrecio.Location = new Point(235, 58);
            TBPrecio.Name = "TBPrecio";
            TBPrecio.Size = new Size(105, 25);
            TBPrecio.TabIndex = 4;
            TBPrecio.Text = "$";
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Cooper Black", 12.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.SaddleBrown;
            Label9.Location = new Point(11, 35);
            Label9.Name = "Label9";
            Label9.Size = new Size(75, 19);
            Label9.TabIndex = 3;
            Label9.Text = "Codigo :";
            // 
            // BBuscarProducto
            // 
            BBuscarProducto.BackColor = Color.DarkOliveGreen;
            BBuscarProducto.ForeColor = Color.White;
            BBuscarProducto.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarProducto.Location = new Point(160, 51);
            BBuscarProducto.Name = "BBuscarProducto";
            BBuscarProducto.Size = new Size(45, 40);
            BBuscarProducto.TabIndex = 2;
            BBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // TBProductoVenta
            // 
            TBProductoVenta.Location = new Point(15, 58);
            TBProductoVenta.Name = "TBProductoVenta";
            TBProductoVenta.Size = new Size(118, 32);
            TBProductoVenta.TabIndex = 1;
            // 
            // dgvListaVentas
            // 
            dgvListaVentas.AllowUserToDeleteRows = false;
            dgvListaVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaVentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaVentas.BackgroundColor = Color.Tan;
            dgvListaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            DataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvListaVentas.ColumnHeadersHeight = 20;
            dgvListaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListaVentas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio, Cantidad, Talle });
            dgvListaVentas.EnableHeadersVisualStyles = false;
            dgvListaVentas.Location = new Point(20, 371);
            dgvListaVentas.Margin = new Padding(4, 2, 4, 2);
            dgvListaVentas.Name = "dgvListaVentas";
            dgvListaVentas.ReadOnly = true;
            dgvListaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvListaVentas.RowHeadersWidth = 51;
            dgvListaVentas.RowTemplate.Height = 24;
            dgvListaVentas.Size = new Size(661, 140);
            dgvListaVentas.TabIndex = 63;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Talle
            // 
            Talle.HeaderText = "Talle";
            Talle.MinimumWidth = 6;
            Talle.Name = "Talle";
            Talle.ReadOnly = true;
            // 
            // LTotalVenta
            // 
            LTotalVenta.AutoSize = true;
            LTotalVenta.BackColor = Color.Cornsilk;
            LTotalVenta.FlatStyle = FlatStyle.Flat;
            LTotalVenta.Font = new Font("Britannic Bold", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LTotalVenta.ForeColor = Color.SaddleBrown;
            LTotalVenta.Location = new Point(50, 532);
            LTotalVenta.Margin = new Padding(5, 0, 5, 0);
            LTotalVenta.Name = "LTotalVenta";
            LTotalVenta.Size = new Size(62, 23);
            LTotalVenta.TabIndex = 64;
            LTotalVenta.Text = "Total:";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.BackColor = Color.Cornsilk;
            TBApellidoCliente.Font = new Font("Britannic Bold", 12.0f);
            TBApellidoCliente.Location = new Point(125, 531);
            TBApellidoCliente.Margin = new Padding(5);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(123, 25);
            TBApellidoCliente.TabIndex = 65;
            TBApellidoCliente.Text = "$";
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(429, 526);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 67;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BGuardar
            // 
            BGuardar.BackColor = Color.DarkOliveGreen;
            BGuardar.FlatAppearance.BorderSize = 2;
            BGuardar.FlatStyle = FlatStyle.Flat;
            BGuardar.Font = new Font("Cooper Black", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BGuardar.ForeColor = Color.Cornsilk;
            BGuardar.Location = new Point(562, 526);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(122, 38);
            BGuardar.TabIndex = 66;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = false;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.SteelBlue;
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarProducto.Location = new Point(711, 393);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(50, 45);
            BModificarProducto.TabIndex = 69;
            BModificarProducto.UseVisualStyleBackColor = false;
            // 
            // BEliminarProducto
            // 
            BEliminarProducto.BackColor = Color.Brown;
            BEliminarProducto.ForeColor = Color.White;
            BEliminarProducto.Image = Properties.Resources.icons8_basura_26;
            BEliminarProducto.Location = new Point(711, 454);
            BEliminarProducto.Name = "BEliminarProducto";
            BEliminarProducto.Size = new Size(50, 45);
            BEliminarProducto.TabIndex = 68;
            BEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // AñadirVentas
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(810, 590);
            Controls.Add(BModificarProducto);
            Controls.Add(BEliminarProducto);
            Controls.Add(BVolver);
            Controls.Add(BGuardar);
            Controls.Add(LTotalVenta);
            Controls.Add(TBApellidoCliente);
            Controls.Add(dgvListaVentas);
            Controls.Add(GroupBoxArticulos);
            Controls.Add(GroupBoxClientes);
            Controls.Add(TBVendedor);
            Controls.Add(LVendedor);
            Controls.Add(DateTimePicker1);
            Controls.Add(LFecha);
            Controls.Add(LNumeroFactura);
            Controls.Add(TBNroFactura);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirVentas";
            Text = "Form1";
            GroupBoxClientes.ResumeLayout(false);
            GroupBoxClientes.PerformLayout();
            GroupBoxArticulos.ResumeLayout(false);
            GroupBoxArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaVentas).EndInit();
            // Load += new EventHandler(AñadirVenta_Load);
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal TextBox TBVendedor;
        internal Label LVendedor;
        internal DateTimePicker DateTimePicker1;
        internal Label LFecha;
        internal Label LNumeroFactura;
        internal TextBox TBNroFactura;
        internal GroupBox GroupBoxClientes;
        internal Button BBuscarCliente;
        internal TextBox TBDniCliVenta;
        internal Label Label2;
        internal Label Label5;
        internal TextBox TBTelCliVenta;
        internal Label Label4;
        internal TextBox TBApellidoCliVenta;
        internal Label Label3;
        internal TextBox TBNombreCliVenta;
        internal GroupBox GroupBoxArticulos;
        internal Label Label10;
        internal TextBox TBCantidad;
        internal Label Label6;
        internal TextBox TBTalle;
        internal Label Label7;
        internal TextBox TBStock;
        internal Label Label8;
        internal TextBox TBPrecio;
        internal Label Label9;
        internal Button BBuscarProducto;
        internal TextBox TBProductoVenta;
        internal DataGridView dgvListaVentas;
        internal DataGridViewTextBoxColumn Codigo;
        internal DataGridViewTextBoxColumn Descripcion;
        internal DataGridViewTextBoxColumn Precio;
        internal DataGridViewTextBoxColumn Cantidad;
        internal DataGridViewTextBoxColumn Talle;
        internal Label LTotalVenta;
        internal TextBox TBApellidoCliente;
        internal Button BVolver;
        internal Button BGuardar;
        internal Button BModificarProducto;
        internal Button BEliminarProducto;
    }

    #endregion
}