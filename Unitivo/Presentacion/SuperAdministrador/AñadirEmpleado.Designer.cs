namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirEmpleado
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            Label1 = new Label();
            Panel1 = new Panel();
            BRegistrarEmpleado = new Button();
            TBCorreoEmpleado = new TextBox();
            Label7 = new Label();
            TBDireccionEmpleado = new TextBox();
            Label6 = new Label();
            TBTelEmpleado = new TextBox();
            Label5 = new Label();
            TBDniEmpleado = new TextBox();
            Label4 = new Label();
            TBApellidoEmpleado = new TextBox();
            Label3 = new Label();
            TBNombreEmpleado = new TextBox();
            Label2 = new Label();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            DataGridViewListarEmpleados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Panel1.SuspendLayout();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarEmpleados).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 24F, FontStyle.Regular, GraphicsUnit.Point);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(55, 38);
            Label1.Margin = new Padding(4, 0, 4, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(425, 46);
            Label1.TabIndex = 4;
            Label1.Text = "Registrar Empleado";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BRegistrarEmpleado);
            Panel1.Controls.Add(TBCorreoEmpleado);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccionEmpleado);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelEmpleado);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniEmpleado);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoEmpleado);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreEmpleado);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(53, 126);
            Panel1.Margin = new Padding(4, 5, 4, 5);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(431, 523);
            Panel1.TabIndex = 3;
            // 
            // BRegistrarEmpleado
            // 
            BRegistrarEmpleado.BackColor = Color.DarkOliveGreen;
            BRegistrarEmpleado.FlatAppearance.BorderSize = 2;
            BRegistrarEmpleado.FlatStyle = FlatStyle.Flat;
            BRegistrarEmpleado.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarEmpleado.ForeColor = Color.Cornsilk;
            BRegistrarEmpleado.Location = new Point(120, 409);
            BRegistrarEmpleado.Margin = new Padding(4, 5, 4, 5);
            BRegistrarEmpleado.Name = "BRegistrarEmpleado";
            BRegistrarEmpleado.Size = new Size(177, 58);
            BRegistrarEmpleado.TabIndex = 17;
            BRegistrarEmpleado.Text = "Añadir";
            BRegistrarEmpleado.UseVisualStyleBackColor = false;
            BRegistrarEmpleado.Click += BRegistrarEmpleado_Click;
            // 
            // TBCorreoEmpleado
            // 
            TBCorreoEmpleado.Location = new Point(213, 322);
            TBCorreoEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBCorreoEmpleado.Name = "TBCorreoEmpleado";
            TBCorreoEmpleado.Size = new Size(169, 27);
            TBCorreoEmpleado.TabIndex = 16;
            TBCorreoEmpleado.KeyPress += Email_KeyPress;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(47, 317);
            Label7.Margin = new Padding(4, 0, 4, 0);
            Label7.Name = "Label7";
            Label7.Size = new Size(106, 29);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionEmpleado
            // 
            TBDireccionEmpleado.Location = new Point(213, 266);
            TBDireccionEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBDireccionEmpleado.Name = "TBDireccionEmpleado";
            TBDireccionEmpleado.Size = new Size(169, 27);
            TBDireccionEmpleado.TabIndex = 14;
            TBDireccionEmpleado.KeyPress += NumStr_KeyPress;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(47, 262);
            Label6.Margin = new Padding(4, 0, 4, 0);
            Label6.Name = "Label6";
            Label6.Size = new Size(148, 29);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelEmpleado
            // 
            TBTelEmpleado.Location = new Point(213, 209);
            TBTelEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBTelEmpleado.Name = "TBTelEmpleado";
            TBTelEmpleado.Size = new Size(169, 27);
            TBTelEmpleado.TabIndex = 12;
            TBTelEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(47, 205);
            Label5.Margin = new Padding(4, 0, 4, 0);
            Label5.Name = "Label5";
            Label5.Size = new Size(137, 29);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniEmpleado
            // 
            TBDniEmpleado.Location = new Point(213, 151);
            TBDniEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBDniEmpleado.Name = "TBDniEmpleado";
            TBDniEmpleado.Size = new Size(169, 27);
            TBDniEmpleado.TabIndex = 10;
            TBDniEmpleado.KeyPress += Num_KeyPress;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(47, 146);
            Label4.Margin = new Padding(4, 0, 4, 0);
            Label4.Name = "Label4";
            Label4.Size = new Size(77, 29);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoEmpleado
            // 
            TBApellidoEmpleado.Location = new Point(213, 91);
            TBApellidoEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBApellidoEmpleado.Name = "TBApellidoEmpleado";
            TBApellidoEmpleado.Size = new Size(169, 27);
            TBApellidoEmpleado.TabIndex = 8;
            TBApellidoEmpleado.KeyPress += String_KeyPress;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(47, 86);
            Label3.Margin = new Padding(4, 0, 4, 0);
            Label3.Name = "Label3";
            Label3.Size = new Size(135, 29);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreEmpleado
            // 
            TBNombreEmpleado.Location = new Point(213, 31);
            TBNombreEmpleado.Margin = new Padding(4, 5, 4, 5);
            TBNombreEmpleado.Name = "TBNombreEmpleado";
            TBNombreEmpleado.Size = new Size(169, 27);
            TBNombreEmpleado.TabIndex = 6;
            TBNombreEmpleado.KeyPress += String_KeyPress;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 14.5F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(47, 26);
            Label2.Margin = new Padding(4, 0, 4, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(128, 29);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaEmpleados.Location = new Point(533, 86);
            TabControlListaEmpleados.Margin = new Padding(4, 3, 4, 3);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(513, 563);
            TabControlListaEmpleados.TabIndex = 13;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(DataGridViewListarEmpleados);
            TabPageListaEmpleados.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 28);
            TabPageListaEmpleados.Margin = new Padding(4, 3, 4, 3);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(4, 3, 4, 3);
            TabPageListaEmpleados.Size = new Size(505, 531);
            TabPageListaEmpleados.TabIndex = 0;
            TabPageListaEmpleados.Text = "Lista de Empleados";
            TabPageListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarEmpleados
            // 
            DataGridViewListarEmpleados.AllowUserToAddRows = false;
            DataGridViewListarEmpleados.AllowUserToDeleteRows = false;
            DataGridViewListarEmpleados.BackgroundColor = Color.RosyBrown;
            DataGridViewListarEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle5.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            DataGridViewListarEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            DataGridViewListarEmpleados.ColumnHeadersHeight = 20;
            DataGridViewListarEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarEmpleados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.White;
            dataGridViewCellStyle6.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            DataGridViewListarEmpleados.DefaultCellStyle = dataGridViewCellStyle6;
            DataGridViewListarEmpleados.Dock = DockStyle.Fill;
            DataGridViewListarEmpleados.EnableHeadersVisualStyles = false;
            DataGridViewListarEmpleados.Location = new Point(4, 3);
            DataGridViewListarEmpleados.Margin = new Padding(5, 6, 5, 6);
            DataGridViewListarEmpleados.Name = "DataGridViewListarEmpleados";
            DataGridViewListarEmpleados.ReadOnly = true;
            DataGridViewListarEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            DataGridViewListarEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            DataGridViewListarEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle8.ForeColor = Color.Black;
            DataGridViewListarEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle8;
            DataGridViewListarEmpleados.Size = new Size(497, 525);
            DataGridViewListarEmpleados.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Apellido";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Dni";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Email";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // AñadirEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 692);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirEmpleado";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label1;
        internal Panel Panel1;
        internal Button BRegistrarEmpleado;
        internal TextBox TBCorreoEmpleado;
        internal Label Label7;
        internal TextBox TBDireccionEmpleado;
        internal Label Label6;
        internal TextBox TBTelEmpleado;
        internal Label Label5;
        internal TextBox TBDniEmpleado;
        internal Label Label4;
        internal TextBox TBApellidoEmpleado;
        internal Label Label3;
        internal TextBox TBNombreEmpleado;
        internal Label Label2;
        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView DataGridViewListarEmpleados;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}