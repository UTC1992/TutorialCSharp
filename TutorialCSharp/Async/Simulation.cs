namespace TutorialCSharp.Async;

public class Simulation
{
    public async Task<string> SimularLlamadaApiAsync(string name)
    {
        Console.WriteLine($"Inicio: {name}");
        await Task.Delay(2000);
        Console.WriteLine($"Fin: {name}");

        return name;
    }

    public async Task EjecutarConcurrenteAsync()
    {
        Console.WriteLine($"Inicio de la ejecución concurrente.");
        
        var task1 = SimularLlamadaApiAsync("Tarea 1, obtener usuaiod de DB");
        var task2 = SimularLlamadaApiAsync("Tarea 2, consultar Api externa");
        var task3 = SimularLlamadaApiAsync("Tarea 3, eliminar un recurso");
        
        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine("Todas las tareas han finalizado.");
        
        
    }
}