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
            var DataGridViewCellStyle11 = new DataGridViewCellStyle();
            var DataGridViewCellStyle12 = new DataGridViewCellStyle();
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            dgvRegistroPerfil = new DataGridView();
            PanelRegClientes = new Panel();
            BRegistrarPerfil = new Button();
            TBNombrePerfil = new TextBox();
            //TBNombrePerfil.KeyPress += new KeyPressEventHandler(TBNombrePerfil_KeyPress);
            LNombrePerfil = new Label();
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BVolver_Click);
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroPerfil).BeginInit();
            PanelRegClientes.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlRegPerfil
            // 
            TabControlRegPerfil.Controls.Add(TabPageListaPerfil);
            TabControlRegPerfil.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlRegPerfil.Location = new Point(156, 181);
            TabControlRegPerfil.Margin = new Padding(2);
            TabControlRegPerfil.Name = "TabControlRegPerfil";
            TabControlRegPerfil.SelectedIndex = 0;
            TabControlRegPerfil.Size = new Size(535, 242);
            TabControlRegPerfil.TabIndex = 13;
            // 
            // TabPageListaPerfil
            // 
            TabPageListaPerfil.Controls.Add(dgvRegistroPerfil);
            TabPageListaPerfil.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 25);
            TabPageListaPerfil.Margin = new Padding(2);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(2);
            TabPageListaPerfil.Size = new Size(527, 213);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Perfil";
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
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle11.BackColor = Color.FromArgb(255, 139, 0);
            DataGridViewCellStyle11.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle11.ForeColor = Color.White;
            DataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvRegistroPerfil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11;
            dgvRegistroPerfil.ColumnHeadersHeight = 20;
            dgvRegistroPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroPerfil.Dock = DockStyle.Fill;
            dgvRegistroPerfil.EnableHeadersVisualStyles = false;
            dgvRegistroPerfil.Location = new Point(2, 2);
            dgvRegistroPerfil.Margin = new Padding(2);
            dgvRegistroPerfil.Name = "dgvRegistroPerfil";
            dgvRegistroPerfil.ReadOnly = true;
            dgvRegistroPerfil.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle12.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle12.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dgvRegistroPerfil.RowHeadersDefaultCellStyle = DataGridViewCellStyle12;
            dgvRegistroPerfil.RowHeadersWidth = 51;
            dgvRegistroPerfil.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroPerfil.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroPerfil.RowTemplate.Height = 24;
            dgvRegistroPerfil.Size = new Size(523, 209);
            dgvRegistroPerfil.TabIndex = 0;
            // 
            // PanelRegClientes
            // 
            PanelRegClientes.BackColor = Color.Cornsilk;
            PanelRegClientes.BackgroundImageLayout = ImageLayout.None;
            PanelRegClientes.Controls.Add(BRegistrarPerfil);
            PanelRegClientes.Controls.Add(TBNombrePerfil);
            PanelRegClientes.Controls.Add(LNombrePerfil);
            PanelRegClientes.Location = new Point(215, 49);
            PanelRegClientes.Name = "PanelRegClientes";
            PanelRegClientes.Size = new Size(433, 112);
            PanelRegClientes.TabIndex = 12;
            // 
            // BRegistrarPerfil
            // 
            BRegistrarPerfil.BackColor = Color.DarkOliveGreen;
            BRegistrarPerfil.FlatAppearance.BorderColor = Color.White;
            BRegistrarPerfil.FlatAppearance.BorderSize = 2;
            BRegistrarPerfil.FlatStyle = FlatStyle.Flat;
            BRegistrarPerfil.Font = new Font("Britannic Bold", 13.0f);
            BRegistrarPerfil.ForeColor = Color.White;
            BRegistrarPerfil.Location = new Point(318, 48);
            BRegistrarPerfil.Name = "BRegistrarPerfil";
            BRegistrarPerfil.Size = new Size(98, 42);
            BRegistrarPerfil.TabIndex = 13;
            BRegistrarPerfil.Text = "Añadir";
            BRegistrarPerfil.UseVisualStyleBackColor = false;
            // 
            // TBNombrePerfil
            // 
            TBNombrePerfil.Font = new Font("Britannic Bold", 12.0f);
            TBNombrePerfil.Location = new Point(20, 58);
            TBNombrePerfil.Name = "TBNombrePerfil";
            TBNombrePerfil.Size = new Size(279, 25);
            TBNombrePerfil.TabIndex = 6;
            // 
            // LNombrePerfil
            // 
            LNombrePerfil.AutoSize = true;
            LNombrePerfil.BackColor = Color.Cornsilk;
            LNombrePerfil.Font = new Font("Cooper Black", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombrePerfil.ForeColor = Color.DarkOrange;
            LNombrePerfil.Location = new Point(20, 8);
            LNombrePerfil.Name = "LNombrePerfil";
            LNombrePerfil.Size = new Size(280, 34);
            LNombrePerfil.TabIndex = 0;
            LNombrePerfil.Text = "Nombre de Perfil :";
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderColor = Color.White;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(591, 436);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(100, 42);
            BVolver.TabIndex = 35;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // AñadirPerfil
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 490);
            Controls.Add(BVolver);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(PanelRegClientes);
            FormBorderStyle = FormBorderStyle.None;
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
        internal Button BVolver;

        #endregion
    }
}