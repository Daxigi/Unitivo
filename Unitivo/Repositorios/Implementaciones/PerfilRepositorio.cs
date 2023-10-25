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
        
        public bool AgregarPerfil(Perfile x){
            try{
                x.EstadoPerfil = true;
                _contexto?.Perfiles.Add(x);
                return true;
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
        public bool EliminarPerfil(int id){
            Perfile? perfil = _contexto?.Perfiles.Find(id);
            if(perfil == null) return false;
            perfil.EstadoPerfil = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarPerfil(Perfile Perfile){
            try
            {
                if(BuscarPerfil(Perfile.DescripcionPerfil) != null){
                    MessageBox.Show("Ya existe un perfil con esa descripcion", "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Perfiles.Update(Perfile);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Perfile BuscarPerfilPorId(int id){
            Perfile perfil = _contexto?.Perfiles.Find(id)!;
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