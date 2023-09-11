namespace Unitivo.Presentacion.Administrador
{
    partial class AñadirTalle
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
            BVolver = new Button();
            //BVolver.Click += new EventHandler(BCancelarTalle_Click);
            TabControlRegTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            dgvRegistroTalles = new DataGridView();
            PanelRegTalles = new Panel();
            BRegistrarTalle = new Button();
            TBNombreTalle = new TextBox();
            //TBNombreTalle.KeyPress += new KeyPressEventHandler(TBNombreTalle_KeyPress);
            LNombreTalle = new Label();
            TabControlRegTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRegistroTalles).BeginInit();
            PanelRegTalles.SuspendLayout();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderColor = Color.White;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Britannic Bold", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.White;
            BVolver.Location = new Point(568, 422);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(100, 42);
            BVolver.TabIndex = 41;
            BVolver.Text = "Volver";
            BVolver.UseVisualStyleBackColor = false;
            // 
            // TabControlRegTalles
            // 
            TabControlRegTalles.Controls.Add(TabPageListaTalles);
            TabControlRegTalles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlRegTalles.Location = new Point(133, 165);
            TabControlRegTalles.Margin = new Padding(2);
            TabControlRegTalles.Name = "TabControlRegTalles";
            TabControlRegTalles.SelectedIndex = 0;
            TabControlRegTalles.Size = new Size(535, 242);
            TabControlRegTalles.TabIndex = 40;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(dgvRegistroTalles);
            TabPageListaTalles.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 25);
            TabPageListaTalles.Margin = new Padding(2);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(2);
            TabPageListaTalles.Size = new Size(527, 213);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // dgvRegistroTalles
            // 
            dgvRegistroTalles.AllowUserToAddRows = false;
            dgvRegistroTalles.AllowUserToDeleteRows = false;
            dgvRegistroTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRegistroTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRegistroTalles.BackgroundColor = Color.RosyBrown;
            dgvRegistroTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle1.BackColor = Color.FromArgb(255, 139, 0);
            DataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle1.ForeColor = Color.White;
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRegistroTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
            dgvRegistroTalles.ColumnHeadersHeight = 20;
            dgvRegistroTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRegistroTalles.Dock = DockStyle.Fill;
            dgvRegistroTalles.EnableHeadersVisualStyles = false;
            dgvRegistroTalles.Location = new Point(2, 2);
            dgvRegistroTalles.Margin = new Padding(2);
            dgvRegistroTalles.Name = "dgvRegistroTalles";
            dgvRegistroTalles.ReadOnly = true;
            dgvRegistroTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewCellStyle2.BackColor = SystemColors.ActiveCaption;
            DataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2f, FontStyle.Regular, GraphicsUnit.Point, 0);
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRegistroTalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle2;
            dgvRegistroTalles.RowHeadersWidth = 51;
            dgvRegistroTalles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvRegistroTalles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRegistroTalles.RowTemplate.Height = 24;
            dgvRegistroTalles.Size = new Size(523, 209);
            dgvRegistroTalles.TabIndex = 0;
            // 
            // PanelRegTalles
            // 
            PanelRegTalles.BackColor = Color.Cornsilk;
            PanelRegTalles.BackgroundImageLayout = ImageLayout.None;
            PanelRegTalles.Controls.Add(BRegistrarTalle);
            PanelRegTalles.Controls.Add(TBNombreTalle);
            PanelRegTalles.Controls.Add(LNombreTalle);
            PanelRegTalles.Location = new Point(192, 24);
            PanelRegTalles.Name = "PanelRegTalles";
            PanelRegTalles.Size = new Size(433, 112);
            PanelRegTalles.TabIndex = 39;
            // 
            // BRegistrarTalle
            // 
            BRegistrarTalle.BackColor = Color.DarkOliveGreen;
            BRegistrarTalle.FlatAppearance.BorderColor = Color.White;
            BRegistrarTalle.FlatAppearance.BorderSize = 2;
            BRegistrarTalle.FlatStyle = FlatStyle.Flat;
            BRegistrarTalle.Font = new Font("Britannic Bold", 13.0f);
            BRegistrarTalle.ForeColor = Color.White;
            BRegistrarTalle.Location = new Point(318, 48);
            BRegistrarTalle.Name = "BRegistrarTalle";
            BRegistrarTalle.Size = new Size(98, 42);
            BRegistrarTalle.TabIndex = 13;
            BRegistrarTalle.Text = "Añadir";
            BRegistrarTalle.UseVisualStyleBackColor = false;
            // 
            // TBNombreTalle
            // 
            TBNombreTalle.Font = new Font("Britannic Bold", 12.0f);
            TBNombreTalle.Location = new Point(20, 58);
            TBNombreTalle.Name = "TBNombreTalle";
            TBNombreTalle.Size = new Size(279, 25);
            TBNombreTalle.TabIndex = 6;
            // 
            // LNombreTalle
            // 
            LNombreTalle.AutoSize = true;
            LNombreTalle.BackColor = Color.Cornsilk;
            LNombreTalle.Font = new Font("Cooper Black", 18.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNombreTalle.ForeColor = Color.DarkOrange;
            LNombreTalle.Location = new Point(17, 10);
            LNombreTalle.Name = "LNombreTalle";
            LNombreTalle.Size = new Size(226, 27);
            LNombreTalle.TabIndex = 0;
            LNombreTalle.Text = "Nombre de Talle :";
            // 
            // AñadirTalle
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 500);
            Controls.Add(BVolver);
            Controls.Add(TabControlRegTalles);
            Controls.Add(PanelRegTalles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AñadirTalle";
            Text = "Form1";
            TabControlRegTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRegistroTalles).EndInit();
            PanelRegTalles.ResumeLayout(false);
            PanelRegTalles.PerformLayout();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal TabControl TabControlRegTalles;
        internal TabPage TabPageListaTalles;
        internal DataGridView dgvRegistroTalles;
        internal Panel PanelRegTalles;
        internal Button BRegistrarTalle;
        internal TextBox TBNombreTalle;
        internal Label LNombreTalle;

        #endregion
    }
}