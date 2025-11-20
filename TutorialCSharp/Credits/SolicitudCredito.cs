namespace TutorialCSharp.Credits;

public class SolicitudCredito
{
    public Guid Id { get; private set; }
    public string Customer { get; private set; }
    public Moneda MontoSolicitado { get; private set; }
    public string Estado { get; private set; }

    public SolicitudCredito(
        Guid id,
        string customer,
        Moneda montoSolicitado,
        string estado)
    {
        Id = id;
        Customer = customer;
        MontoSolicitado = montoSolicitado;
        Estado = estado;
    }
    
    public void Aprobar()
    {
        Estado = "Aprobado";
    }

}