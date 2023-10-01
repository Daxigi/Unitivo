using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Univivo.Repositorios.Implementaciones
{
    public class ClienteRepositorio : ClienteInterface{
        private readonly UnitivoContext? _contexto;

        public ClienteRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

      public void AgregarCliente(ClienteConstructor x)
{
    try
    {
        x.FechaCreacion = DateTime.Now;
        x.Estado = true;
        x.UsuarioCreacion = Session.idUsuario;

        Cliente cliente = new Cliente();

        cliente.Nombre = x.Nombre;
        cliente.Apellido = x.Apellido;
        cliente.Dni = x.Dni;
        cliente.Correo = x.Correo;
        cliente.Direccion = x.Direccion;
        cliente.Telefono = x.Telefono;
        cliente.FechaCreacion = x.FechaCreacion; 
        cliente.Estado = x.Estado;
        cliente.UsuarioCreacion = x.UsuarioCreacion;

        var validator = new ClienteValidators();
        var result = validator.Validate(cliente);

        if (!result.IsValid)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var failure in result.Errors)
            {
                sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
            }
            throw new ValidationException(sb.ToString());
        }

        if (BuscarClientePorDni(x.Dni) != null)
        {
            MessageBox.Show("El DNI ya está asociado a un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Retorna sin agregar el cliente si ya existe uno con el mismo DNI
        }
        // Validar que el correo sea único

        if (BuscarClientePorMail(x.Correo) != null)
        {
            MessageBox.Show("El correo ya está asociado a un cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return; // Retorna sin agregar el cliente si ya existe uno con el mismo correo
        }

        // Agrega el cliente al contexto de Entity Framework
        
        
        

        _contexto?.Clientes.Add(cliente);
        _contexto?.SaveChanges();
    }
    catch (Exception ex)
    {
        // corrije el error
        MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    }



        public bool EliminarCliente(int id){
            Cliente? cliente = _contexto?.Clientes.Find(id);
            if(cliente == null) return false;
            cliente.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarCliente(Cliente cliente){
            _contexto?.Clientes.Update(cliente);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Cliente BuscarClientPorId(int id)
        {
            return _contexto?.Clientes.Find(id)!;
        }

        public Cliente BuscarClientePorDni(int dni)
        {
            return _contexto?.Clientes.Where(c => c.Dni == dni).FirstOrDefault()!; 
        }
        
        public List<Cliente> ListarClientes(){
            return _contexto?.Clientes.ToList()!;
        }


        public List<Cliente> ListarClientesActivos()
        {
            return _contexto?.Clientes.Where(c => c.Estado == true).ToList()!;
        }


        public List<Cliente> BuscarCliente(object parametro)
        {
            if (int.TryParse(parametro.ToString(), out int resultado))
            {
                List<Cliente> clientes = _contexto?.Clientes.Where(c => c.Dni == resultado).ToList()!; 
                return clientes;
            }
            else if (parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Clientes
                    .Where(c => c.Nombre.Contains(cadena) || c.Apellido.Contains(cadena))
                    .ToList()!;
            }
            else
            {
                return new List<Cliente>(); 
            }
        }

        public Cliente BuscarClientePorMail(string mail){
            return _contexto?.Clientes.Where(c => c.Correo == mail).FirstOrDefault()!;
        }
    }
}
