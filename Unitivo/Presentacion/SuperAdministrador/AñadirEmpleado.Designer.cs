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
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            Label1 = new Label();
            Panel1 = new Panel();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            BRegistrarEmpleado = new Button();
            TBCorreoEmpleado = new TextBox();
            Label7 = new Label();
            TBDireccionEmpleado = new TextBox();
            Label6 = new Label();
            TBTelEmpleado = new TextBox();
            //TBTelEmpleado.KeyPress += new KeyPressEventHandler(TBVerificarNumeros_KeyPress);
            Label5 = new Label();
            TBDniEmpleado = new TextBox();
            //TBDniEmpleado.KeyPress += new KeyPressEventHandler(TBVerificarNumeros_KeyPress);
            Label4 = new Label();
            TBApellidoEmpleado = new TextBox();
            //TBApellidoEmpleado.KeyPress += new KeyPressEventHandler(TBVerficarLetra_KeyPress);
            Label3 = new Label();
            TBNombreEmpleado = new TextBox();
            //TBNombreEmpleado.KeyPress += new KeyPressEventHandler(TBVerficarLetra_KeyPress);
            Label2 = new Label();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
            Panel1.SuspendLayout();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(41, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(322, 40);
            Label1.TabIndex = 4;
            Label1.Text = "Registrar Cliente";
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BVolver);
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
            Panel1.Location = new Point(40, 82);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(323, 340);
            Panel1.TabIndex = 3;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(37, 268);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 18;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BRegistrarEmpleado
            // 
            BRegistrarEmpleado.BackColor = Color.DarkOliveGreen;
            BRegistrarEmpleado.FlatAppearance.BorderSize = 2;
            BRegistrarEmpleado.FlatStyle = FlatStyle.Flat;
            BRegistrarEmpleado.Font = new Font("Cooper Black", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BRegistrarEmpleado.ForeColor = Color.Cornsilk;
            BRegistrarEmpleado.Location = new Point(166, 268);
            BRegistrarEmpleado.Name = "BRegistrarEmpleado";
            BRegistrarEmpleado.Size = new Size(133, 38);
            BRegistrarEmpleado.TabIndex = 17;
            BRegistrarEmpleado.Text = "Añadir";
            BRegistrarEmpleado.UseVisualStyleBackColor = false;
            // 
            // TBCorreoEmpleado
            // 
            TBCorreoEmpleado.Location = new Point(160, 209);
            TBCorreoEmpleado.Name = "TBCorreoEmpleado";
            TBCorreoEmpleado.Size = new Size(128, 20);
            TBCorreoEmpleado.TabIndex = 16;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(35, 206);
            Label7.Name = "Label7";
            Label7.Size = new Size(85, 23);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccionEmpleado
            // 
            TBDireccionEmpleado.Location = new Point(160, 173);
            TBDireccionEmpleado.Name = "TBDireccionEmpleado";
            TBDireccionEmpleado.Size = new Size(128, 20);
            TBDireccionEmpleado.TabIndex = 14;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(35, 170);
            Label6.Name = "Label6";
            Label6.Size = new Size(120, 23);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelEmpleado
            // 
            TBTelEmpleado.Location = new Point(160, 136);
            TBTelEmpleado.Name = "TBTelEmpleado";
            TBTelEmpleado.Size = new Size(128, 20);
            TBTelEmpleado.TabIndex = 12;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(35, 133);
            Label5.Name = "Label5";
            Label5.Size = new Size(109, 23);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniEmpleado
            // 
            TBDniEmpleado.Location = new Point(160, 98);
            TBDniEmpleado.Name = "TBDniEmpleado";
            TBDniEmpleado.Size = new Size(128, 20);
            TBDniEmpleado.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(35, 95);
            Label4.Name = "Label4";
            Label4.Size = new Size(62, 23);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoEmpleado
            // 
            TBApellidoEmpleado.Location = new Point(160, 59);
            TBApellidoEmpleado.Name = "TBApellidoEmpleado";
            TBApellidoEmpleado.Size = new Size(128, 20);
            TBApellidoEmpleado.TabIndex = 8;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(35, 56);
            Label3.Name = "Label3";
            Label3.Size = new Size(108, 23);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreEmpleado
            // 
            TBNombreEmpleado.Location = new Point(160, 20);
            TBNombreEmpleado.Name = "TBNombreEmpleado";
            TBNombreEmpleado.Size = new Size(128, 20);
            TBNombreEmpleado.TabIndex = 6;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(35, 17);
            Label2.Name = "Label2";
            Label2.Size = new Size(104, 23);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaEmpleados.Location = new Point(400, 56);
            TabControlListaEmpleados.Margin = new Padding(3, 2, 3, 2);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(385, 366);
            TabControlListaEmpleados.TabIndex = 13;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(dgvEmpleados);
            TabPageListaEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 25);
            TabPageListaEmpleados.Margin = new Padding(3, 2, 3, 2);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(3, 2, 3, 2);
            TabPageListaEmpleados.Size = new Size(377, 337);
            TabPageListaEmpleados.TabIndex = 0;
            TabPageListaEmpleados.Text = "Lista de Empleados";
            TabPageListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.BackgroundColor = Color.RosyBrown;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle5.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvEmpleados.ColumnHeadersHeight = 20;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = SystemColors.Window;
            DataGridViewCellStyle6.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = Color.White;
            DataGridViewCellStyle6.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle6;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(3, 2);
            dgvEmpleados.Margin = new Padding(4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle7;
            dgvEmpleados.RowHeadersWidth = 51;
            DataGridViewCellStyle8.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle8;
            dgvEmpleados.Size = new Size(371, 333);
            dgvEmpleados.TabIndex = 2;
            // 
            // AñadirEmpleado
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(810, 450);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirEmpleado";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Label Label1;
        internal Panel Panel1;
        internal Button BVolver;
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
        internal DataGridView dgvEmpleados;

        #endregion
    }
}