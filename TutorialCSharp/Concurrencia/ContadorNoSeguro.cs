namespace TutorialCSharp.Concurrencia;

public class ContadorNoSeguro
{
    private int _contador = 0;
    private readonly object _locker = new object();

    public void Incrementar()
    {
        lock (_locker)
        {
            _contador++;
        }
    }

    public int GetContador()
    {
        return _contador;
    }
}