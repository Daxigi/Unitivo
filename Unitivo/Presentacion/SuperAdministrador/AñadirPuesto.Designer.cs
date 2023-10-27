﻿namespace Unitivo.Presentacion.SuperAdministrador
{
    partial class AñadirPuesto
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            TabControlRegPerfil = new TabControl();
            TabPageListaPerfil = new TabPage();
            DataGridViewListarPerfiles = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            PanelRegClientes = new Panel();
            BRegistrarPerfil = new Button();
            TBNombrePerfil = new TextBox();
            LNombrePerfil = new Label();
            TabControlRegPerfil.SuspendLayout();
            TabPageListaPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).BeginInit();
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
            TabPageListaPerfil.Controls.Add(DataGridViewListarPerfiles);
            TabPageListaPerfil.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TabPageListaPerfil.ForeColor = Color.White;
            TabPageListaPerfil.Location = new Point(4, 28);
            TabPageListaPerfil.Name = "TabPageListaPerfil";
            TabPageListaPerfil.Padding = new Padding(3);
            TabPageListaPerfil.Size = new Size(705, 340);
            TabPageListaPerfil.TabIndex = 0;
            TabPageListaPerfil.Text = "Lista de Puestos";
            TabPageListaPerfil.UseVisualStyleBackColor = true;
            // 
            // DataGridViewListarPerfiles
            // 
            DataGridViewListarPerfiles.AllowUserToAddRows = false;
            DataGridViewListarPerfiles.AllowUserToDeleteRows = false;
            DataGridViewListarPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewListarPerfiles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataGridViewListarPerfiles.BackgroundColor = Color.RosyBrown;
            DataGridViewListarPerfiles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.DarkOliveGreen;
            dataGridViewCellStyle3.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            DataGridViewListarPerfiles.ColumnHeadersHeight = 20;
            DataGridViewListarPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            DataGridViewListarPerfiles.Columns.AddRange(new DataGridViewColumn[] { ID, Descripcion, Estado });
            DataGridViewListarPerfiles.Dock = DockStyle.Fill;
            DataGridViewListarPerfiles.EnableHeadersVisualStyles = false;
            DataGridViewListarPerfiles.Location = new Point(3, 3);
            DataGridViewListarPerfiles.Name = "DataGridViewListarPerfiles";
            DataGridViewListarPerfiles.ReadOnly = true;
            DataGridViewListarPerfiles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new Font("Britannic Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            DataGridViewListarPerfiles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            DataGridViewListarPerfiles.RowHeadersWidth = 51;
            DataGridViewListarPerfiles.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            DataGridViewListarPerfiles.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            DataGridViewListarPerfiles.RowTemplate.Height = 24;
            DataGridViewListarPerfiles.Size = new Size(699, 334);
            DataGridViewListarPerfiles.TabIndex = 0;
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
            BRegistrarPerfil.Click += BRegistrarPerfil_Click;
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
            LNombrePerfil.Size = new Size(379, 42);
            LNombrePerfil.TabIndex = 0;
            LNombrePerfil.Text = "Nombre de Puesto :";
            // 
            // AñadirPuesto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1067, 754);
            Controls.Add(TabControlRegPerfil);
            Controls.Add(PanelRegClientes);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AñadirPuesto";
            Text = "Form1";
            TabControlRegPerfil.ResumeLayout(false);
            TabPageListaPerfil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DataGridViewListarPerfiles).EndInit();
            PanelRegClientes.ResumeLayout(false);
            PanelRegClientes.PerformLayout();
            ResumeLayout(false);
        }

        internal TabControl TabControlRegPerfil;
        internal TabPage TabPageListaPerfil;
        internal DataGridView DataGridViewListarPerfiles;
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