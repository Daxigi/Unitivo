namespace Unitivo.Presentacion.Administrador
{
    partial class GestionarTalles
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
            GroupBoxGestionTalles = new GroupBox();
            BBuscarTalle = new Button();
            TBBuscarTalle = new TextBox();
            BModificarTalle = new Button();
            BEliminarTalle = new Button();
            TabListaTalles = new TabControl();
            TabPageListaTalles = new TabPage();
            dgvListarTalles = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            BAltaTalle = new Button();
            GroupBoxGestionTalles.SuspendLayout();
            TabListaTalles.SuspendLayout();
            TabPageListaTalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGestionTalles
            // 
            GroupBoxGestionTalles.BackColor = Color.Cornsilk;
            GroupBoxGestionTalles.Controls.Add(BBuscarTalle);
            GroupBoxGestionTalles.Controls.Add(TBBuscarTalle);
            GroupBoxGestionTalles.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            GroupBoxGestionTalles.ForeColor = Color.SaddleBrown;
            GroupBoxGestionTalles.Location = new Point(338, 87);
            GroupBoxGestionTalles.Margin = new Padding(4, 5, 4, 5);
            GroupBoxGestionTalles.Name = "GroupBoxGestionTalles";
            GroupBoxGestionTalles.Padding = new Padding(4, 5, 4, 5);
            GroupBoxGestionTalles.Size = new Size(425, 152);
            GroupBoxGestionTalles.TabIndex = 91;
            GroupBoxGestionTalles.TabStop = false;
            GroupBoxGestionTalles.Text = "Gestión de Talles";
            // 
            // BBuscarTalle
            // 
            BBuscarTalle.BackColor = Color.DarkOliveGreen;
            BBuscarTalle.FlatAppearance.BorderColor = Color.White;
            BBuscarTalle.FlatAppearance.BorderSize = 2;
            BBuscarTalle.FlatStyle = FlatStyle.Flat;
            BBuscarTalle.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BBuscarTalle.ForeColor = Color.White;
            BBuscarTalle.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarTalle.Location = new Point(285, 60);
            BBuscarTalle.Margin = new Padding(4, 5, 4, 5);
            BBuscarTalle.Name = "BBuscarTalle";
            BBuscarTalle.Size = new Size(65, 63);
            BBuscarTalle.TabIndex = 14;
            BBuscarTalle.UseVisualStyleBackColor = false;
            // 
            // TBBuscarTalle
            // 
            TBBuscarTalle.Font = new Font("Britannic Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TBBuscarTalle.Location = new Point(65, 75);
            TBBuscarTalle.Margin = new Padding(4, 5, 4, 5);
            TBBuscarTalle.Name = "TBBuscarTalle";
            TBBuscarTalle.Size = new Size(196, 30);
            TBBuscarTalle.TabIndex = 6;
            TBBuscarTalle.KeyPress += Num_KeyPress;
            // 
            // BModificarTalle
            // 
            BModificarTalle.BackColor = Color.SteelBlue;
            BModificarTalle.FlatAppearance.BorderColor = Color.White;
            BModificarTalle.FlatAppearance.BorderSize = 2;
            BModificarTalle.FlatStyle = FlatStyle.Flat;
            BModificarTalle.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BModificarTalle.ForeColor = Color.White;
            BModificarTalle.Image = Properties.Resources.icons8_editar_archivo_26;
            BModificarTalle.Location = new Point(974, 449);
            BModificarTalle.Margin = new Padding(4, 5, 4, 5);
            BModificarTalle.Name = "BModificarTalle";
            BModificarTalle.Size = new Size(67, 69);
            BModificarTalle.TabIndex = 89;
            BModificarTalle.UseVisualStyleBackColor = false;
            BModificarTalle.Click += BModificarTalle_Click;
            // 
            // BEliminarTalle
            // 
            BEliminarTalle.BackColor = Color.Brown;
            BEliminarTalle.FlatAppearance.BorderSize = 2;
            BEliminarTalle.FlatStyle = FlatStyle.Flat;
            BEliminarTalle.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BEliminarTalle.ForeColor = Color.White;
            BEliminarTalle.Image = Properties.Resources.icons8_basura_26;
            BEliminarTalle.Location = new Point(974, 566);
            BEliminarTalle.Margin = new Padding(4, 5, 4, 5);
            BEliminarTalle.Name = "BEliminarTalle";
            BEliminarTalle.Size = new Size(67, 69);
            BEliminarTalle.TabIndex = 88;
            BEliminarTalle.TextImageRelation = TextImageRelation.ImageBeforeText;
            BEliminarTalle.UseVisualStyleBackColor = false;
            BEliminarTalle.Click += BEliminarTalle_Click;
            // 
            // TabListaTalles
            // 
            TabListaTalles.Controls.Add(TabPageListaTalles);
            TabListaTalles.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabListaTalles.Location = new Point(29, 266);
            TabListaTalles.Name = "TabListaTalles";
            TabListaTalles.SelectedIndex = 0;
            TabListaTalles.Size = new Size(917, 463);
            TabListaTalles.TabIndex = 90;
            // 
            // TabPageListaTalles
            // 
            TabPageListaTalles.Controls.Add(dgvListarTalles);
            TabPageListaTalles.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaTalles.ForeColor = Color.White;
            TabPageListaTalles.Location = new Point(4, 28);
            TabPageListaTalles.Name = "TabPageListaTalles";
            TabPageListaTalles.Padding = new Padding(3);
            TabPageListaTalles.Size = new Size(909, 431);
            TabPageListaTalles.TabIndex = 0;
            TabPageListaTalles.Text = "Lista de Talles";
            TabPageListaTalles.UseVisualStyleBackColor = true;
            // 
            // dgvListarTalles
            // 
            dgvListarTalles.AllowUserToAddRows = false;
            dgvListarTalles.AllowUserToDeleteRows = false;
            dgvListarTalles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListarTalles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvListarTalles.BackgroundColor = Color.RosyBrown;
            dgvListarTalles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle1.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvListarTalles.ColumnHeadersHeight = 20;
            dgvListarTalles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvListarTalles.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvListarTalles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvListarTalles.Dock = DockStyle.Fill;
            dgvListarTalles.EnableHeadersVisualStyles = false;
            dgvListarTalles.Location = new Point(3, 3);
            dgvListarTalles.Margin = new Padding(4, 5, 4, 5);
            dgvListarTalles.Name = "dgvListarTalles";
            dgvListarTalles.ReadOnly = true;
            dgvListarTalles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvListarTalles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvListarTalles.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dgvListarTalles.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvListarTalles.Size = new Size(903, 425);
            dgvListarTalles.TabIndex = 3;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Descripcion";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Estado";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // BAltaTalle
            // 
            BAltaTalle.BackColor = Color.DarkOliveGreen;
            BAltaTalle.ForeColor = Color.White;
            BAltaTalle.Image = Properties.Resources.icons8_más_2_matemáticas_30;
            BAltaTalle.Location = new Point(974, 566);
            BAltaTalle.Margin = new Padding(4, 5, 4, 5);
            BAltaTalle.Name = "BAltaTalle";
            BAltaTalle.Size = new Size(67, 69);
            BAltaTalle.TabIndex = 92;
            BAltaTalle.UseVisualStyleBackColor = false;
            // 
            // GestionarTalles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1080, 846);
            Controls.Add(GroupBoxGestionTalles);
            Controls.Add(BModificarTalle);
            Controls.Add(BEliminarTalle);
            Controls.Add(TabListaTalles);
            Controls.Add(BAltaTalle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "GestionarTalles";
            Text = "Form1";
            GroupBoxGestionTalles.ResumeLayout(false);
            GroupBoxGestionTalles.PerformLayout();
            TabListaTalles.ResumeLayout(false);
            TabPageListaTalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarTalles).EndInit();
            ResumeLayout(false);
        }

        internal GroupBox GroupBoxGestionTalles;
        internal Button BBuscarTalle;
        internal TextBox TBBuscarTalle;
        internal Button BModificarTalle;
        internal Button BEliminarTalle;
        internal TabControl TabListaTalles;
        internal TabPage TabPageListaTalles;
        internal DataGridView dgvListarTalles;
        internal Button BAltaTalle;

        #endregion

        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}