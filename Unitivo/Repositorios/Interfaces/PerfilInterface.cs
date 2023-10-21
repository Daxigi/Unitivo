using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica.Constructores;

namespace Unitivo.Repositorio.Interfaces
{
    public interface PerfilInterface
    {
        public bool AgregarPerfile(Perfile Perfile);
        public bool EliminarPerfile(int id);
        public bool ModificarPerfile(Perfile Perfile);
        public Perfile BuscarClientPorId(int id);

        public Perfile BuscarPerfilePorMail(string mail);   
        public List<Perfile> BuscarPerfile(object parametro);
        public List<Perfile> ListarPerfiles();
        public List<Perfile> ListarPerfilesActivos();
    }
}