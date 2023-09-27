using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;

namespace Unitivo.Repositorios.Interfaces{
    public interface EmpleadoInterface
    {
        public void AgregarEmpleado(Empleado empleado);
        
        public bool EliminarEmpleado(int id);

        public bool ModificarEmpleado(Empleado empleado);

        public Empleado buscarEmpleado(int id);

        public List<Empleado> ListarEmpleados();
    }
}