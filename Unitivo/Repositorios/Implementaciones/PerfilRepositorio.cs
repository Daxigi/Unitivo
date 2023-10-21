using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Unitivo.Repositorios.Implementaciones
{
    public class PerfilRepositorio : PerfilInterface{
        private readonly UnitivoContext? _contexto;

        public PerfilRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }    
        
        public bool AgregarPerfile(Perfile Perfile){
            try{
                return true;
            }   
            catch
            {
                return false;
            } 
        }
        public bool EliminarPerfile(int id){
            return true;
        }
        public bool ModificarPerfile(Perfile Perfile){
            return true;
        }
        public Perfile BuscarClientPorId(int id){
            Perfile perfil = _contexto?.Perfiles.Find(id)!;
            return perfil;
        }

        public Perfile BuscarPerfilePorMail(string mail){
            Perfile perfil = _contexto?.Perfiles.Find(mail)!;
            return perfil;
        }
        public List<Perfile> BuscarPerfil(string nombre){
            List<Perfile> perfiles = _contexto?.Perfiles.Where(x => x.DescripcionPerfil.Contains(nombre)).ToList()!;
            return perfiles;
        }
        public List<Perfile> ListarPerfiles(){
            List<Perfile> perfiles = _contexto?.Perfiles.ToList()!;
            return perfiles;
        }
        public List<Perfile> ListarPerfilesActivos(){
            List<Perfile> perfiles = _contexto?.Perfiles.Where(x => x.EstadoPerfil == true).ToList()!;
            return perfiles;
        }

    }
}