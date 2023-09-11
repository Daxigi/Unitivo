namespace Unitivo.Presentacion.Vendedor
{
    partial class ModificarCliente
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
            Panel1 = new Panel();
            BCancelar = new Button();
            BCancelar.Click += new EventHandler(BCancelar_Click);
            BModCliente = new Button();
            TBCorreoCliente = new TextBox();
            Label7 = new Label();
            TBDireccion = new TextBox();
            Label6 = new Label();
            TBTelCliente = new TextBox();
            TBTelCliente.KeyPress += new KeyPressEventHandler(TBDniCliente_KeyPress);
            Label5 = new Label();
            TBDniCliente = new TextBox();
            TBDniCliente.KeyPress += new KeyPressEventHandler(TBDniCliente_KeyPress);
            Label4 = new Label();
            TBApellidoCliente = new TextBox();
            TBApellidoCliente.KeyPress += new KeyPressEventHandler(TBNombreCliente_KeyPress);
            TBApellidoCliente.KeyPress += new KeyPressEventHandler(TBApellidoCliente_KeyPress);
            Label3 = new Label();
            TBNombreCliente = new TextBox();
            TBNombreCliente.KeyPress += new KeyPressEventHandler(TBNombreCliente_KeyPress);
            Label2 = new Label();
            Label1 = new Label();
            Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Panel1
            // 
            Panel1.BackColor = Color.Cornsilk;
            Panel1.Controls.Add(BCancelar);
            Panel1.Controls.Add(BModCliente);
            Panel1.Controls.Add(TBCorreoCliente);
            Panel1.Controls.Add(Label7);
            Panel1.Controls.Add(TBDireccion);
            Panel1.Controls.Add(Label6);
            Panel1.Controls.Add(TBTelCliente);
            Panel1.Controls.Add(Label5);
            Panel1.Controls.Add(TBDniCliente);
            Panel1.Controls.Add(Label4);
            Panel1.Controls.Add(TBApellidoCliente);
            Panel1.Controls.Add(Label3);
            Panel1.Controls.Add(TBNombreCliente);
            Panel1.Controls.Add(Label2);
            Panel1.Location = new Point(239, 78);
            Panel1.Name = "Panel1";
            Panel1.Size = new Size(323, 340);
            Panel1.TabIndex = 1;
            // 
            // BCancelar
            // 
            BCancelar.BackColor = Color.Sienna;
            BCancelar.FlatAppearance.BorderSize = 2;
            BCancelar.FlatStyle = FlatStyle.Flat;
            BCancelar.Font = new Font("Cooper Black", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BCancelar.ForeColor = Color.Cornsilk;
            BCancelar.Location = new Point(37, 268);
            BCancelar.Name = "BCancelar";
            BCancelar.Size = new Size(106, 38);
            BCancelar.TabIndex = 18;
            BCancelar.Text = "Volver";
            BCancelar.TextAlign = ContentAlignment.TopCenter;
            BCancelar.UseVisualStyleBackColor = false;
            // 
            // BModCliente
            // 
            BModCliente.BackColor = Color.DarkOliveGreen;
            BModCliente.FlatAppearance.BorderSize = 2;
            BModCliente.FlatStyle = FlatStyle.Flat;
            BModCliente.Font = new Font("Cooper Black", 16.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            BModCliente.ForeColor = Color.Cornsilk;
            BModCliente.Location = new Point(166, 268);
            BModCliente.Name = "BModCliente";
            BModCliente.Size = new Size(133, 38);
            BModCliente.TabIndex = 17;
            BModCliente.Text = "Modificar";
            BModCliente.UseVisualStyleBackColor = false;
            // 
            // TBCorreoCliente
            // 
            TBCorreoCliente.Location = new Point(160, 209);
            TBCorreoCliente.Name = "TBCorreoCliente";
            TBCorreoCliente.Size = new Size(128, 20);
            TBCorreoCliente.TabIndex = 16;
            // 
            // Label7
            // 
            Label7.AutoSize = true;
            Label7.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label7.ForeColor = Color.DarkOrange;
            Label7.Location = new Point(35, 206);
            Label7.Name = "Label7";
            Label7.Size = new Size(85, 23);
            Label7.TabIndex = 15;
            Label7.Text = "E-mail :";
            // 
            // TBDireccion
            // 
            TBDireccion.Location = new Point(160, 173);
            TBDireccion.Name = "TBDireccion";
            TBDireccion.Size = new Size(128, 20);
            TBDireccion.TabIndex = 14;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label6.ForeColor = Color.DarkOrange;
            Label6.Location = new Point(35, 170);
            Label6.Name = "Label6";
            Label6.Size = new Size(120, 23);
            Label6.TabIndex = 13;
            Label6.Text = "Dirección :";
            // 
            // TBTelCliente
            // 
            TBTelCliente.Location = new Point(160, 136);
            TBTelCliente.Name = "TBTelCliente";
            TBTelCliente.Size = new Size(128, 20);
            TBTelCliente.TabIndex = 12;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label5.ForeColor = Color.DarkOrange;
            Label5.Location = new Point(35, 133);
            Label5.Name = "Label5";
            Label5.Size = new Size(109, 23);
            Label5.TabIndex = 11;
            Label5.Text = "Telefono :";
            // 
            // TBDniCliente
            // 
            TBDniCliente.Location = new Point(160, 98);
            TBDniCliente.Name = "TBDniCliente";
            TBDniCliente.Size = new Size(128, 20);
            TBDniCliente.TabIndex = 10;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label4.ForeColor = Color.DarkOrange;
            Label4.Location = new Point(35, 95);
            Label4.Name = "Label4";
            Label4.Size = new Size(62, 23);
            Label4.TabIndex = 9;
            Label4.Text = "DNI :";
            // 
            // TBApellidoCliente
            // 
            TBApellidoCliente.Location = new Point(160, 59);
            TBApellidoCliente.Name = "TBApellidoCliente";
            TBApellidoCliente.Size = new Size(128, 20);
            TBApellidoCliente.TabIndex = 8;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label3.ForeColor = Color.DarkOrange;
            Label3.Location = new Point(35, 56);
            Label3.Name = "Label3";
            Label3.Size = new Size(108, 23);
            Label3.TabIndex = 7;
            Label3.Text = "Apellido :";
            // 
            // TBNombreCliente
            // 
            TBNombreCliente.Location = new Point(160, 20);
            TBNombreCliente.Name = "TBNombreCliente";
            TBNombreCliente.Size = new Size(128, 20);
            TBNombreCliente.TabIndex = 6;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Cooper Black", 14.5f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label2.ForeColor = Color.DarkOrange;
            Label2.Location = new Point(35, 17);
            Label2.Name = "Label2";
            Label2.Size = new Size(104, 23);
            Label2.TabIndex = 5;
            Label2.Text = "Nombre :";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Cornsilk;
            Label1.Font = new Font("Cooper Black", 26.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Label1.ForeColor = Color.DarkOliveGreen;
            Label1.Location = new Point(240, 21);
            Label1.Name = "Label1";
            Label1.Size = new Size(324, 40);
            Label1.TabIndex = 2;
            Label1.Text = "Modificar Cliente";
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(Label1);
            Controls.Add(Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarCliente";
            Text = "Form1";
            Panel1.ResumeLayout(false);
            Panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        internal Panel Panel1;
        internal Button BCancelar;
        internal Button BModCliente;
        internal TextBox TBCorreoCliente;
        internal Label Label7;
        internal TextBox TBDireccion;
        internal Label Label6;
        internal TextBox TBTelCliente;
        internal Label Label5;
        internal TextBox TBDniCliente;
        internal Label Label4;
        internal TextBox TBApellidoCliente;
        internal Label Label3;
        internal TextBox TBNombreCliente;
        internal Label Label2;
        internal Label Label1;

        #endregion
    }
}