namespace TutorialCSharp.Excersises;

public class ExercisesLINQAdvance
{
    public void Run()
    {
        Console.WriteLine("This is the LINQ Advanced Exercise.");
        
        
        
        var transacciones = new List<Transaccion>
        {
            new(1, "Pedro", 1500.00m, new DateTime(2024, 1, 15)),
            new(2, "Pedro", 2300.50m, new DateTime(2024, 2, 20)),
            new(3, "Sofia", 800.00m, new DateTime(2024, 1, 10)),
            new(4, "Sofia", 1200.75m, new DateTime(2024, 3, 5)),
            new(5, "Sofia", 950.25m, new DateTime(2024, 4, 12)),
            new(6, "Juan", 3000.00m, new DateTime(2024, 2, 28))
        };
        
        var codigoClienteGroup = transacciones
            .GroupBy(x => x.CodigoCliente)
            .Select(g => new ReporteAgrupado(
                Cliente: g.Key,
                TotalTransacciones: g.Count(),
                SumaTotal: g.Sum(x => x.Monto)
            )).ToList();

        foreach (var reporte in codigoClienteGroup)
        {
            Console.WriteLine(
                $"Cliente: {reporte.Cliente} - Total Transacciones: {reporte.TotalTransacciones} - Suma Total: {reporte.SumaTotal}");
        }
        
        var transacciones2 = new List<Transaccion2>
        {
            new(1, 1500.00m),  // Pedro
            new(1, 2300.50m),  // Pedro
            new(2, 800.00m),   // Sofia
            new(2, 1200.75m),  // Sofia
            new(2, 950.25m),   // Sofia
            new(3, 3000.00m)   // Juan
        };

        var clientes = new List<Cliente>
        {
            new(1, "Pedro", "P001"),
            new(2, "Sofia", "S001"),
            new(3, "Juan", "J001")
        };

        var reportWithDetails = clientes.Join(
            inner: transacciones2,
            outerKeySelector: c => c.Id,
            innerKeySelector: t => t.ClienteId,
            resultSelector: (client, transaction) => new TransaccionDetalleDTO(
                ClienteNombre: client.Nombre,
                ClienteId: client.Id,
                MontoTransaccion: transaction.Monto
            )
        ).ToList();

        var resportWithDetailsSqlSintaxis = (
            from cliente in clientes
            join transaccion in transacciones2 on cliente.Id equals transaccion.ClienteId
            select new TransaccionDetalleDTO(
                ClienteNombre: cliente.Nombre,
                ClienteId: cliente.Id,
                MontoTransaccion: transaccion.Monto
            )).ToList();
        
        foreach (var detalle in resportWithDetailsSqlSintaxis)
        {
            Console.WriteLine(
                $"Cliente: {detalle.ClienteNombre} (ID: {detalle.ClienteId}) - Monto Transacción: {detalle.MontoTransaccion}");
        }
        
        var groupedByClient = reportWithDetails
            .GroupBy(rd => rd.ClienteNombre)
            .Select(r => new ReporteAgrupado(
                Cliente: r.Key,
                TotalTransacciones: r.Count(),
                SumaTotal: r.Sum(x => x.MontoTransaccion)
            )).ToList();

        foreach (var reporte in groupedByClient)
        {            
            Console.WriteLine(
                $"Cliente: {reporte.Cliente} - Total Transacciones: {reporte.TotalTransacciones} - Suma Total: {reporte.SumaTotal}");
        }
    }
}