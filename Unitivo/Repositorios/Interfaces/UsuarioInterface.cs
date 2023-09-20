using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Models;

namespace Unitivo.Repositorios.Interfaces
{
    public interface UsuarioInterface
    {
        public void AgregarUsuario(Usuario usuario);

        public bool EliminarUsuario(int id);

        public bool ModificarUsuario(Usuario usuario);

        public Usuario BuscarUsuario(int id);

        public List<Usuario> ListarUsuarios();
    }
}
