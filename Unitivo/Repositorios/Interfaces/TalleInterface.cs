using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces
{
    public interface TalleInterface
    {
        public void AgregarTalle(Talle Talle);
        public bool EliminarTalle(int id);
        public bool ModificarTalle(Talle Talle);
        public Talle BuscarTalle(int id);
        public List<Talle> ListarTalles();
        public List<Talle> ListarTallesActivos();
        public List<Talle> BuscarTalleDescripcion(string descripcion);
    }
}
