namespace Unitivo.Presentacion.Gerente
{
    partial class MenuG
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
            PanelBarraMenuG = new Panel();
            BMaximizarMenuG = new Button();
            BCerrarMenuG = new Button();
            BRestaurarMenuG = new Button();
            BMinimizarMenuG = new Button();
            PanelMenuLateral = new Panel();
            BVolver = new Button();
            BSalir = new Button();
            PanelSubMenuReportes = new Panel();
            BVentasCategoria = new Button();
            BReportes = new Button();
            PanelSubMenuBD = new Panel();
            BFunciones = new Button();
            BBaseDeDatos = new Button();
            PanelFormG = new Panel();
            PanelBarraMenuG.SuspendLayout();
            PanelMenuLateral.SuspendLayout();
            PanelSubMenuReportes.SuspendLayout();
            PanelSubMenuBD.SuspendLayout();
            SuspendLayout();
            // 
            // PanelBarraMenuG
            // 
            PanelBarraMenuG.BackColor = Color.Tan;
            PanelBarraMenuG.Controls.Add(BMaximizarMenuG);
            PanelBarraMenuG.Controls.Add(BCerrarMenuG);
            PanelBarraMenuG.Controls.Add(BRestaurarMenuG);
            PanelBarraMenuG.Controls.Add(BMinimizarMenuG);
            PanelBarraMenuG.Location = new Point(0, 0);
            PanelBarraMenuG.Margin = new Padding(4, 5, 4, 5);
            PanelBarraMenuG.Name = "PanelBarraMenuG";
            PanelBarraMenuG.Size = new Size(1387, 92);
            PanelBarraMenuG.TabIndex = 0;
            PanelBarraMenuG.MouseDown += PanelBarraMenuG_MouseDown;
            PanelBarraMenuG.MouseMove += PanelBarraMenuG_MouseMove;
            PanelBarraMenuG.MouseUp += PanelBarraMenuG_MouseUp;
            // 
            // BMaximizarMenuG
            // 
            BMaximizarMenuG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMaximizarMenuG.BackgroundImage = Properties.Resources.maximizarBlanco;
            BMaximizarMenuG.BackgroundImageLayout = ImageLayout.Stretch;
            BMaximizarMenuG.FlatAppearance.BorderSize = 0;
            BMaximizarMenuG.FlatStyle = FlatStyle.Flat;
            BMaximizarMenuG.Location = new Point(1261, 24);
            BMaximizarMenuG.Margin = new Padding(4, 5, 4, 5);
            BMaximizarMenuG.Name = "BMaximizarMenuG";
            BMaximizarMenuG.Size = new Size(40, 46);
            BMaximizarMenuG.TabIndex = 7;
            BMaximizarMenuG.UseVisualStyleBackColor = true;
            // 
            // BCerrarMenuG
            // 
            BCerrarMenuG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BCerrarMenuG.BackgroundImage = Properties.Resources.cerrarventana;
            BCerrarMenuG.BackgroundImageLayout = ImageLayout.Stretch;
            BCerrarMenuG.FlatAppearance.BorderSize = 0;
            BCerrarMenuG.FlatStyle = FlatStyle.Flat;
            BCerrarMenuG.Location = new Point(1317, 24);
            BCerrarMenuG.Margin = new Padding(4, 5, 4, 5);
            BCerrarMenuG.Name = "BCerrarMenuG";
            BCerrarMenuG.Size = new Size(40, 46);
            BCerrarMenuG.TabIndex = 6;
            BCerrarMenuG.UseVisualStyleBackColor = true;
            BCerrarMenuG.Click += BCerrarMenuG_Click;
            // 
            // BRestaurarMenuG
            // 
            BRestaurarMenuG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BRestaurarMenuG.BackgroundImage = Properties.Resources.restaurarventana;
            BRestaurarMenuG.BackgroundImageLayout = ImageLayout.Stretch;
            BRestaurarMenuG.FlatAppearance.BorderSize = 0;
            BRestaurarMenuG.FlatStyle = FlatStyle.Flat;
            BRestaurarMenuG.Location = new Point(1264, 24);
            BRestaurarMenuG.Margin = new Padding(4, 5, 4, 5);
            BRestaurarMenuG.Name = "BRestaurarMenuG";
            BRestaurarMenuG.Size = new Size(40, 46);
            BRestaurarMenuG.TabIndex = 5;
            BRestaurarMenuG.UseVisualStyleBackColor = true;
            // 
            // BMinimizarMenuG
            // 
            BMinimizarMenuG.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BMinimizarMenuG.BackgroundImage = Properties.Resources.minimizar_blanco;
            BMinimizarMenuG.BackgroundImageLayout = ImageLayout.Stretch;
            BMinimizarMenuG.FlatAppearance.BorderSize = 0;
            BMinimizarMenuG.FlatStyle = FlatStyle.Flat;
            BMinimizarMenuG.Location = new Point(1210, 24);
            BMinimizarMenuG.Margin = new Padding(4, 5, 4, 5);
            BMinimizarMenuG.Name = "BMinimizarMenuG";
            BMinimizarMenuG.Size = new Size(40, 46);
            BMinimizarMenuG.TabIndex = 4;
            BMinimizarMenuG.UseVisualStyleBackColor = true;
            // 
            // PanelMenuLateral
            // 
            PanelMenuLateral.BackColor = Color.Tan;
            PanelMenuLateral.Controls.Add(BVolver);
            PanelMenuLateral.Controls.Add(BSalir);
            PanelMenuLateral.Controls.Add(PanelSubMenuReportes);
            PanelMenuLateral.Controls.Add(BReportes);
            PanelMenuLateral.Controls.Add(PanelSubMenuBD);
            PanelMenuLateral.Controls.Add(BBaseDeDatos);
            PanelMenuLateral.Location = new Point(0, 92);
            PanelMenuLateral.Name = "PanelMenuLateral";
            PanelMenuLateral.Size = new Size(307, 908);
            PanelMenuLateral.TabIndex = 1;
            // 
            // BVolver
            // 
            BVolver.BackColor = Color.Cornsilk;
            BVolver.Dock = DockStyle.Bottom;
            BVolver.FlatAppearance.BorderSize = 2;
            BVolver.FlatStyle = FlatStyle.Flat;
            BVolver.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BVolver.ForeColor = Color.Sienna;
            BVolver.Location = new Point(0, 806);
            BVolver.Margin = new Padding(4, 5, 4, 5);
            BVolver.Name = "BVolver";
            BVolver.Size = new Size(307, 51);
            BVolver.TabIndex = 17;
            BVolver.Text = "Volver";
            BVolver.TextAlign = ContentAlignment.TopCenter;
            BVolver.UseVisualStyleBackColor = false;
            BVolver.Click += BVolver_Click;
            // 
            // BSalir
            // 
            BSalir.BackColor = Color.Sienna;
            BSalir.Dock = DockStyle.Bottom;
            BSalir.FlatAppearance.BorderSize = 2;
            BSalir.FlatStyle = FlatStyle.Flat;
            BSalir.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BSalir.ForeColor = Color.Cornsilk;
            BSalir.Location = new Point(0, 857);
            BSalir.Margin = new Padding(4, 5, 4, 5);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(307, 51);
            BSalir.TabIndex = 16;
            BSalir.Text = "Cerrar Sesión";
            BSalir.TextAlign = ContentAlignment.TopCenter;
            BSalir.UseVisualStyleBackColor = false;
            BSalir.Click += BSalir_Click;
            // 
            // PanelSubMenuReportes
            // 
            PanelSubMenuReportes.BackColor = Color.FloralWhite;
            PanelSubMenuReportes.Controls.Add(BVentasCategoria);
            PanelSubMenuReportes.Dock = DockStyle.Top;
            PanelSubMenuReportes.Location = new Point(0, 230);
            PanelSubMenuReportes.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuReportes.Name = "PanelSubMenuReportes";
            PanelSubMenuReportes.Size = new Size(307, 76);
            PanelSubMenuReportes.TabIndex = 12;
            // 
            // BVentasCategoria
            // 
            BVentasCategoria.BackColor = Color.FloralWhite;
            BVentasCategoria.Dock = DockStyle.Top;
            BVentasCategoria.FlatAppearance.BorderSize = 0;
            BVentasCategoria.FlatStyle = FlatStyle.Flat;
            BVentasCategoria.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BVentasCategoria.ForeColor = Color.Sienna;
            BVentasCategoria.Location = new Point(0, 0);
            BVentasCategoria.Margin = new Padding(4, 5, 4, 5);
            BVentasCategoria.Name = "BVentasCategoria";
            BVentasCategoria.Size = new Size(307, 62);
            BVentasCategoria.TabIndex = 1;
            BVentasCategoria.Text = "Ventar por Categoria";
            BVentasCategoria.UseVisualStyleBackColor = false;
            BVentasCategoria.Click += BVentasCategoria_Click;
            // 
            // BReportes
            // 
            BReportes.BackColor = Color.RosyBrown;
            BReportes.Dock = DockStyle.Top;
            BReportes.FlatAppearance.BorderSize = 0;
            BReportes.FlatStyle = FlatStyle.Flat;
            BReportes.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BReportes.ForeColor = Color.Cornsilk;
            BReportes.Image = Properties.Resources.ventas;
            BReportes.ImageAlign = ContentAlignment.MiddleLeft;
            BReportes.Location = new Point(0, 150);
            BReportes.Margin = new Padding(4, 5, 4, 5);
            BReportes.Name = "BReportes";
            BReportes.Size = new Size(307, 80);
            BReportes.TabIndex = 11;
            BReportes.Text = "Reportes";
            BReportes.TextAlign = ContentAlignment.MiddleLeft;
            BReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BReportes.UseVisualStyleBackColor = false;
            BReportes.Click += BReportes_Click;
            // 
            // PanelSubMenuBD
            // 
            PanelSubMenuBD.BackColor = Color.FloralWhite;
            PanelSubMenuBD.Controls.Add(BFunciones);
            PanelSubMenuBD.Dock = DockStyle.Top;
            PanelSubMenuBD.Location = new Point(0, 80);
            PanelSubMenuBD.Margin = new Padding(4, 5, 4, 5);
            PanelSubMenuBD.Name = "PanelSubMenuBD";
            PanelSubMenuBD.Size = new Size(307, 70);
            PanelSubMenuBD.TabIndex = 10;
            // 
            // BFunciones
            // 
            BFunciones.BackColor = Color.FloralWhite;
            BFunciones.Dock = DockStyle.Top;
            BFunciones.FlatAppearance.BorderSize = 0;
            BFunciones.FlatStyle = FlatStyle.Flat;
            BFunciones.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            BFunciones.ForeColor = Color.Sienna;
            BFunciones.Location = new Point(0, 0);
            BFunciones.Margin = new Padding(4, 5, 4, 5);
            BFunciones.Name = "BFunciones";
            BFunciones.Size = new Size(307, 62);
            BFunciones.TabIndex = 1;
            BFunciones.Text = "Funciones";
            BFunciones.UseVisualStyleBackColor = false;
            BFunciones.Click += BFunciones_Click;
            // 
            // BBaseDeDatos
            // 
            BBaseDeDatos.BackColor = Color.RosyBrown;
            BBaseDeDatos.Dock = DockStyle.Top;
            BBaseDeDatos.FlatAppearance.BorderSize = 0;
            BBaseDeDatos.FlatStyle = FlatStyle.Flat;
            BBaseDeDatos.Font = new Font("Cooper Black", 16.5F, FontStyle.Regular, GraphicsUnit.Point);
            BBaseDeDatos.ForeColor = Color.Cornsilk;
            BBaseDeDatos.Image = Properties.Resources.icons8_base_de_datos_50;
            BBaseDeDatos.ImageAlign = ContentAlignment.MiddleLeft;
            BBaseDeDatos.Location = new Point(0, 0);
            BBaseDeDatos.Margin = new Padding(4, 5, 4, 5);
            BBaseDeDatos.Name = "BBaseDeDatos";
            BBaseDeDatos.Size = new Size(307, 80);
            BBaseDeDatos.TabIndex = 1;
            BBaseDeDatos.Text = "Base de Datos";
            BBaseDeDatos.TextAlign = ContentAlignment.MiddleLeft;
            BBaseDeDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BBaseDeDatos.UseVisualStyleBackColor = false;
            BBaseDeDatos.Click += BBaseDeDatos_Click;
            // 
            // PanelFormG
            // 
            PanelFormG.BackgroundImage = Properties.Resources.ImagenGrandeVendedor;
            PanelFormG.BackgroundImageLayout = ImageLayout.Stretch;
            PanelFormG.Location = new Point(307, 92);
            PanelFormG.Name = "PanelFormG";
            PanelFormG.Size = new Size(1080, 908);
            PanelFormG.TabIndex = 2;
            // 
            // MenuG
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Plum;
            ClientSize = new Size(1387, 1000);
            Controls.Add(PanelFormG);
            Controls.Add(PanelMenuLateral);
            Controls.Add(PanelBarraMenuG);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuG";
            Text = "Form1";
            Load += MenuG_Load;
            PanelBarraMenuG.ResumeLayout(false);
            PanelMenuLateral.ResumeLayout(false);
            PanelSubMenuReportes.ResumeLayout(false);
            PanelSubMenuBD.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelBarraMenuG;
        internal Button BMaximizarMenuG;
        internal Button BCerrarMenuG;
        internal Button BRestaurarMenuG;
        internal Button BMinimizarMenuG;
        private Panel PanelMenuLateral;
        internal Button BBaseDeDatos;
        internal Panel PanelSubMenuBD;
        internal Button BFunciones;
        internal Panel panel3;
        internal Button button5;
        internal Button button6;
        internal Button button4;
        internal Panel PanelSubMenuReportes;
        internal Button BVentasCategoria;
        internal Button BReportes;
        internal Button BVolver;
        internal Button BSalir;
        private Panel PanelFormG;
    }
}