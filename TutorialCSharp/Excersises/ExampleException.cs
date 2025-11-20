namespace TutorialCSharp.Excersises;
using TutorialCSharp.Exceptions;
using TutorialCSharp.Resources;

public class ExampleException
{
    public void Run()
    {
        Console.WriteLine("Ejemplo de manejo de excepciones");
        using (var conexion = new ConexionDeBaseDeDatosFicticia())
        {
            Console.WriteLine("Process data...");

            throw new MontoMinimoRechazadoException("El monto minimo no fue alcanzado.");
        }
    }
}