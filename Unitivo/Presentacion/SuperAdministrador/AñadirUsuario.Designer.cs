namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirUsuario
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            var DataGridViewCellStyle7 = new DataGridViewCellStyle();
            var DataGridViewCellStyle8 = new DataGridViewCellStyle();
            TabControlListaEmpleados = new TabControl();
            TabPageListaEmpleados = new TabPage();
            dgvEmpleados = new DataGridView();
           // dgvEmpleados.DoubleClick += new EventHandler(dgvEmpleados_DoubleClick);
           // dgvEmpleados.CellClick += new DataGridViewCellEventHandler(dgvEmpleados_CellClick);
            //dgvEmpleados.CellContentClick += new DataGridViewCellEventHandler(dgvEmpleados_CellContentClick);
            GroupBox3 = new GroupBox();
            TBEmpleado = new TextBox();
            Label1 = new Label();
            Label11 = new Label();
            TBNombreUsuario = new TextBox();
            //TBNombreUsuario.KeyPress += new KeyPressEventHandler(TBNombreUsuario_KeyPress);
            CBPerfil = new ComboBox();
            Label8 = new Label();
            TBContraseñaUsuario = new TextBox();
            TBConfirmarPass = new TextBox();
            Label9 = new Label();
            Label10 = new Label();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            TabControlRegUsuarios = new TabControl();
            TabPageListaUsuarios = new TabPage();
            dgvListaUsuarios = new DataGridView();
            BRegistrarUsuario = new Button();
            LRegistroUsuario = new Label();
            TabControlListaEmpleados.SuspendLayout();
            TabPageListaEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            GroupBox3.SuspendLayout();
            TabControlRegUsuarios.SuspendLayout();
            TabPageListaUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // TabControlListaEmpleados
            // 
            TabControlListaEmpleados.Controls.Add(TabPageListaEmpleados);
            TabControlListaEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaEmpleados.Location = new Point(332, 67);
            TabControlListaEmpleados.Margin = new Padding(2);
            TabControlListaEmpleados.Name = "TabControlListaEmpleados";
            TabControlListaEmpleados.SelectedIndex = 0;
            TabControlListaEmpleados.Size = new Size(468, 247);
            TabControlListaEmpleados.TabIndex = 36;
            // 
            // TabPageListaEmpleados
            // 
            TabPageListaEmpleados.Controls.Add(dgvEmpleados);
            TabPageListaEmpleados.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaEmpleados.ForeColor = Color.White;
            TabPageListaEmpleados.Location = new Point(4, 25);
            TabPageListaEmpleados.Margin = new Padding(2);
            TabPageListaEmpleados.Name = "TabPageListaEmpleados";
            TabPageListaEmpleados.Padding = new Padding(2);
            TabPageListaEmpleados.Size = new Size(460, 218);
            TabPageListaEmpleados.TabIndex = 0;
            TabPageListaEmpleados.Text = "Lista de Empleados";
            TabPageListaEmpleados.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AllowUserToDeleteRows = false;
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
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3;
            dgvEmpleados.RowHeadersWidth = 51;
            DataGridViewCellStyle4.ForeColor = Color.Black;
            dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle4;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.Size = new Size(456, 214);
            dgvEmpleados.TabIndex = 2;
            // 
            // GroupBox3
            // 
            GroupBox3.BackColor = Color.Cornsilk;
            GroupBox3.Controls.Add(TBEmpleado);
            GroupBox3.Controls.Add(Label1);
            GroupBox3.Controls.Add(Label11);
            GroupBox3.Controls.Add(TBNombreUsuario);
            GroupBox3.Controls.Add(CBPerfil);
            GroupBox3.Controls.Add(Label8);
            GroupBox3.Controls.Add(TBContraseñaUsuario);
            GroupBox3.Controls.Add(TBConfirmarPass);
            GroupBox3.Controls.Add(Label9);
            GroupBox3.Controls.Add(Label10);
            GroupBox3.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBox3.ForeColor = Color.DarkOliveGreen;
            GroupBox3.Location = new Point(12, 79);
            GroupBox3.Margin = new Padding(2);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Padding = new Padding(2);
            GroupBox3.Size = new Size(301, 232);
            GroupBox3.TabIndex = 35;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Nuevo Usuario";
            // 
            // TBEmpleado
            // 
            TBEmpleado.Enabled = false;
            TBEmpleado.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBEmpleado.Location = new Point(170, 189);
            TBEmpleado.Name = "TBEmpleado";
            TBEmpleado.Size = new Size(114, 23);
            TBEmpleado.TabIndex = 24;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.SaddleBrown;
            Label1.Location = new Point(13, 192);
            Label1.Name = "Label1";
            Label1.Size = new Size(113, 16);
            Label1.TabIndex = 23;
            Label1.Text = "ID de Empleado:";
            // 
            // Label11
            // 
            Label11.AutoSize = true;
            Label11.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label11.ForeColor = Color.SaddleBrown;
            Label11.Location = new Point(13, 117);
            Label11.Name = "Label11";
            Label11.Size = new Size(156, 16);
            Label11.TabIndex = 22;
            Label11.Text = "Confirmar Contraseña:";
            // 
            // TBNombreUsuario
            // 
            TBNombreUsuario.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBNombreUsuario.Location = new Point(170, 34);
            TBNombreUsuario.Name = "TBNombreUsuario";
            TBNombreUsuario.Size = new Size(114, 23);
            TBNombreUsuario.TabIndex = 20;
            // 
            // CBPerfil
            // 
            CBPerfil.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBPerfil.FormattingEnabled = true;
            CBPerfil.Location = new Point(170, 153);
            CBPerfil.Margin = new Padding(2);
            CBPerfil.Name = "CBPerfil";
            CBPerfil.Size = new Size(114, 24);
            CBPerfil.TabIndex = 18;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label8.ForeColor = Color.SaddleBrown;
            Label8.Location = new Point(13, 37);
            Label8.Name = "Label8";
            Label8.Size = new Size(136, 16);
            Label8.TabIndex = 0;
            Label8.Text = "Nombre de Usuario:";
            // 
            // TBContraseñaUsuario
            // 
            TBContraseñaUsuario.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBContraseñaUsuario.Location = new Point(170, 72);
            TBContraseñaUsuario.Name = "TBContraseñaUsuario";
            TBContraseñaUsuario.Size = new Size(114, 23);
            TBContraseñaUsuario.TabIndex = 6;
            // 
            // TBConfirmarPass
            // 
            TBConfirmarPass.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBConfirmarPass.Location = new Point(170, 115);
            TBConfirmarPass.Name = "TBConfirmarPass";
            TBConfirmarPass.Size = new Size(114, 23);
            TBConfirmarPass.TabIndex = 8;
            // 
            // Label9
            // 
            Label9.AutoSize = true;
            Label9.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label9.ForeColor = Color.SaddleBrown;
            Label9.Location = new Point(13, 155);
            Label9.Name = "Label9";
            Label9.Size = new Size(47, 16);
            Label9.TabIndex = 1;
            Label9.Text = "Perfil:";
            // 
            // Label10
            // 
            Label10.AutoSize = true;
            Label10.Font = new Font("Britannic Bold", 10.8f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label10.ForeColor = Color.SaddleBrown;
            Label10.Location = new Point(13, 74);
            Label10.Name = "Label10";
            Label10.Size = new Size(86, 16);
            Label10.TabIndex = 4;
            Label10.Text = "Contraseña:";
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderColor = Color.White;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(694, 450);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(100, 42);
            BVolver.TabIndex = 34;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // TabControlRegUsuarios
            // 
            TabControlRegUsuarios.Controls.Add(TabPageListaUsuarios);
            TabControlRegUsuarios.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlRegUsuarios.Location = new Point(12, 331);
            TabControlRegUsuarios.Margin = new Padding(2);
            TabControlRegUsuarios.Name = "TabControlRegUsuarios";
            TabControlRegUsuarios.SelectedIndex = 0;
            TabControlRegUsuarios.Size = new Size(665, 187);
            TabControlRegUsuarios.TabIndex = 32;
            // 
            // TabPageListaUsuarios
            // 
            TabPageListaUsuarios.Controls.Add(dgvListaUsuarios);
            TabPageListaUsuarios.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaUsuarios.ForeColor = Color.White;
            TabPageListaUsuarios.Location = new Point(4, 25);
            TabPageListaUsuarios.Margin = new Padding(2);
            TabPageListaUsuarios.Name = "TabPageListaUsuarios";
            TabPageListaUsuarios.Padding = new Padding(2);
            TabPageListaUsuarios.Size = new Size(657, 158);
            TabPageListaUsuarios.TabIndex = 0;
            TabPageListaUsuarios.Text = "Lista de Usuarios";
            TabPageListaUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.BackgroundColor = Color.RosyBrown;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle5.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5;
            dgvListaUsuarios.ColumnHeadersHeight = 20;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle6.BackColor = SystemColors.Window;
            DataGridViewCellStyle6.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle6.ForeColor = Color.White;
            DataGridViewCellStyle6.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = DataGridViewCellStyle6;
            dgvListaUsuarios.Dock = DockStyle.Fill;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;
            dgvListaUsuarios.Location = new Point(2, 2);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle7.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle7.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle7;
            dgvListaUsuarios.RowHeadersWidth = 51;
            DataGridViewCellStyle8.ForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle8;
            dgvListaUsuarios.Size = new Size(653, 154);
            dgvListaUsuarios.TabIndex = 2;
            // 
            // BRegistrarUsuario
            // 
            BRegistrarUsuario.BackColor = Color.DarkOliveGreen;
            BRegistrarUsuario.FlatAppearance.BorderColor = Color.White;
            BRegistrarUsuario.FlatAppearance.BorderSize = 2;
            BRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            BRegistrarUsuario.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BRegistrarUsuario.ForeColor = Color.White;
            BRegistrarUsuario.Location = new Point(694, 393);
            BRegistrarUsuario.Name = "BRegistrarUsuario";
            BRegistrarUsuario.Size = new Size(100, 41);
            BRegistrarUsuario.TabIndex = 33;
            BRegistrarUsuario.Text = "Registrar";
            BRegistrarUsuario.UseVisualStyleBackColor = false;
            // 
            // LRegistroUsuario
            // 
            LRegistroUsuario.AutoSize = true;
            LRegistroUsuario.BackColor = Color.Cornsilk;
            LRegistroUsuario.Font = new Font("Britannic Bold", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LRegistroUsuario.ForeColor = Color.DarkOliveGreen;
            LRegistroUsuario.Location = new Point(303, 11);
            LRegistroUsuario.Name = "LRegistroUsuario";
            LRegistroUsuario.Size = new Size(241, 32);
            LRegistroUsuario.TabIndex = 31;
            LRegistroUsuario.Text = "Registrar Usuario";
            // 
            // AñadirUsuario
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(850, 540);
            Controls.Add(TabControlListaEmpleados);
            Controls.Add(GroupBox3);
            Controls.Add(BVolver);
            Controls.Add(TabControlRegUsuarios);
            Controls.Add(BRegistrarUsuario);
            Controls.Add(LRegistroUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirUsuario";
            Text = "Form1";
            TabControlListaEmpleados.ResumeLayout(false);
            TabPageListaEmpleados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            TabControlRegUsuarios.ResumeLayout(false);
            TabPageListaUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            //Click += new EventHandler(AñadirUsuarios_Click);
            ResumeLayout(false);
            PerformLayout();

        }

        internal TabControl TabControlListaEmpleados;
        internal TabPage TabPageListaEmpleados;
        internal DataGridView dgvEmpleados;
        internal GroupBox GroupBox3;
        internal TextBox TBEmpleado;
        internal Label Label1;
        internal Label Label11;
        internal TextBox TBNombreUsuario;
        internal ComboBox CBPerfil;
        internal Label Label8;
        internal TextBox TBContraseñaUsuario;
        internal TextBox TBConfirmarPass;
        internal Label Label9;
        internal Label Label10;
        internal Button BVolver;
        internal TabControl TabControlRegUsuarios;
        internal TabPage TabPageListaUsuarios;
        internal DataGridView dgvListaUsuarios;
        internal Button BRegistrarUsuario;
        internal Label LRegistroUsuario;

        #endregion
    }
}