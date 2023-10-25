﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;

namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirProducto : Form
    {
        private readonly ProductoInterface? productoRepositorio;

        private string? rutaImagenProducto;
        public AñadirProducto()
        {
            InitializeComponent();
            productoRepositorio = new ProductoRepositorio();
        }



        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BAñadirProducto_Click(object sender, EventArgs e)
        {
           if(verificarCamposNulos()){

           }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenProducto = openFileDialog.FileName;
                    // pictureBoxProducto.Image = Image.FromFile(rutaImagenProducto);
                }
            }
        }

        private void AñadirProducto_Load()
        {
            // Cargar las categorías.
            CBCategoria.DataSource = LocalStorage.categorias;
            CBCategoria.DisplayMember = "Nombre";
            CBCategoria.ValueMember = "Id";

            // Cargar los talles.
            CBTalle.DataSource = LocalStorage.talles;
            CBTalle.DisplayMember = "Nombre";
            CBTalle.ValueMember = "Id";
        }

        private bool verificarCamposNulos(){
             // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text) ||
                CBCategoria.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TBStock.Text) ||
                string.IsNullOrWhiteSpace(TBPrecio.Text) ||
                CBTalle.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rutaImagenProducto)
                )
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Producto registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }





    }
}
