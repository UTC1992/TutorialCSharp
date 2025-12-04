namespace TutorialCSharp.Project2Week;

public class Projecto2Week
{
    public async Task Run()
    {
        var service = new EstadisticaService();

        var iteraciones = 10000;
        var incrementarMultiple = () =>
        {
            for (int i = 0; i < iteraciones; i++)
            {
                
                var solicitud = new Solicitud(
                    Id: new Random().Next(1, int.MaxValue), // Usaremos un ID entero grande para evitar colisiones raras en el test
                    CodigoCliente: $"CLIENTE_{i % 2000}", // Solo 2000 clientes únicos por tarea
                    Monto: 100m + (decimal)i
                );
                if (i <= 9990)
                {
                    service.RegistrarSolicitud(solicitud);
                }
                else
                {
                    service.RegistrarSolicitud(solicitud);
                }
            }
        };

        await Task.WhenAll([
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
        ]);

        var estadisticas = service.ObtenerEstadisticas();
        
        Console.WriteLine($"--- Resultados de Concurrencia ---");
        Console.WriteLine($"Total solicitudes (Esperado: 50000): {estadisticas.TotalSolicitudes}");
        Console.WriteLine($"Total clientes únicos (Esperado: ~10000): {estadisticas.TotalClientesUnicos}");

    }
}