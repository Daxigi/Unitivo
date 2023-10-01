namespace Unitivo.Presentacion.Vendedor
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
            Panel1.Location = new Point(60, 120);
            Panel1.Margin = new Padding(4, 5, 4, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(431, 522);
            Panel1.TabIndex = 0;
            // 
            // BRegistrarCliente
            // 
            BRegistrarCliente.BackColor = Color.DarkOliveGreen;
            BRegistrarCliente.FlatAppearance.BorderSize = 2;
            BRegistrarCliente.FlatStyle = FlatStyle.Flat;
            BRegistrarCliente.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            BRegistrarCliente.ForeColor = Color.Cornsilk;
            BRegistrarCliente.Location = new Point(123, 400);
            BRegistrarCliente.Margin = new Padding(4, 5, 4, 5);
            BRegistrarCliente.Name = "BRegistrarCliente";
            BRegistrarCliente.Size = new Size(163, 59);
            BRegistrarCliente.TabIndex = 17;
            BRegistrarCliente.Text = "Añadir";
            BRegistrarCliente.UseVisualStyleBackColor = false;
            BRegistrarCliente.Click += BRegistrarCliente_Click;
            // 
            // TBCorreoCliente
            // 
            TBCorreoCliente.Location = new Point(213, 321);
            TBCorreoCliente.Margin = new Padding(4, 5, 4, 5);
            TBCorreoCliente.Name = "TBCorreoCliente";
            TBCorreoCliente.Size = new Size(169, 27);
            TBCorreoCliente.TabIndex = 16;
            TBCorreoCliente.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(47, 318);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(102, 29);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionCliente
            // 
            TBDireccionCliente.Location = new Point(213, 265);
            TBDireccionCliente.Name = "TBDireccionCliente";
            TBDireccionCliente.Size = new Size(169, 27);
            TBDireccionCliente.TabIndex = 18;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(47, 261);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(138, 29);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelCliente
            // 
            TBTelCliente.Location = new Point(213, 209);
            TBTelCliente.Margin = new Padding(4, 5, 4, 5);
            TBTelCliente.Name = "TBTelCliente";
            TBTelCliente.Size = new Size(169, 27);
            TBTelCliente.TabIndex = 12;
            TBTelCliente.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(47, 205);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(132, 29);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniCliente
            // 
            TBDniCliente.Location = new Point(213, 151);
            TBDniCliente.Margin = new Padding(4, 5, 4, 5);
            TBDniCliente.Name = "TBDniCliente";
            TBDniCliente.Size = new Size(169, 27);
            TBDniCliente.TabIndex = 10;
            TBDniCliente.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(47, 146);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(71, 29);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.Location = new Point(213, 91);
            TBApellidoCliente.Margin = new Padding(4, 5, 4, 5);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(169, 27);
            TBApellidoCliente.TabIndex = 8;
            TBApellidoCliente.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(47, 86);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(124, 29);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(213, 31);
            TBNombreCliente.Margin = new Padding(4, 5, 4, 5);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(169, 27);
            TBNombreCliente.TabIndex = 6;
            TBNombreCliente.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(47, 26);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(121, 29);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(70, 38);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(348, 52);
            Label1.TabIndex = 1;
            Label1.Text = "Registrar Cliente";
            // 
            // TabControlRegClientes
            // 
            TabControlRegClientes.Controls.Add(TabPageListaClientes);
            TabControlRegClientes.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegClientes.Location = new Point(605, 89);
            TabControlRegClientes.Margin = new Padding(4, 5, 4, 5);
            TabControlRegClientes.Name = "TabControlRegClientes";
            TabControlRegClientes.SelectedIndex = 0;
            TabControlRegClientes.Size = new Size(423, 555);
            TabControlRegClientes.TabIndex = 2;
            // 
            // TabPageListaClientes
            // 
            TabPageListaClientes.Controls.Add(DataGridViewRegistroClientes);
            TabPageListaClientes.ForeColor = Color.White;
            TabPageListaClientes.Location = new Point(4, 33);
            TabPageListaClientes.Margin = new Padding(4, 5, 4, 5);
            TabPageListaClientes.Name = "TabPageListaClientes";
            TabPageListaClientes.Padding = new Padding(4, 5, 4, 5);
            TabPageListaClientes.Size = new Size(415, 518);
            TabPageListaClientes.TabIndex = 0;
            TabPageListaClientes.Text = "Lista de Clientes";
            TabPageListaClientes.UseVisualStyleBackColor = true;
            // 
            // DataGridViewRegistroClientes
            // 
            DataGridViewRegistroClientes.BackgroundColor = Color.RosyBrown;
            DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridViewRegistroClientes.Dock = DockStyle.Fill;
            DataGridViewRegistroClientes.Location = new Point(4, 5);
            DataGridViewRegistroClientes.Margin = new Padding(4, 5, 4, 5);
            DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes";
            DataGridViewRegistroClientes.RowHeadersWidth = 51;
            DataGridViewRegistroClientes.Size = new Size(407, 508);
            DataGridViewRegistroClientes.TabIndex = 0;
            // 
            // AñadirCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 692);
            Controls.Add(TabControlRegClientes);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
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

        internal TextBox TBDireccion;
        internal Label Label2;
        internal Button BRegistrarCliente;
        internal TabControl TabControlRegClientes;
        internal TabPage TabPageListaClientes;
        internal DataGridView DataGridViewRegistroClientes;

        #endregion
    }
}