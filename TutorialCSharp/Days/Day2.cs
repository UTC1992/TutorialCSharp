namespace TutorialCSharp.Days;
using TutorialCSharp.Examples;

public class Day2
{
    public void runExcersise()
    {
        Console.WriteLine("This is Day 2 exercise.");

        int Sum(int a, int b) => a + b;

        Operation operation = Sum;
        Console.WriteLine($"Sum of all operations is {operation(3, 3)}");

        Func<int, int, int> sum2 = (a, b) => a + b;
        var result = sum2(4, 5);
        Console.WriteLine($"Sum of all operations using Func is {result}");

        Action<string> hello = (name) => Console.WriteLine($"Hello, {name}!");
        hello("World Amazing");

        Predicate<int> isEven = (number) => number % 2 == 0;
        Console.WriteLine($"Is 4 even? {isEven(4)}");

        var isAdult = Validate(20, (age) => age >= 18);
        Console.WriteLine($"Is 20 an adult? {isAdult}");

        Func<int, int, int> substract = (a, b) => a - b;

        var difference = substract(10, 4);
        Console.WriteLine($"Difference is {difference}");

        Func<int, int, int> divide = (a, b) => a / b;

        Func<int, int, int> divide2 = (a, b) =>
        {
            if (b == 0)
                throw new ArgumentException("Division by zero is not allowed.");
            return a / b;
        };

        Func<int, int, int> divide3 = (a, b) => b == 0 ? 0 : a / b;

        var quotient2 = divide3(30, 0);
        Console.WriteLine($"Quotient is {quotient2}");

        Func<Product, bool> filterProducts = product => 
            product.Price > 50 && product.Stock > 10 && product.Category == "Electronics";
        var product = new Product
        {
            Name = "Laptop",
            Price = 1000,
            Category = "Electronics",
            Stock = 15
        };
        var isProductValid = filterProducts(product);
        Console.WriteLine($"Is product valid? {isProductValid}");
        
        Action<string> logMessage = message => Console.WriteLine($"Log: {message}");
        
        List<string> memoryLog = new List<string>();
        Action<string> logToMemory = message =>
        {
            memoryLog.Add(message);
            Console.WriteLine("Message logged to memory.");
        };
        
        
        ProcessLog("Processing started.", logMessage);
        ProcessLog("Processing in progress...", logToMemory);
        
        
        // Revisamos contenido de la memoria
        Console.WriteLine("\nContenido del memoryLog:");
        foreach (var msg in memoryLog)
        {
            Console.WriteLine($"[Memory] {msg}");
        }

    }

    private static bool Validate(int number, Predicate<int> rule)
    {
        return rule(number);
    }

    private static void ProcessLog(string message, Action<string> logger)
    {
        logger(message);
    }
    
}