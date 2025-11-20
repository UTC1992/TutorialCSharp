namespace TutorialCSharp.Examples;

public record PersonDto(string FirstName, string LastName);

public record ProductRecord
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    
    // you could create a constructor
    public ProductRecord(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
}