using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
    public class EmpleadoRepositorio : EmpleadoInterface
    {
        private readonly UnitivoContext? _contexto;

        public EmpleadoRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarEmpleado(Empleado x){
            try
            {
                x.FechaCreacion = DateTime.Now;
                x.Estado = true;

                Empleado empleado = new Empleado();

                empleado.Nombre = x.Nombre;
                empleado.Apellido = x.Apellido;
                empleado.Dni = x.Dni;
                empleado.Correo = x.Correo;
                empleado.Direccion = x.Direccion;
                empleado.Telefono = x.Telefono;
                empleado.FechaCreacion = x.FechaCreacion;
                empleado.Estado = x.Estado;

                var validator = new EmpleadoValidator();
                var result = validator.Validate(empleado);

                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                if (BuscarEmpleadosPorDni(x.Dni) != null)
                {
                    MessageBox.Show("El DNI ya está asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un empleado con el mismo DNI
                }
                // Validar que el correo sea único

                if (BuscarEmpleadosPorMail(x.Correo) != null)
                {
                    MessageBox.Show("El correo ya está asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false; // Retorna false si ya existe un empleado con el mismo correo
                }

                // Agrega el empleado al contexto de Entity Framework

                _contexto?.Empleados.Add(empleado);
                _contexto?.SaveChanges();

                // Retorna true si el empleado se agregó con éxito
                return true;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserción
                MessageBox.Show(ex.Message, "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool EliminarEmpleado(int id){
            Empleado? empleado = _contexto?.Empleados.Find(id);
            if(empleado == null) return false;
            empleado.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarEmpleado(Empleado empleado){
            _contexto?.Empleados.Update(empleado);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Empleado buscarEmpleado(int id){
           return _contexto?.Empleados.Find(id)!;
        }
        
        public List<Empleado> ListarEmpleados(){
            return _contexto?.Empleados.ToList()!;
        }
    }
}