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

namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirProducto : Form
    {
        private readonly ProductoInterface? productoRepositorio;

        public AñadirProducto()
        {
            InitializeComponent();
            productoRepositorio = new ProductoRepositorio();
        }
        

           
   

        private void TBPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void TBStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void TBNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void CamposNoNulos()
        {
            
        }

        private void bGuardar_click()
        {

            
        }
    }
}
