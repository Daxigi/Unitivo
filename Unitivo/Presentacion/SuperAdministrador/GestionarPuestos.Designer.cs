namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class GestionarPuestos
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
            GroupBoxGestionPerfil = new GroupBox();
            BBuscarPerfil = new Button();
            TBGestionPerfil = new TextBox();
            BModificarPerfiles = new Button();
            BEliminarPerfiles = new Button();
            BAltaPerfil = new Button();
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            dgvRegistroPerfil = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            GroupBoxDatosPerfil = new GroupBox();
            BModEmpleado = new Button();
            TBModPerfil = new TextBox();
            LModPerfil = new Label();
            GroupBoxGestionPerfil.SuspendLayout();
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroPerfil).BeginInit();
            GroupBoxDatosPerfil.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBoxGestionPerfil
            // 
            GroupBoxGestionPerfil.BackColor = Color.Cornsilk;
            GroupBoxGestionPerfil.Controls.Add(BBuscarPerfil);
            GroupBoxGestionPerfil.Controls.Add(TBGestionPerfil);
            GroupBoxGestionPerfil.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionPerfil.ForeColor = Color.Sienna;
            GroupBoxGestionPerfil.Location = new Point(334, 34);
            GroupBoxGestionPerfil.Margin = new Padding(4, 5, 4, 5);
            GroupBoxGestionPerfil.Name = "GroupBoxGestionPerfil";
            GroupBoxGestionPerfil.Padding = new Padding(4, 5, 4, 5);
            GroupBoxGestionPerfil.Size = new Size(407, 127);
            GroupBoxGestionPerfil.TabIndex = 84;
            GroupBoxGestionPerfil.TabStop = false;
            GroupBoxGestionPerfil.Text = "Gestión de Puestos";
            // 
            // BBuscarPerfil
            // 
            BBuscarPerfil.BackColor = Color.DarkOliveGreen;
            BBuscarPerfil.FlatAppearance.BorderColor = Color.White;
            BBuscarPerfil.FlatAppearance.BorderSize = 2;
            BBuscarPerfil.FlatStyle = FlatStyle.Flat;
            BBuscarPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarPerfil.ForeColor = Color.White;
            BBuscarPerfil.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarPerfil.Location = new Point(289, 48);
            BBuscarPerfil.Margin = new Padding(4, 5, 4, 5);
            BBuscarPerfil.Name = "BBuscarPerfil";
            BBuscarPerfil.Size = new Size(60, 56);
            BBuscarPerfil.TabIndex = 14;
            BBuscarPerfil.UseVisualStyleBackColor = false;
            // 
            // TBGestionPerfil
            // 
            TBGestionPerfil.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBGestionPerfil.Location = new Point(75, 61);
            TBGestionPerfil.Margin = new Padding(4, 5, 4, 5);
            TBGestionPerfil.Name = "TBGestionPerfil";
            TBGestionPerfil.Size = new Size(173, 30);
            TBGestionPerfil.TabIndex = 6;
            TBGestionPerfil.KeyPress += String_KeyPress;
            // 
            // BModificarPerfiles
            // 
            BModificarPerfiles.BackColor = Color.SteelBlue;
            BModificarPerfiles.ForeColor = Color.White;
            BModificarPerfiles.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarPerfiles.Location = new Point(954, 337);
            BModificarPerfiles.Margin = new Padding(4, 5, 4, 5);
            BModificarPerfiles.Name = "BModificarPerfiles";
            BModificarPerfiles.Size = new Size(67, 69);
            BModificarPerfiles.TabIndex = 82;
            BModificarPerfiles.UseVisualStyleBackColor = false;
            // 
            // BEliminarPerfiles
            // 
            BEliminarPerfiles.BackColor = Color.Brown;
            BEliminarPerfiles.ForeColor = Color.White;
            BEliminarPerfiles.Image = Properties.Resources.icons8_basura_26;
            BEliminarPerfiles.Location = new Point(954, 431);
            BEliminarPerfiles.Margin = new Padding(4, 5, 4, 5);
            BEliminarPerfiles.Name = "BEliminarPerfiles";
            BEliminarPerfiles.Size = new Size(67, 69);
            BEliminarPerfiles.TabIndex = 81;
            BEliminarPerfiles.UseVisualStyleBackColor = false;
            BEliminarPerfiles.Click += BEliminarPerfiles_Click;
            // 
            // BAltaPerfil
            // 
            BAltaPerfil.BackColor = Color.DarkOliveGreen;
            BAltaPerfil.ForeColor = Color.White;
            BAltaPerfil.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaPerfil.Location = new Point(954, 431);
            BAltaPerfil.Margin = new Padding(4, 5, 4, 5);
            BAltaPerfil.Name = "BAltaPerfil";
            BAltaPerfil.Size = new Size(67, 69);
            BAltaPerfil.TabIndex = 86;
            BAltaPerfil.UseVisualStyleBackColor = false;
            // 
            // TabControlRegPerfil
            // 
            TabControlRegPerfil.Controls.Add(TabPageListaPerfil);
            TabControlRegPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegPerfil.Location = new Point(72, 234);
            TabControlRegPerfil.Name = "TabControlRegPerfil";
            TabControlRegPerfil.SelectedIndex = 0;
            TabControlRegPerfil.Size = new Size(833, 317);
            TabControlRegPerfil.TabIndex = 87;
            // 
            // TabPageListaPerfil
            // 
            TabPageListaPerfil.Controls.Add(dgvRegistroPerfil);
            TabPageListaPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 28);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(3);
            TabPageListaPerfil.Size = new Size(825, 285);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Puestos";
            TabPageListaPerfil.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroPerfil
            // 
            dgvRegistroPerfil.AllowUserToAddRows = false;
            dgvRegistroPerfil.AllowUserToDeleteRows = false;
            dgvRegistroPerfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroPerfil.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroPerfil.BackgroundColor = Color.RosyBrown;
            dgvRegistroPerfil.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRegistroPerfil.ColumnHeadersHeight = 20;
            dgvRegistroPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroPerfil.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            dgvRegistroPerfil.Dock = DockStyle.Fill;
            dgvRegistroPerfil.EnableHeadersVisualStyles = false;
            dgvRegistroPerfil.Location = new Point(3, 3);
            dgvRegistroPerfil.Name = "dgvRegistroPerfil";
            dgvRegistroPerfil.ReadOnly = true;
            dgvRegistroPerfil.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistroPerfil.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRegistroPerfil.RowHeadersWidth = 51;
            dgvRegistroPerfil.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroPerfil.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroPerfil.RowTemplate.Height = 24;
            dgvRegistroPerfil.Size = new Size(819, 279);
            dgvRegistroPerfil.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            // 
            // GroupBoxDatosPerfil
            // 
            GroupBoxDatosPerfil.BackColor = Color.RosyBrown;
            GroupBoxDatosPerfil.Controls.Add(BModEmpleado);
            GroupBoxDatosPerfil.Controls.Add(TBModPerfil);
            GroupBoxDatosPerfil.Controls.Add(LModPerfil);
            GroupBoxDatosPerfil.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxDatosPerfil.ForeColor = Color.White;
            GroupBoxDatosPerfil.Location = new Point(257, 636);
            GroupBoxDatosPerfil.Margin = new Padding(4, 5, 4, 5);
            GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil";
            GroupBoxDatosPerfil.Padding = new Padding(4, 5, 4, 5);
            GroupBoxDatosPerfil.Size = new Size(522, 207);
            GroupBoxDatosPerfil.TabIndex = 88;
            GroupBoxDatosPerfil.TabStop = false;
            GroupBoxDatosPerfil.Text = "Modificar Puesto";
            // 
            // BModEmpleado
            // 
            BModEmpleado.BackColor = Color.DarkOliveGreen;
            BModEmpleado.FlatAppearance.BorderSize = 2;
            BModEmpleado.FlatStyle = FlatStyle.Flat;
            BModEmpleado.Font = new Font("Cooper Black", 16F, FontStyle.Regular, GraphicsUnit.Point);
            BModEmpleado.ForeColor = Color.White;
            BModEmpleado.Location = new Point(321, 102);
            BModEmpleado.Margin = new Padding(4, 5, 4, 5);
            BModEmpleado.Name = "BModEmpleado";
            BModEmpleado.Size = new Size(166, 58);
            BModEmpleado.TabIndex = 18;
            BModEmpleado.Text = "Modificar";
            BModEmpleado.UseVisualStyleBackColor = false;
            // 
            // TBModPerfil
            // 
            TBModPerfil.Location = new Point(64, 110);
            TBModPerfil.Margin = new Padding(4, 5, 4, 5);
            TBModPerfil.Name = "TBModPerfil";
            TBModPerfil.Size = new Size(221, 42);
            TBModPerfil.TabIndex = 16;
            // 
            // LModPerfil
            // 
            LModPerfil.AutoSize = true;
            LModPerfil.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LModPerfil.ForeColor = Color.White;
            LModPerfil.Location = new Point(61, 67);
            LModPerfil.Margin = new Padding(8, 0, 8, 0);
            LModPerfil.Name = "LModPerfil";
            LModPerfil.Size = new Size(98, 27);
            LModPerfil.TabIndex = 15;
            LModPerfil.Text = "Puesto: ";
            // 
            // GestionarPuestos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 908);
            Controls.Add(GroupBoxDatosPerfil);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(GroupBoxGestionPerfil);
            Controls.Add(BModificarPerfiles);
            Controls.Add(BEliminarPerfiles);
            Controls.Add(BAltaPerfil);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarPuestos";
            Text = "Form1";
            GroupBoxGestionPerfil.ResumeLayout(false);
            GroupBoxGestionPerfil.PerformLayout();
            TabControlRegPerfil.ResumeLayout(false);
            TabPageListaPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroPerfil).EndInit();
            GroupBoxDatosPerfil.ResumeLayout(false);
            GroupBoxDatosPerfil.PerformLayout();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionPerfil;
        internal Button BBuscarPerfil;
        internal TextBox TBGestionPerfil;
        internal Button BModificarPerfiles;
        internal Button BEliminarPerfiles;
        internal Button BAltaPerfil;

        #endregion

        internal TabControl TabControlRegPerfil;
        internal TabPage TabPageListaPerfil;
        internal DataGridView dgvRegistroPerfil;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
        internal GroupBox GroupBoxDatosPerfil;
        internal TextBox TBModPerfil;
        internal Label LModPerfil;
        internal Button BModEmpleado;
    }
}