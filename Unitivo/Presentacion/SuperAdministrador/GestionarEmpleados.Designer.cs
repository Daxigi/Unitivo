namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarEmpleados
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            GroupBoxGestionUsuarios = new GroupBox();
            Label2 = new Label();
            ComboBoxBuscarDni = new ComboBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            BModificarEmpleado = new Button();
            BEliminarEmpleado = new Button();
            BAltaEmpleado = new Button();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            GroupBoxGestionUsuarios.SuspendLayout();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(Label2);
            GroupBoxGestionUsuarios.Controls.Add(ComboBoxBuscarDni);
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(210, 38);
            GroupBoxGestionUsuarios.Margin = new Padding(4, 5, 4, 5);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Padding = new Padding(4, 5, 4, 5);
            GroupBoxGestionUsuarios.Size = new Size(600, 144);
            GroupBoxGestionUsuarios.TabIndex = 78;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Empleados";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Label2.ForeColor = Color.DarkOliveGreen;
            Label2.Location = new Point(52, 48);
            Label2.Margin = new Padding(5, 0, 5, 0);
            Label2.Name = "Label2";
            Label2.Size = new Size(112, 25);
            Label2.TabIndex = 16;
            Label2.Text = "Buscar por:";
            // 
            // ComboBoxBuscarDni
            // 
            ComboBoxBuscarDni.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBoxBuscarDni.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ComboBoxBuscarDni.ForeColor = Color.SaddleBrown;
            ComboBoxBuscarDni.FormattingEnabled = true;
            ComboBoxBuscarDni.Items.AddRange(new object[] { "DNI", "Nombre y Apellido" });
            ComboBoxBuscarDni.Location = new Point(56, 77);
            ComboBoxBuscarDni.Margin = new Padding(4, 5, 4, 5);
            ComboBoxBuscarDni.Name = "ComboBoxBuscarDni";
            ComboBoxBuscarDni.Size = new Size(160, 31);
            ComboBoxBuscarDni.TabIndex = 15;
            // 
            // BBuscarUsuario
            // 
            BBuscarUsuario.BackColor = Color.DarkOliveGreen;
            BBuscarUsuario.FlatAppearance.BorderColor = Color.White;
            BBuscarUsuario.FlatAppearance.BorderSize = 2;
            BBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BBuscarUsuario.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarUsuario.ForeColor = Color.White;
            BBuscarUsuario.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarUsuario.Location = new Point(487, 48);
            BBuscarUsuario.Margin = new Padding(4, 5, 4, 5);
            BBuscarUsuario.Name = "BBuscarUsuario";
            BBuscarUsuario.Size = new Size(60, 63);
            BBuscarUsuario.TabIndex = 14;
            BBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TBGestionUsuario
            // 
            TBGestionUsuario.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionUsuario.Location = new Point(276, 75);
            TBGestionUsuario.Margin = new Padding(4, 5, 4, 5);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(173, 30);
            TBGestionUsuario.TabIndex = 6;
            TBGestionUsuario.KeyPress += NumStr_KeyPress;
            // 
            // BModificarEmpleado
            // 
            BModificarEmpleado.BackColor = Color.SteelBlue;
            BModificarEmpleado.ForeColor = Color.White;
            BModificarEmpleado.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarEmpleado.Location = new Point(987, 360);
            BModificarEmpleado.Margin = new Padding(4, 5, 4, 5);
            BModificarEmpleado.Name = "BModificarEmpleado";
            BModificarEmpleado.Size = new Size(67, 69);
            BModificarEmpleado.TabIndex = 76;
            BModificarEmpleado.UseVisualStyleBackColor = false;
            BModificarEmpleado.Click += BModificarEmpleado_Click;
            // 
            // BEliminarEmpleado
            // 
            BEliminarEmpleado.BackColor = Color.Brown;
            BEliminarEmpleado.ForeColor = Color.White;
            BEliminarEmpleado.Image = Properties.Resources.icons8_basura_26;
            BEliminarEmpleado.Location = new Point(987, 454);
            BEliminarEmpleado.Margin = new Padding(4, 5, 4, 5);
            BEliminarEmpleado.Name = "BEliminarEmpleado";
            BEliminarEmpleado.Size = new Size(67, 69);
            BEliminarEmpleado.TabIndex = 75;
            BEliminarEmpleado.UseVisualStyleBackColor = false;
            BEliminarEmpleado.Click += BEliminarEmpleado_Click;
            // 
            // BAltaEmpleado
            // 
            BAltaEmpleado.BackColor = Color.DarkOliveGreen;
            BAltaEmpleado.ForeColor = Color.White;
            BAltaEmpleado.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaEmpleado.Location = new Point(987, 454);
            BAltaEmpleado.Margin = new Padding(4, 5, 4, 5);
            BAltaEmpleado.Name = "BAltaEmpleado";
            BAltaEmpleado.Size = new Size(67, 69);
            BAltaEmpleado.TabIndex = 80;
            BAltaEmpleado.UseVisualStyleBackColor = false;
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlListaEmpleados.Location = new Point(30, 218);
            TabControlListaEmpleados.Margin = new Padding(4, 3, 4, 3);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(944, 412);
            TabControlListaEmpleados.TabIndex = 81;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(dgvEmpleados);
            TabPageListaEmpleados.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 28);
            TabPageListaEmpleados.Margin = new Padding(4, 3, 4, 3);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(4, 3, 4, 3);
            TabPageListaEmpleados.Size = new Size(936, 380);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 20;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEmpleados.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = dataGridViewCellStyle2;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(4, 3);
            dgvEmpleados.Margin = new Padding(5, 6, 5, 6);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvEmpleados.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmpleados.Size = new Size(928, 374);
            dgvEmpleados.TabIndex = 2;
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
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 908);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(BModificarEmpleado);
            Controls.Add(BEliminarEmpleado);
            Controls.Add(BAltaEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarEmpleados";
            Text = "Form1";
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;
        internal Button BModificarEmpleado;
        internal Button BEliminarEmpleado;
        internal Button BAltaEmpleado;

        #endregion

        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView dgvEmpleados;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        internal Label Label2;
        internal ComboBox ComboBoxBuscarDni;
    }
}