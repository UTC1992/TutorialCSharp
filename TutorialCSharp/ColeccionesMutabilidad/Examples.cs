namespace TutorialCSharp.ColeccionesMutabilidad;

public record Detalle(string Item, decimal Precio);

public class Booking
{
    public int Id { get; init; }
    
    private readonly List<Detalle> _detalles;

    public IReadOnlyList<Detalle> Detalles => _detalles;
    
    public Booking(int id, Detalle detalle)
    {
        Id = id;
        _detalles = new List<Detalle> {detalle};
    }

    public void AgregarDetalle(Detalle detalle)
    {
        _detalles.Add(detalle);
    }
}