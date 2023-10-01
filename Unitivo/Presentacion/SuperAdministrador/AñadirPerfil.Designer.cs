namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirPerfil
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
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            dgvRegistroPerfil = new DataGridView();
            PanelRegClientes = new Panel();
            BRegistrarPerfil = new Button();
            TBNombrePerfil = new TextBox();
            LNombrePerfil = new Label();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroPerfil).BeginInit();
            PanelRegClientes.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegPerfil
            // 
            TabControlRegPerfil.Controls.Add(TabPageListaPerfil);
            TabControlRegPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabControlRegPerfil.Location = new Point(147, 279);
            TabControlRegPerfil.Name = "TabControlRegPerfil";
            TabControlRegPerfil.SelectedIndex = 0;
            TabControlRegPerfil.Size = new Size(713, 372);
            TabControlRegPerfil.TabIndex = 13;
            // 
            // TabPageListaPerfil
            // 
            TabPageListaPerfil.Controls.Add(dgvRegistroPerfil);
            TabPageListaPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 28);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(3, 3, 3, 3);
            TabPageListaPerfil.Size = new Size(705, 340);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Perfil";
            TabPageListaPerfil.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroPerfil
            // 
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
            dgvRegistroPerfil.Size = new Size(699, 334);
            dgvRegistroPerfil.TabIndex = 0;
            // 
            // PanelRegClientes
            // 
            PanelRegClientes.BackColor = Color.Cornsilk;
            PanelRegClientes.BackgroundImageLayout = ImageLayout.None;
            PanelRegClientes.Controls.Add(BRegistrarPerfil);
            PanelRegClientes.Controls.Add(TBNombrePerfil);
            PanelRegClientes.Controls.Add(LNombrePerfil);
            PanelRegClientes.Location = new Point(226, 76);
            PanelRegClientes.Margin = new Padding(4, 5, 4, 5);
            PanelRegClientes.Name = "PanelRegClientes";
            PanelRegClientes.Size = new Size(577, 172);
            PanelRegClientes.TabIndex = 12;
            // 
            // BRegistrarPerfil
            // 
            BRegistrarPerfil.BackColor = Color.DarkOliveGreen;
            BRegistrarPerfil.FlatAppearance.BorderColor = Color.White;
            BRegistrarPerfil.FlatAppearance.BorderSize = 2;
            BRegistrarPerfil.FlatStyle = FlatStyle.Flat;
            BRegistrarPerfil.Font = new Font("Britannic Bold", 13F, FontStyle.Regular, GraphicsUnit.Point);
            BRegistrarPerfil.ForeColor = Color.White;
            BRegistrarPerfil.Location = new Point(424, 74);
            BRegistrarPerfil.Margin = new Padding(4, 5, 4, 5);
            BRegistrarPerfil.Name = "BRegistrarPerfil";
            BRegistrarPerfil.Size = new Size(131, 65);
            BRegistrarPerfil.TabIndex = 13;
            BRegistrarPerfil.Text = "Añadir";
            BRegistrarPerfil.UseVisualStyleBackColor = false;
            // 
            // TBNombrePerfil
            // 
            TBNombrePerfil.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBNombrePerfil.Location = new Point(27, 89);
            TBNombrePerfil.Margin = new Padding(4, 5, 4, 5);
            TBNombrePerfil.Name = "TBNombrePerfil";
            TBNombrePerfil.Size = new Size(371, 30);
            TBNombrePerfil.TabIndex = 6;
            TBNombrePerfil.KeyPress += String_KeyPress;
            // 
            // LNombrePerfil
            // 
            LNombrePerfil.AutoSize = true;
            LNombrePerfil.BackColor = Color.Cornsilk;
            LNombrePerfil.Font = new Font("Cooper Black", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            LNombrePerfil.ForeColor = Color.DarkOrange;
            LNombrePerfil.Location = new Point(27, 12);
            LNombrePerfil.Margin = new Padding(4, 0, 4, 0);
            LNombrePerfil.Name = "LNombrePerfil";
            LNombrePerfil.Size = new Size(357, 42);
            LNombrePerfil.TabIndex = 0;
            LNombrePerfil.Text = "Nombre de Perfil :";
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
            // AñadirPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 754);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(PanelRegClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirPerfil";
            Text = "Form1";
            TabControlRegPerfil.ResumeLayout(false);
            TabPageListaPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroPerfil).EndInit();
            PanelRegClientes.ResumeLayout(false);
            PanelRegClientes.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegPerfil;
        internal TabPage TabPageListaPerfil;
        internal DataGridView dgvRegistroPerfil;
        internal Panel PanelRegClientes;
        internal Button BRegistrarPerfil;
        internal TextBox TBNombrePerfil;
        internal Label LNombrePerfil;

        #endregion

        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Estado;
    }
}