namespace TutorialCSharp.ColeccionesMutabilidad;

public class ColeccionesMutabilidad
{
    public void Run()
    {
        Console.WriteLine("Colecciones y Mutabilidad");
        var booking1 = new Booking(1, new Detalle("Item 1", 100m));
        booking1.AgregarDetalle(new Detalle("Item 1", 100m));
        booking1.AgregarDetalle(new Detalle("Item 2", 200m));
        booking1.AgregarDetalle(new Detalle("Item 3", 300m));
        booking1.AgregarDetalle(new Detalle("Item 4", 400m));
        booking1.AgregarDetalle(new Detalle("Item 5", 500m));
        
        var booking2 = new Booking(2, new Detalle("Item 1", 100m));
        var booking3 = new Booking(3, new Detalle("Item 1", 100m));
        var booking4 = new Booking(4, new Detalle("Item 1", 100m));
        var booking5 = new Booking(5, new Detalle("Item 1", 100m));
        var booking6 = new Booking(6, new Detalle("Item 1", 100m));
        
        var bookingLists = new List<Booking>
        { 
            booking1, booking2, booking3, booking4, booking5, booking6
        };


        var dictionary = bookingLists.ToDictionary(b => b.Id);


        var bookingValue1 = dictionary[1];
        Console.WriteLine(bookingValue1.Id);
        
        foreach (var keyValuePair in dictionary)
        {
            Console.WriteLine($"Clave: {keyValuePair.Key}, " + $"Cuerpo: Detalles {dictionary[keyValuePair.Key].Detalles.Count}, Id: {dictionary[keyValuePair.Key].Id}");
        }

    }
}