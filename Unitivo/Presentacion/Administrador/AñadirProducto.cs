using System;
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
using System.IO;
using static System.Drawing.Image;
using Unitivo.Repositorio.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Unitivo.Properties;

namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirProducto : Form
    {
        ProductoRepositorio? productoRepositorio = new ProductoRepositorio();
        TalleRepositorio? talleRepositorio = new TalleRepositorio();
        CategoriaRepositorio? categoriaRepositorio = new CategoriaRepositorio();

        string imageName = string.Empty;
        string filePath = string.Empty;
        string fileSavePath = string.Empty;

        public AñadirProducto()
        {
            InitializeComponent();
            AñadirProducto_Load();
        }


        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BAñadirProducto_Click(object sender, EventArgs e)
        {
            if (verificarCamposNulos())
            {
                try
                {
                    Producto producto = new Producto();
                    producto.Nombre = TBNombreProducto.Text;
                    producto.IdCategoria = ((Categoria)CBCategoria.SelectedItem).Id;
                    producto.Stock = int.Parse(TBStock.Text);
                    producto.Precio = double.Parse(TBPrecio.Text);
                    producto.IdTalle = ((Talle)CBTalle.SelectedItem).Id;
                    producto.Imagen = imageName;


                    if (productoRepositorio!.AgregarProducto(producto)){
                        File.Copy(filePath!, fileSavePath!, true);
                        MessageBox.Show("El producto se agrego correctamente!","Producto", MessageBoxButtons.OK);
                    }else{
                        MessageBox.Show("El producto no se pudo agregar!","Producto", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Image files (*.png) | *.png",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                Multiselect = false,
                RestoreDirectory = true,
                Title = "Seleccione una imagen"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imageName = Guid.NewGuid().ToString() + ".png";

                string fileSavePath = Path.Combine("..", "..", "..", "products", imageName!);
                string fileName = openFileDialog.SafeFileName;
                this.fileSavePath = fileSavePath;
                filePath = openFileDialog.FileName;
                
                pictureBoxProducto.Image = FromFile(filePath);
            }
        }

        private void AñadirProducto_Load()
        {
            productoRepositorio!.CargarTalleYCategorias();            // Cargar las categorías.
            CBCategoria.DataSource = LocalStorage.categorias;
            CBCategoria.DisplayMember = "Nombre";
            CBCategoria.ValueMember = "Id";

            // Cargar los talles.
            CBTalle.DataSource = LocalStorage.talles;
            CBTalle.DisplayMember = "Nombre";
            CBTalle.ValueMember = "Id";

            
        }

        private bool verificarCamposNulos()
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text) ||
                CBCategoria.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TBStock.Text) ||
                string.IsNullOrWhiteSpace(TBPrecio.Text) ||
                CBTalle.SelectedIndex == -1
                )
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
