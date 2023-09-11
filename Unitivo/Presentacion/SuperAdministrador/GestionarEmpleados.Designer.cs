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
            var DataGridViewCellStyle1 = new DataGridViewCellStyle();
            var DataGridViewCellStyle2 = new DataGridViewCellStyle();
            var DataGridViewCellStyle3 = new DataGridViewCellStyle();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxGestionUsuarios = new GroupBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            TabListaEmpleados = new TabControl();
            TabPageEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
            BModificarEmpleado = new Button();
            BEliminarUsuario = new Button();
            BAltaEmpleado = new Button();
            GroupBoxGestionUsuarios.SuspendLayout();
            TabListaEmpleados.SuspendLayout();
            TabPageEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(590, 394);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 79;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(248, 18);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Size = new Size(323, 87);
            GroupBoxGestionUsuarios.TabIndex = 78;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Empleados";
            // 
            // BBuscarUsuario
            // 
            BBuscarUsuario.BackColor = Color.DarkOliveGreen;
            BBuscarUsuario.FlatAppearance.BorderColor = Color.White;
            BBuscarUsuario.FlatAppearance.BorderSize = 2;
            BBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BBuscarUsuario.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarUsuario.ForeColor = Color.White;
            BBuscarUsuario.Image =  Properties.Resources.icons8_búsqueda_26;
            BBuscarUsuario.Location = new Point(210, 34);
            BBuscarUsuario.Name = "BBuscarUsuario";
            BBuscarUsuario.Size = new Size(45, 41);
            BBuscarUsuario.TabIndex = 14;
            BBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TBGestionUsuario
            // 
            TBGestionUsuario.Font = new Font("Britannic Bold", 12.0f);
            TBGestionUsuario.Location = new Point(55, 43);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(131, 25);
            TBGestionUsuario.TabIndex = 6;
            // 
            // TabListaEmpleados
            // 
            TabListaEmpleados.Controls.Add(TabPageEmpleados);
            TabListaEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaEmpleados.Location = new Point(27, 110);
            TabListaEmpleados.Margin = new Padding(2);
            TabListaEmpleados.Name = "TabListaEmpleados";
            TabListaEmpleados.SelectedIndex = 0;
            TabListaEmpleados.Size = new Size(669, 269);
            TabListaEmpleados.TabIndex = 77;
            // 
            // TabPageEmpleados
            // 
            TabPageEmpleados.Controls.Add(dgvEmpleados);
            TabPageEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageEmpleados.ForeColor = Color.White;
            TabPageEmpleados.Location = new Point(4, 25);
            TabPageEmpleados.Margin = new Padding(2);
            TabPageEmpleados.Name = "TabPageEmpleados";
            TabPageEmpleados.Padding = new Padding(2);
            TabPageEmpleados.Size = new Size(661, 240);
            TabPageEmpleados.TabIndex = 0;
            TabPageEmpleados.Text = "Lista de Empleados";
            TabPageEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToAddRows = false;
            dgvEmpleados.AllowUserToDeleteRows = false;
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmpleados.BackgroundColor = Color.RosyBrown;
            dgvEmpleados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvEmpleados.ColumnHeadersHeight = 20;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.Window;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = Color.White;
            DataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2;
            dgvEmpleados.Dock = DockStyle.Fill;
            dgvEmpleados.EnableHeadersVisualStyles = false;
            dgvEmpleados.Location = new Point(2, 2);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.ReadOnly = true;
            dgvEmpleados.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEmpleados.RowHeadersWidth = 51;
            DataGridViewCellStyle3.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle3;
            dgvEmpleados.Size = new Size(657, 236);
            dgvEmpleados.TabIndex = 2;
            // 
            // BModificarEmpleado
            // 
            BModificarEmpleado.BackColor = Color.SteelBlue;
            BModificarEmpleado.ForeColor = Color.White;
            BModificarEmpleado.Image =  Properties.Resources.icons8_editar_archivo_26;
            BModificarEmpleado.Location = new Point(724, 204);
            BModificarEmpleado.Name = "BModificarEmpleado";
            BModificarEmpleado.Size = new Size(50, 45);
            BModificarEmpleado.TabIndex = 76;
            BModificarEmpleado.UseVisualStyleBackColor = false;
            // 
            // BEliminarUsuario
            // 
            BEliminarUsuario.BackColor = Color.Brown;
            BEliminarUsuario.ForeColor = Color.White;
            BEliminarUsuario.Image = Properties.Resources.icons8_basura_26;
            BEliminarUsuario.Location = new Point(724, 265);
            BEliminarUsuario.Name = "BEliminarUsuario";
            BEliminarUsuario.Size = new Size(50, 45);
            BEliminarUsuario.TabIndex = 75;
            BEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // BAltaEmpleado
            // 
            BAltaEmpleado.BackColor = Color.DarkOliveGreen;
            BAltaEmpleado.ForeColor = Color.White;
            BAltaEmpleado.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaEmpleado.Location = new Point(724, 265);
            BAltaEmpleado.Name = "BAltaEmpleado";
            BAltaEmpleado.Size = new Size(50, 45);
            BAltaEmpleado.TabIndex = 80;
            BAltaEmpleado.UseVisualStyleBackColor = false;
            // 
            // GestionarEmpleados
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(TabListaEmpleados);
            Controls.Add(BModificarEmpleado);
            Controls.Add(BEliminarUsuario);
            Controls.Add(BAltaEmpleado);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarEmpleados";
            Text = "Form1";
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabListaEmpleados.ResumeLayout(false);
            TabPageEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;
        internal TabControl TabListaEmpleados;
        internal TabPage TabPageEmpleados;
        internal DataGridView dgvEmpleados;
        internal Button BModificarEmpleado;
        internal Button BEliminarUsuario;
        internal Button BAltaEmpleado;

        #endregion
    }
}