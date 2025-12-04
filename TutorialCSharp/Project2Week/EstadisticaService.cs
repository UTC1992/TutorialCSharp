namespace TutorialCSharp.Project2Week;

public class EstadisticaService
{
    private readonly Dictionary<int, Solicitud> _solicitudes = new();

    private readonly HashSet<string> _clientesUnidos = new();
    
    private readonly object _lock = new();

    public void RegistrarSolicitud(Solicitud solicitud)
    {
        lock (_lock)
        {
            if (!_solicitudes.ContainsKey(solicitud.Id))
            {
                _solicitudes.Add(solicitud.Id, solicitud);
            }
            
            _clientesUnidos.Add(solicitud.CodigoCliente);
        }
    }

    public EstadisticaDTO ObtenerEstadisticas()
    {
        return new EstadisticaDTO(
            TotalSolicitudes: _solicitudes.Count,
            TotalClientesUnicos: _clientesUnidos.Count
            );
    }
}