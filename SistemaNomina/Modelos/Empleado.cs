public abstract class Empleado
{
    public string PrimerNombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string NumeroSeguroSocial { get; set; }

    public Empleado(string primerNombre, string apellidoPaterno, string numeroSeguroSocial)
    {
        PrimerNombre = primerNombre;
        ApellidoPaterno = apellidoPaterno;
        NumeroSeguroSocial = numeroSeguroSocial;
    }

    public abstract decimal CalcularPago();

    public virtual string ObtenerTipo()
    {
        return "Empleado";
    }
}