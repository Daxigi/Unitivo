namespace Unitivo.Formularios
{
    partial class AñadirCliente
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
            Panel1 = new Panel();
            BVolver = new Button();
            BRegistrarCliente = new Button();
            TBCorreoCliente = new TextBox();
            Label7 = new Label();
            TBDireccionCliente = new TextBox();
            Label6 = new Label();
            TBTelCliente = new TextBox();
            Label5 = new Label();
            TBDniCliente = new TextBox();
            Label4 = new Label();
            TBApellidoCliente = new TextBox();
            Label3 = new Label();
            TBNombreCliente = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            TabControlRegClientes = new TabControl();
            TabPageListaClientes = new TabPage();
            DataGridViewRegistroClientes = new DataGridView();
            Panel1.SuspendLayout();
            TabControlRegClientes.SuspendLayout();
            TabPageListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroClientes).BeginInit();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BVolver);
            Panel1.Controls.Add(BRegistrarCliente);
            Panel1.Controls.Add(TBCorreoCliente);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccionCliente);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelCliente);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniCliente);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoCliente);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreCliente);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(52, 90);
            Panel1.Margin = new Padding(4, 4, 4, 4);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(377, 392);
            Panel1.TabIndex = 0;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(43, 309);
            BVolver.Margin = new Padding(4, 4, 4, 4);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(123, 44);
            BVolver.TabIndex = 18;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BRegistrarCliente
            // 
            BRegistrarCliente.BackColor = Color.DarkOliveGreen;
            BRegistrarCliente.FlatAppearance.BorderSize = 2;
            BRegistrarCliente.FlatStyle = FlatStyle.Flat;
            BRegistrarCliente.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarCliente.ForeColor = Color.Cornsilk;
            BRegistrarCliente.Location = new Point(193, 309);
            BRegistrarCliente.Margin = new Padding(4, 4, 4, 4);
            BRegistrarCliente.Name = "BRegistrarCliente";
            BRegistrarCliente.Size = new Size(143, 44);
            BRegistrarCliente.TabIndex = 17;
            BRegistrarCliente.Text = "Añadir";
            BRegistrarCliente.UseVisualStyleBackColor = false;
            BRegistrarCliente.Click += BRegistrarCliente_Click;
            // 
            // TBCorreoCliente
            // 
            TBCorreoCliente.Location = new Point(186, 241);
            TBCorreoCliente.Margin = new Padding(4, 4, 4, 4);
            TBCorreoCliente.Name = "TBCorreoCliente";
            TBCorreoCliente.Size = new Size(148, 23);
            TBCorreoCliente.TabIndex = 16;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(41, 238);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(78, 25);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionCliente
            // 
            TBDireccionCliente.Location = new Point(186, 200);
            TBDireccionCliente.Margin = new Padding(4, 4, 4, 4);
            TBDireccionCliente.Name = "TBDireccionCliente";
            TBDireccionCliente.Size = new Size(148, 23);
            TBDireccionCliente.TabIndex = 14;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(41, 196);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(104, 25);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelCliente
            // 
            TBTelCliente.Location = new Point(186, 157);
            TBTelCliente.Margin = new Padding(4, 4, 4, 4);
            TBTelCliente.Name = "TBTelCliente";
            TBTelCliente.Size = new Size(148, 23);
            TBTelCliente.TabIndex = 12;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(41, 154);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(100, 25);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniCliente
            // 
            TBDniCliente.Location = new Point(186, 113);
            TBDniCliente.Margin = new Padding(4, 4, 4, 4);
            TBDniCliente.Name = "TBDniCliente";
            TBDniCliente.Size = new Size(148, 23);
            TBDniCliente.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(41, 110);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(56, 25);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.Location = new Point(186, 68);
            TBApellidoCliente.Margin = new Padding(4, 4, 4, 4);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(148, 23);
            TBApellidoCliente.TabIndex = 8;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(41, 64);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(93, 25);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(186, 23);
            TBNombreCliente.Margin = new Padding(4, 4, 4, 4);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(148, 23);
            TBNombreCliente.TabIndex = 6;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(41, 20);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(92, 25);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(53, 22);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(276, 39);
            Label1.TabIndex = 1;
            Label1.Text = "Registrar Cliente";
            // 
            // TabControlRegClientes
            // 
            TabControlRegClientes.Controls.Add(TabPageListaClientes);
            TabControlRegClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegClientes.Location = new Point(529, 67);
            TabControlRegClientes.Margin = new Padding(4, 4, 4, 4);
            TabControlRegClientes.Name = "TabControlRegClientes";
            TabControlRegClientes.SelectedIndex = 0;
            TabControlRegClientes.Size = new Size(370, 416);
            TabControlRegClientes.TabIndex = 2;
            // 
            // TabPageListaClientes
            // 
            TabPageListaClientes.Controls.Add(DataGridViewRegistroClientes);
            TabPageListaClientes.ForeColor = Color.White;
            TabPageListaClientes.Location = new Point(4, 27);
            TabPageListaClientes.Margin = new Padding(4, 4, 4, 4);
            TabPageListaClientes.Name = "TabPageListaClientes";
            TabPageListaClientes.Padding = new Padding(4, 4, 4, 4);
            TabPageListaClientes.Size = new Size(362, 385);
            TabPageListaClientes.TabIndex = 0;
            TabPageListaClientes.Text = "Lista de Clientes";
            TabPageListaClientes.UseVisualStyleBackColor = true;
            // 
            // DataGridViewRegistroClientes
            // 
            DataGridViewRegistroClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRegistroClientes.Dock = DockStyle.Fill;
            DataGridViewRegistroClientes.Location = new Point(4, 4);
            DataGridViewRegistroClientes.Margin = new Padding(4, 4, 4, 4);
            DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes";
            DataGridViewRegistroClientes.RowHeadersWidth = 51;
            DataGridViewRegistroClientes.Size = new Size(354, 377);
            DataGridViewRegistroClientes.TabIndex = 0;
            // 
            // AñadirCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(934, 519);
            Controls.Add(TabControlRegClientes);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "AñadirCliente";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControlRegClientes.ResumeLayout(false);
            TabPageListaClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewRegistroClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Panel Panel1;
        internal Label Label1;
        internal TextBox TBCorreoCliente;
        internal Label Label7;
        internal TextBox TBDireccionCliente;
        internal Label Label6;
        internal TextBox TBTelCliente;
        internal Label Label5;
        internal TextBox TBDniCliente;
        internal Label Label4;
        internal TextBox TBApellidoCliente;
        internal Label Label3;
        internal TextBox TBNombreCliente;
        internal Label Label2;
        internal Button BRegistrarCliente;
        internal Button BVolver;
        internal TabControl TabControlRegClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView DataGridViewRegistroClientes;

        #endregion
    }
}