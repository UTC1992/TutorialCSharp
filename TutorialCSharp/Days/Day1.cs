namespace TutorialCSharp.Days;
using TutorialCSharp.Examples;

public class Day1
{
    public void runExcersise()
    {
        int age = 32;
        double price = 66.50;
        bool isActive = true;

        int age2 = age;
        age2 = 89;

        Console.WriteLine("Hello, World!");
        Console.WriteLine($"Age: {age}, Age2: {age2}");

        var person = new PersonDto("John", "Doe");
        Console.WriteLine($"Person: {person.FirstName} {person.LastName}");

        var person2 = person with {FirstName = "Juan"};
        Console.WriteLine($"Person2: {person2.FirstName} {person2.LastName}");

        string? name = "Pablo";
        name = null;

        if (name is not null)
        {
            Console.WriteLine($"Name: {name}");
        }

        var product = new Product
        {
            Name = "Laptop",
            Price = 1200.00m
        };

        Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");

        var country = new Country
        {
            Name = "Spain"
        };

        var country2 = country;
        country2.Name = "France";
        Console.WriteLine($"Country: {country.Name}, Country2: {country2.Name}");
        
        int number = 5;
        string username = "Alice";
        List<string> listNames = new List<string> { "Bob", "Charlie" };
        Dictionary<string, int> nameAges = new Dictionary<string, int> { { "Juan", 30 } };
        
        
        // tupla
        var personTuple = (Name: "Maria", Age: 28);
        var (x, y) = personTuple;
        Console.WriteLine($"Tuple: Name: {x}, Age: {y}");

        var struct1 = new Punto { X = 10, Y = 20 };
        
    }
}