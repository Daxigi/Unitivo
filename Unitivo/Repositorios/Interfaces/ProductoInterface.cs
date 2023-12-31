﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces
{
    public interface ProductoInterface
    {
        public void AgregarProducto(Producto producto);
        public bool EliminarProducto(int id);
        public bool ModificarProducto(Producto producto);
        public Producto BuscarProducto(int id);
        public List<Producto> ListarProductos();

    }
}
