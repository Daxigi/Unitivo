namespace Unitivo.Presentacion.Administrador
{
    partial class ModificarProducto
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
            PanelModClientes = new Panel();
            BCancelar = new Button();
            BModificarProducto = new Button();
            GroupBoxDatosCliente = new GroupBox();
            TBStockProducto = new TextBox();
            Label4 = new Label();
            CBTalleProducto = new ComboBox();
            Label5 = new Label();
            Label6 = new Label();
            TBPrecioProducto = new TextBox();
            TBNombreProducto = new TextBox();
            LMarca = new Label();
            CBMarcaProducto = new ComboBox();
            Label3 = new Label();
            Label2 = new Label();
            CBCategoriaProducto = new ComboBox();
            PanelModClientes.SuspendLayout();
            GroupBoxDatosCliente.SuspendLayout();
            SuspendLayout();
            // 
            // PanelModClientes
            // 
            PanelModClientes.BackColor = Color.RosyBrown;
            PanelModClientes.BackgroundImageLayout = ImageLayout.None;
            PanelModClientes.Controls.Add(BCancelar);
            PanelModClientes.Controls.Add(BModificarProducto);
            PanelModClientes.Controls.Add(GroupBoxDatosCliente);
            PanelModClientes.Location = new Point(86, 71);
            PanelModClientes.Margin = new Padding(5, 6, 5, 6);
            PanelModClientes.Name = "PanelModClientes";
            PanelModClientes.Size = new Size(677, 563);
            PanelModClientes.TabIndex = 3;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BCancelar.ForeColor = Color.White;
            BCancelar.Location = new Point(356, 477);
            BCancelar.Margin = new Padding(5, 6, 5, 6);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(131, 65);
            BCancelar.TabIndex = 14;
            BCancelar.Text = "Volver";
            BCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            BCancelar.UseVisualStyleBackColor = false;
            BCancelar.Click += BCancelar_Click;
            // 
            // BModificarProducto
            // 
            BModificarProducto.BackColor = Color.DarkOliveGreen;
            BModificarProducto.FlatAppearance.BorderColor = Color.White;
            BModificarProducto.FlatAppearance.BorderSize = 2;
            BModificarProducto.FlatStyle = FlatStyle.Flat;
            BModificarProducto.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarProducto.ForeColor = Color.White;
            BModificarProducto.Location = new Point(515, 477);
            BModificarProducto.Margin = new Padding(5, 6, 5, 6);
            BModificarProducto.Name = "BModificarProducto";
            BModificarProducto.Size = new Size(131, 65);
            BModificarProducto.TabIndex = 15;
            BModificarProducto.Text = "Modificar";
            BModificarProducto.UseVisualStyleBackColor = false;
            // 
            // GroupBoxDatosCliente
            // 
            GroupBoxDatosCliente.Controls.Add(TBStockProducto);
            GroupBoxDatosCliente.Controls.Add(Label4);
            GroupBoxDatosCliente.Controls.Add(CBTalleProducto);
            GroupBoxDatosCliente.Controls.Add(Label5);
            GroupBoxDatosCliente.Controls.Add(Label6);
            GroupBoxDatosCliente.Controls.Add(TBPrecioProducto);
            GroupBoxDatosCliente.Controls.Add(TBNombreProducto);
            GroupBoxDatosCliente.Controls.Add(LMarca);
            GroupBoxDatosCliente.Controls.Add(CBMarcaProducto);
            GroupBoxDatosCliente.Controls.Add(Label3);
            GroupBoxDatosCliente.Controls.Add(Label2);
            GroupBoxDatosCliente.Controls.Add(CBCategoriaProducto);
            GroupBoxDatosCliente.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosCliente.ForeColor = Color.White;
            GroupBoxDatosCliente.Location = new Point(45, 35);
            GroupBoxDatosCliente.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Name = "GroupBoxDatosCliente";
            GroupBoxDatosCliente.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosCliente.Size = new Size(600, 417);
            GroupBoxDatosCliente.TabIndex = 19;
            GroupBoxDatosCliente.TabStop = false;
            GroupBoxDatosCliente.Text = "Modificar Producto";
            // 
            // TBStockProducto
            // 
            TBStockProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBStockProducto.Location = new Point(324, 318);
            TBStockProducto.Margin = new Padding(5, 6, 5, 6);
            TBStockProducto.Name = "TBStockProducto";
            TBStockProducto.Size = new Size(213, 34);
            TBStockProducto.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.White;
            Label4.Location = new Point(319, 282);
            Label4.Margin = new Padding(8, 0, 8, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(78, 27);
            Label4.TabIndex = 16;
            Label4.Text = "Stock:";
            // 
            // CBTalleProducto
            // 
            CBTalleProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBTalleProducto.FormattingEnabled = true;
            CBTalleProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBTalleProducto.Location = new Point(324, 125);
            CBTalleProducto.Margin = new Padding(4, 5, 4, 5);
            CBTalleProducto.Name = "CBTalleProducto";
            CBTalleProducto.Size = new Size(213, 35);
            CBTalleProducto.TabIndex = 19;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.White;
            Label5.Location = new Point(319, 182);
            Label5.Margin = new Padding(8, 0, 8, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(94, 27);
            Label5.TabIndex = 17;
            Label5.Text = "Precio: ";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.White;
            Label6.Location = new Point(319, 86);
            Label6.Margin = new Padding(8, 0, 8, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(77, 27);
            Label6.TabIndex = 18;
            Label6.Text = "Talle: ";
            // 
            // TBPrecioProducto
            // 
            TBPrecioProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBPrecioProducto.Location = new Point(324, 217);
            TBPrecioProducto.Margin = new Padding(5, 6, 5, 6);
            TBPrecioProducto.Name = "TBPrecioProducto";
            TBPrecioProducto.Size = new Size(213, 34);
            TBPrecioProducto.TabIndex = 15;
            // 
            // TBNombreProducto
            // 
            TBNombreProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombreProducto.Location = new Point(63, 318);
            TBNombreProducto.Margin = new Padding(5, 6, 5, 6);
            TBNombreProducto.Name = "TBNombreProducto";
            TBNombreProducto.Size = new Size(213, 34);
            TBNombreProducto.TabIndex = 8;
            // 
            // LMarca
            // 
            LMarca.AutoSize = true;
            LMarca.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LMarca.ForeColor = Color.White;
            LMarca.Location = new Point(61, 182);
            LMarca.Margin = new Padding(8, 0, 8, 0);
            LMarca.Name = "LMarca";
            LMarca.Size = new Size(92, 27);
            LMarca.TabIndex = 20;
            LMarca.Text = "Marca: ";
            // 
            // CBMarcaProducto
            // 
            CBMarcaProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBMarcaProducto.FormattingEnabled = true;
            CBMarcaProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBMarcaProducto.Location = new Point(63, 217);
            CBMarcaProducto.Margin = new Padding(4, 5, 4, 5);
            CBMarcaProducto.Name = "CBMarcaProducto";
            CBMarcaProducto.Size = new Size(213, 35);
            CBMarcaProducto.TabIndex = 21;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(59, 86);
            Label3.Margin = new Padding(8, 0, 8, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(129, 27);
            Label3.TabIndex = 15;
            Label3.Text = "Categoría: ";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(63, 277);
            Label2.Margin = new Padding(8, 0, 8, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(101, 27);
            Label2.TabIndex = 14;
            Label2.Text = "Nombre:";
            // 
            // CBCategoriaProducto
            // 
            CBCategoriaProducto.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            CBCategoriaProducto.FormattingEnabled = true;
            CBCategoriaProducto.Items.AddRange(new object[] { "DNI", "OTRO" });
            CBCategoriaProducto.Location = new Point(63, 125);
            CBCategoriaProducto.Margin = new Padding(4, 5, 4, 5);
            CBCategoriaProducto.Name = "CBCategoriaProducto";
            CBCategoriaProducto.Size = new Size(213, 35);
            CBCategoriaProducto.TabIndex = 18;
            // 
            // ModificarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(898, 692);
            Controls.Add(PanelModClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "ModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            PanelModClientes.ResumeLayout(false);
            GroupBoxDatosCliente.ResumeLayout(false);
            GroupBoxDatosCliente.PerformLayout();
            ResumeLayout(false);
        }

        internal Panel PanelModClientes;
        internal Button BCancelar;
        internal Button BModificarProducto;
        internal GroupBox GroupBoxDatosCliente;
        internal TextBox TBStockProducto;
        internal Label Label4;
        internal ComboBox CBTalleProducto;
        internal Label Label5;
        internal Label Label6;
        internal TextBox TBPrecioProducto;
        internal TextBox TBNombreProducto;
        internal Label LMarca;
        internal ComboBox CBMarcaProducto;
        internal Label Label3;
        internal Label Label2;
        internal ComboBox CBCategoriaProducto;

        #endregion
    }
}