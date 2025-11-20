namespace TutorialCSharp.Excersises;
using TutorialCSharp.Credits;

public class EjercicioLinq
{
    public void Run()
    {
        Console.WriteLine("This is the Linq Exercise.");

        List<SolicitudCredito> listCredits = new List<SolicitudCredito>
        {
            // 3 Pendientes con montos variados
            new SolicitudCredito(
                Guid.NewGuid(),
                "Juan Pérez",
                new Moneda("MXN", 500),
                "Pendiente"
            ),
            new SolicitudCredito(
                Guid.NewGuid(),
                "María García",
                new Moneda("MXN", 1500),
                "Pendiente"
            ),
            new SolicitudCredito(
                Guid.NewGuid(),
                "Carlos López",
                new Moneda("MXN", 5000),
                "Pendiente"
            ),
            // 1 Rechazado
            new SolicitudCredito(
                Guid.NewGuid(),
                "Ana Martínez",
                new Moneda("MXN", 10000),
                "Rechazado"
            ),
            // 1 Aprobado
            new SolicitudCredito(
                Guid.NewGuid(),
                "Roberto Sánchez",
                new Moneda("MXN", 3000),
                "Aprobado"
            )
        };

        var pendingCredits = listCredits
            .Where(x => x.Estado == "Pendiente" && x.MontoSolicitado.Amount > 1000)
            .Select( x => new InfoFiltered(x.Id, x.Customer, x.MontoSolicitado.Amount)).ToList();

        foreach (var cred in pendingCredits)
        {
            Console.WriteLine($"Id: {cred.Id} - Cliente: {cred.Customer} - Monto Solicitado: {cred.Amount}");
        }

        var isSomeMoreThan10000 = listCredits.Any(x => x.MontoSolicitado.Amount > 100000);
        Console.WriteLine($"¿Alguna solicitud con monto mayor a 10,000? {isSomeMoreThan10000}");
    }
}

public record InfoFiltered(Guid Id, string Customer, decimal Amount);