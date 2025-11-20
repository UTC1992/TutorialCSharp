namespace TutorialCSharp.Days;
using TutorialCSharp.Credits;

public class Day3
{
    public void Run()
    {
        Moneda moneda = new Moneda("USD", 1800);
        var moneda2 = moneda with {Amount = 2000};
        Console.WriteLine($"Moneda 1: {moneda.Code} - {moneda.Amount}");
        Console.WriteLine($"Moneda 2: {moneda2.Code} - {moneda2.Amount}");
        Console.WriteLine(moneda == moneda2);
    }
}