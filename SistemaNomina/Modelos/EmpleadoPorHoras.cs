using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNomina.Modelos
{
    public class EmpleadoPorHoras : Empleado
    {
        public decimal SueldoPorHora { get; set; }
        public decimal HorasTrabajadas { get; set; }

        public EmpleadoPorHoras(string apellidoPaterno, string numeroSeguroSocial, decimal sueldoPorHora, decimal horasTrabajadas)
            : base(null, apellidoPaterno, numeroSeguroSocial)
        {
            SueldoPorHora = sueldoPorHora;
            HorasTrabajadas = horasTrabajadas;
        }

        public override decimal CalcularPago()
        {
            if (HorasTrabajadas <= 40)
            {
                return SueldoPorHora * HorasTrabajadas;
            }
            else
            {
                return (SueldoPorHora * 40) + (SueldoPorHora * 1.5m * (HorasTrabajadas - 40));
            }
        }

        public override string ObtenerTipo()
        {
            return "Por Horas";
        }
    }
}