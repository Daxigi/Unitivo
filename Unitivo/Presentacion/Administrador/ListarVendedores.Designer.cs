namespace Unitivo.Presentacion.Administrador
{
    partial class ListarVendedores
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
            BVolver = new Button();
            BImprimirVendedor = new Button();
            TabControlListaVendedores = new TabControl();
            TabPageListaVendedores = new TabPage();
            dgvListarVendedores = new DataGridView();
            //dgvListarVendedores.CellContentClick += new DataGridViewCellEventHandler(dgvListarVendedores_CellContentClick);
            GroupBoxVendedor = new GroupBox();
            BBuscarVendedor = new Button();
            TBBuscarVendedor = new TextBox();
            TabControlListaVendedores.SuspendLayout();
            TabPageListaVendedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListarVendedores).BeginInit();
            GroupBoxVendedor.SuspendLayout();
            SuspendLayout();
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Sienna;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BVolver.ForeColor = Color.Cornsilk;
            BVolver.Location = new Point(554, 388);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(106, 38);
            BVolver.TabIndex = 24;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            // 
            // BImprimirVendedor
            // 
            BImprimirVendedor.BackColor = Color.SteelBlue;
            BImprimirVendedor.ForeColor = Color.White;
            BImprimirVendedor.Image = Properties.Resources.icons8_imprimir_26;
            BImprimirVendedor.Location = new Point(701, 251);
            BImprimirVendedor.Name = "BImprimirVendedor";
            BImprimirVendedor.Size = new Size(50, 45);
            BImprimirVendedor.TabIndex = 22;
            BImprimirVendedor.UseVisualStyleBackColor = false;
            // 
            // TabControlListaVendedores
            // 
            TabControlListaVendedores.Controls.Add(TabPageListaVendedores);
            TabControlListaVendedores.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControlListaVendedores.Location = new Point(75, 157);
            TabControlListaVendedores.Name = "TabControlListaVendedores";
            TabControlListaVendedores.SelectedIndex = 0;
            TabControlListaVendedores.Size = new Size(585, 215);
            TabControlListaVendedores.TabIndex = 21;
            // 
            // TabPageListaVendedores
            // 
            TabPageListaVendedores.Controls.Add(dgvListarVendedores);
            TabPageListaVendedores.Font = new Font("Britannic Bold", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabPageListaVendedores.Location = new Point(4, 25);
            TabPageListaVendedores.Name = "TabPageListaVendedores";
            TabPageListaVendedores.Padding = new Padding(3);
            TabPageListaVendedores.Size = new Size(577, 186);
            TabPageListaVendedores.TabIndex = 0;
            TabPageListaVendedores.Text = "Lista de Vendedores";
            TabPageListaVendedores.UseVisualStyleBackColor = true;
            // 
            // dgvListarVendedores
            // 
            dgvListarVendedores.BackgroundColor = Color.RosyBrown;
            dgvListarVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListarVendedores.Dock = DockStyle.Fill;
            dgvListarVendedores.Location = new Point(3, 3);
            dgvListarVendedores.Name = "dgvListarVendedores";
            dgvListarVendedores.Size = new Size(571, 180);
            dgvListarVendedores.TabIndex = 0;
            // 
            // GroupBoxVendedor
            // 
            GroupBoxVendedor.BackColor = Color.FloralWhite;
            GroupBoxVendedor.Controls.Add(BBuscarVendedor);
            GroupBoxVendedor.Controls.Add(TBBuscarVendedor);
            GroupBoxVendedor.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            GroupBoxVendedor.ForeColor = Color.DarkOrange;
            GroupBoxVendedor.Location = new Point(176, 29);
            GroupBoxVendedor.Name = "GroupBoxVendedor";
            GroupBoxVendedor.Size = new Size(400, 100);
            GroupBoxVendedor.TabIndex = 20;
            GroupBoxVendedor.TabStop = false;
            GroupBoxVendedor.Text = "Vendedores";
            // 
            // BBuscarVendedor
            // 
            BBuscarVendedor.BackColor = Color.DarkOliveGreen;
            BBuscarVendedor.ForeColor = Color.White;
            BBuscarVendedor.Image = Properties.Resources.icons8_búsqueda_26;
            BBuscarVendedor.Location = new Point(274, 43);
            BBuscarVendedor.Name = "BBuscarVendedor";
            BBuscarVendedor.Size = new Size(45, 40);
            BBuscarVendedor.TabIndex = 2;
            BBuscarVendedor.UseVisualStyleBackColor = false;
            // 
            // TBBuscarVendedor
            // 
            TBBuscarVendedor.Location = new Point(81, 47);
            TBBuscarVendedor.Name = "TBBuscarVendedor";
            TBBuscarVendedor.Size = new Size(166, 32);
            TBBuscarVendedor.TabIndex = 1;
            // 
            // ListarVendedores
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(BVolver);
            Controls.Add(BImprimirVendedor);
            Controls.Add(TabControlListaVendedores);
            Controls.Add(GroupBoxVendedor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarVendedores";
            Text = "Form1";
            TabControlListaVendedores.ResumeLayout(false);
            TabPageListaVendedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListarVendedores).EndInit();
            GroupBoxVendedor.ResumeLayout(false);
            GroupBoxVendedor.PerformLayout();
            ResumeLayout(false);

        }

        internal Button BVolver;
        internal Button BImprimirVendedor;
        internal TabControl TabControlListaVendedores;
        internal TabPage TabPageListaVendedores;
        internal DataGridView dgvListarVendedores;
        internal GroupBox GroupBoxVendedor;
        internal Button BBuscarVendedor;
        internal TextBox TBBuscarVendedor;

        #endregion
    }
}