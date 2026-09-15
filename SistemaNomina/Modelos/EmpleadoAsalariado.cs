public class EmpleadoAsalariado : Empleado
{
    public decimal SalarioSemanal { get; set; }

    public EmpleadoAsalariado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial, decimal salarioSemanal)
        : base(primerNombre, apellidoPaterno, numeroSeguroSocial)
    {
        SalarioSemanal = salarioSemanal;
    }

    public override decimal CalcularPago()
    {
        return SalarioSemanal;
    }

    public override string ObtenerTipo()
    {
        return "Asalariado";
    }
}