namespace TutorialCSharp.Resources;

public class ConexionDeBaseDeDatosFicticia : IDisposable
{
    public ConexionDeBaseDeDatosFicticia()
    {
        Console.WriteLine("Base de datos conectada.");
    }
    
    public void Dispose()
    {
        // Aquí iría el código para cerrar la conexión a la base de datos
        Console.WriteLine("Conexión a la base de datos cerrada.");
    }
}