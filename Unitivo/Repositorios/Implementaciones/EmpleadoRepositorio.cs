using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Models;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Repositorios.Implementaciones
{
    public class EmpleadoRepositorio : EmpleadoInterface
    {
        private readonly UnitivoContext? _contexto;

        public EmpleadoRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public void AgregarEmpleado(Empleado empleado){
            _contexto?.Empleados.Add(empleado);
        }

        public bool EliminarEmpleado(int id){
            Empleado? empleado = _contexto?.Empleados.Find(id);
            if(empleado == null) return false;
            empleado.EstadoEmpleado = false;
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