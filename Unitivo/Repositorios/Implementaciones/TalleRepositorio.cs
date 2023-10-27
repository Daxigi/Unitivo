using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;

namespace Unitivo.Repositorios.Implementaciones
{
    public class TalleRepositorio : TalleInterface
    {
        private readonly UnitivoContext? _contexto;
        public TalleRepositorio() {
            _contexto = Contexto.dbContexto;
        }

        private void CargarCategorias()
        {
            _contexto?.Categorias.Load();

            LocalStorage.categorias = _contexto?.Categorias.ToList();
        }
        public void AgregarTalle(Talle x)
        {
            try
            {
                if(BuscarTalleDescripcion(x.Descripcion).Count > 0){
                    throw new Exception("Ya existe un Talle con ese Descripcion");
                }

                x.Estado = true;
                

                _contexto?.Talles.Add(x);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Talle BuscarTalle(int id)
        {
            return _contexto?.Talles.Find(id)!;
        }

        public bool EliminarTalle(int id)
        {
            Talle? Talle = _contexto?.Talles.Find(id);
            if (Talle == null) return false;
            Talle.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Talle> ListarTalles()
        {
            return _contexto?.Talles.ToList()!;
        }

        public bool ModificarTalle(Talle Talle)
        {
            _contexto?.Talles.Update(Talle);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Talle> ListarTallesActivos(){
            return _contexto?.Talles.Where(c => c.Estado == true).ToList()!;
        }

        public List<Talle> BuscarTalleDescripcion(string Descripcion){
            return _contexto?.Talles.Where(c => c.Descripcion == Descripcion).ToList()!;
        }
    }
}
