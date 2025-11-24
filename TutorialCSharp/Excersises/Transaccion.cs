namespace TutorialCSharp.Excersises;

public record Cliente(int Id, string Nombre, string Codigo);

public record Transaccion2(int ClienteId, decimal Monto);


public record Transaccion(int Id, string CodigoCliente, decimal Monto, DateTime Fecha);

public record ReporteAgrupado(string Cliente, int TotalTransacciones, decimal SumaTotal);

public record TransaccionDetalleDTO(string ClienteNombre, int ClienteId, decimal MontoTransaccion);