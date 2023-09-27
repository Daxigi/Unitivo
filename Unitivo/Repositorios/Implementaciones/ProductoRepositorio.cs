using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;

namespace Unitivo.Repositorios.Implementaciones
{
    public class ProductoRepositorio : ProductoInterface
    {
        private readonly UnitivoContext? _contexto;
        public ProductoRepositorio() {
            _contexto = Contexto.dbContexto;
        }

        private void CargarTalleYCategorias()
        {
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();

            LocalStorage.categorias = _contexto?.Categorias.ToList();
            LocalStorage.talles = _contexto?.Talles.ToList();
        }
        public void AgregarProducto(Producto producto)
        {
            _contexto?.Productos.Add(producto);
        }

        public Producto BuscarProducto(int id)
        {
            return _contexto?.Productos.Find(id)!;
        }

        public bool EliminarProducto(int id)
        {
            Producto? producto = _contexto?.Productos.Find(id);
            if (producto == null) return false;
            producto.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Producto> ListarProductos()
        {
            if (LocalStorage.categorias.IsNullOrEmpty() || LocalStorage.talles.IsNullOrEmpty())
            {
                CargarTalleYCategorias();
            }
            if (LocalStorage.productos.IsNullOrEmpty())
            {
                LocalStorage.productos = _contexto?.Productos.ToList();
            }
           return LocalStorage.productos!;
        }

        public bool ModificarProducto(Producto producto)
        {
            _contexto?.Productos.Update(producto);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }
}
