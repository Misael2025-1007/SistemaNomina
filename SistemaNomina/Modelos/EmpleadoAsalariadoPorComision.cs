namespace SistemaNomina.Modelos
{
    public class EmpleadoAsalariadoPorComision : EmpleadoPorComision
    {
        public decimal SalarioBase { get; set; }

        public EmpleadoAsalariadoPorComision(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal ventasBrutas, decimal tarifaComision, decimal salarioBase)
            : base(primerNombre, apellidoPaterno, numeroSeguroSocial, ventasBrutas, tarifaComision)
        {
            SalarioBase = salarioBase;
        }

        public override decimal CalcularPago()
        {
            return (VentasBrutas * TarifaComision) + SalarioBase + (SalarioBase * 0.10m);
        }

        public override string ObtenerTipo()
        {
            return "Asalariado por Comisión";
        }
    }
}