using System.Collections.Generic;
using SistemaNomina.Modelos;

namespace SistemaNomina.Servicios
{
    public class NominaService
    {
        private List<Empleado> empleados = new List<Empleado>();

        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        public List<Empleado> ObtenerTodos()
        {
            return empleados;
        }

        public void ActualizarEmpleado(int indice, Empleado empleadoActualizado)
        {
            if (indice >= 0 && indice < empleados.Count)
            {
                empleados[indice] = empleadoActualizado;
            }
        }

        public void EliminarEmpleado(int indice)
        {
            if (indice >= 0 && indice < empleados.Count)
            {
                empleados.RemoveAt(indice);
            }
        }
    }
}