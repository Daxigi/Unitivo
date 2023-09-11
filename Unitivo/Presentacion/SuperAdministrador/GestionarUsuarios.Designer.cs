namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarUsuarios
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
            var DataGridViewCellStyle4 = new DataGridViewCellStyle();
            var DataGridViewCellStyle5 = new DataGridViewCellStyle();
            var DataGridViewCellStyle6 = new DataGridViewCellStyle();
            BModificarUsuario = new Button();
            //BModificarUsuario.Click += new EventHandler(BModificarUsuario_Click);
            BEliminarUsuario = new Button();
            //BEliminarUsuario.Click += new EventHandler(BEliminarUsuario_Click);
            GroupBoxGestionUsuarios = new GroupBox();
            BBuscarUsuario = new Button();
            TBGestionUsuario = new TextBox();
            TabListaClientes = new TabControl();
            TabPageUsuarios = new TabPage();
            dgvListaUsuarios = new DataGridView();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            GroupBoxGestionUsuarios.SuspendLayout();
            TabListaClientes.SuspendLayout();
            TabPageUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).BeginInit();
            SuspendLayout();
            // 
            // BModificarUsuario
            // 
            BModificarUsuario.BackColor = Color.SteelBlue;
            BModificarUsuario.ForeColor = Color.White;
            BModificarUsuario.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarUsuario.Location = new Point(724, 223);
            BModificarUsuario.Name = "BModificarUsuario";
            BModificarUsuario.Size = new Size(50, 45);
            BModificarUsuario.TabIndex = 71;
            BModificarUsuario.UseVisualStyleBackColor = false;
            // 
            // BEliminarUsuario
            // 
            BEliminarUsuario.BackColor = Color.Brown;
            BEliminarUsuario.ForeColor = Color.White;
            BEliminarUsuario.Image = Properties.Resources.icons8_basura_26;
            BEliminarUsuario.Location = new Point(724, 284);
            BEliminarUsuario.Name = "BEliminarUsuario";
            BEliminarUsuario.Size = new Size(50, 45);
            BEliminarUsuario.TabIndex = 70;
            BEliminarUsuario.UseVisualStyleBackColor = false;
            // 
            // GroupBoxGestionUsuarios
            // 
            GroupBoxGestionUsuarios.BackColor = Color.Cornsilk;
            GroupBoxGestionUsuarios.Controls.Add(BBuscarUsuario);
            GroupBoxGestionUsuarios.Controls.Add(TBGestionUsuario);
            GroupBoxGestionUsuarios.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxGestionUsuarios.ForeColor = Color.Sienna;
            GroupBoxGestionUsuarios.Location = new Point(248, 37);
            GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios";
            GroupBoxGestionUsuarios.Size = new Size(261, 76);
            GroupBoxGestionUsuarios.TabIndex = 73;
            GroupBoxGestionUsuarios.TabStop = false;
            GroupBoxGestionUsuarios.Text = "Gestión de Usuarios";
            // 
            // BBuscarUsuario
            // 
            BBuscarUsuario.BackColor = Color.DarkOliveGreen;
            BBuscarUsuario.FlatAppearance.BorderColor = Color.White;
            BBuscarUsuario.FlatAppearance.BorderSize = 2;
            BBuscarUsuario.FlatStyle = FlatStyle.Flat;
            BBuscarUsuario.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BBuscarUsuario.ForeColor = Color.White;
            BBuscarUsuario.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarUsuario.Location = new Point(186, 26);
            BBuscarUsuario.Name = "BBuscarUsuario";
            BBuscarUsuario.Size = new Size(45, 41);
            BBuscarUsuario.TabIndex = 14;
            BBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // TBGestionUsuario
            // 
            TBGestionUsuario.Font = new Font("Britannic Bold", 12.0f);
            TBGestionUsuario.Location = new Point(31, 35);
            TBGestionUsuario.Name = "TBGestionUsuario";
            TBGestionUsuario.Size = new Size(131, 25);
            TBGestionUsuario.TabIndex = 6;
            // 
            // TabListaClientes
            // 
            TabListaClientes.Controls.Add(TabPageUsuarios);
            TabListaClientes.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabListaClientes.Location = new Point(27, 129);
            TabListaClientes.Margin = new Padding(2);
            TabListaClientes.Name = "TabListaClientes";
            TabListaClientes.SelectedIndex = 0;
            TabListaClientes.Size = new Size(669, 269);
            TabListaClientes.TabIndex = 72;
            // 
            // TabPageUsuarios
            // 
            TabPageUsuarios.Controls.Add(dgvListaUsuarios);
            TabPageUsuarios.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageUsuarios.ForeColor = Color.White;
            TabPageUsuarios.Location = new Point(4, 25);
            TabPageUsuarios.Margin = new Padding(2);
            TabPageUsuarios.Name = "TabPageUsuarios";
            TabPageUsuarios.Padding = new Padding(2);
            TabPageUsuarios.Size = new Size(661, 240);
            TabPageUsuarios.TabIndex = 0;
            TabPageUsuarios.Text = "Lista de Usuarios";
            TabPageUsuarios.UseVisualStyleBackColor = true;
            // 
            // dgvListaUsuarios
            // 
            dgvListaUsuarios.AllowUserToAddRows = false;
            dgvListaUsuarios.AllowUserToDeleteRows = false;
            dgvListaUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListaUsuarios.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListaUsuarios.BackgroundColor = Color.RosyBrown;
            dgvListaUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle4.BackColor = Color.FromArgb(255, 128, 0);
            DataGridViewCellStyle4.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle4.ForeColor = Color.White;
            DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4;
            dgvListaUsuarios.ColumnHeadersHeight = 20;
            dgvListaUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle5.BackColor = SystemColors.Window;
            DataGridViewCellStyle5.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle5.ForeColor = Color.White;
            DataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvListaUsuarios.DefaultCellStyle = DataGridViewCellStyle5;
            dgvListaUsuarios.Dock = DockStyle.Fill;
            dgvListaUsuarios.EnableHeadersVisualStyles = false;
            dgvListaUsuarios.Location = new Point(2, 2);
            dgvListaUsuarios.Name = "dgvListaUsuarios";
            dgvListaUsuarios.ReadOnly = true;
            dgvListaUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvListaUsuarios.RowHeadersWidth = 51;
            DataGridViewCellStyle6.ForeColor = Color.Black;
            dgvListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle6;
            dgvListaUsuarios.Size = new Size(657, 236);
            dgvListaUsuarios.TabIndex = 2;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(590, 413);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 74;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // GestionarUsuarios
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 480);
            Controls.Add(BVolver);
            Controls.Add(GroupBoxGestionUsuarios);
            Controls.Add(TabListaClientes);
            Controls.Add(BModificarUsuario);
            Controls.Add(BEliminarUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarUsuarios";
            Text = "Form1";
            GroupBoxGestionUsuarios.ResumeLayout(false);
            GroupBoxGestionUsuarios.PerformLayout();
            TabListaClientes.ResumeLayout(false);
            TabPageUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListaUsuarios).EndInit();
            ResumeLayout(false);

        }

        internal Button BModificarUsuario;
        internal Button BEliminarUsuario;
        internal GroupBox GroupBoxGestionUsuarios;
        internal Button BBuscarUsuario;
        internal TextBox TBGestionUsuario;
        internal TabControl TabListaClientes;
        internal TabPage TabPageUsuarios;
        internal DataGridView dgvListaUsuarios;
        internal Button BVolver;

        #endregion
    }
}