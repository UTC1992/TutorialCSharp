namespace TutorialCSharp.Concurrencia;

public class TestLesson
{
    public async Task Run()
    {
        int iteraciones = 10000;
        var contadorNoSeguro = new ContadorNoSeguro();

        // Delegate Action: define la acción a ejecutar
        var incrementarMultiple = () =>
        {
            for (int i = 0; i < iteraciones; i++)
            {
                contadorNoSeguro.Incrementar();
            }
        };

        await Task.WhenAll([
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple),
            Task.Run(incrementarMultiple)
        ]);

        Console.WriteLine($"Contador esperado: {iteraciones * 5}");
        Console.WriteLine($"Contador real: {contadorNoSeguro.GetContador()}");
        Console.WriteLine($"Diferencia: {(iteraciones * 5) - contadorNoSeguro.GetContador()}");
    }
    
}