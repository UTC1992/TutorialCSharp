namespace TutorialCSharp.Project2Week;

public record Solicitud(int Id, string CodigoCliente, decimal Monto);

public record EstadisticaDTO(int TotalSolicitudes, int TotalClientesUnicos);
