// See https://aka.ms/new-console-template for more information

using TutorialCSharp.Days;
using TutorialCSharp.Excersises;
using TutorialCSharp.Generics;
using TutorialCSharp.Async;

var day1 = new Day1();
// day1.runExcersise();

var day2 = new Day2();
// day2.runExcersise();

var day3 = new Day3();
// day3.Run();

var day2Linq = new EjercicioLinq();
// day2Linq.Run();

var day3Exceptions = new ExampleException();
// try
// {
//     day3Exceptions.Run();
// }
// catch
// {
//     throw;
// }

// evitar que se pueda usar un tipo generico que no sea del tipo que se desea
// con where T se le dice que T debe heredar de una clase que  se define o un tipo que se defina
// esto ayuda a restringir los tipos que se pueden usar con genericos
// IRepository<Currency> currencyRepository;

var asyncExample = new Simulation();
// var response = await asyncExample.SimularLlamadaApiAsync("Omar");
// Console.WriteLine($"Respuesta: {response}");

// await asyncExample.EjecutarConcurrenteAsync();

var linqAdvance = new ExercisesLINQAdvance();
linqAdvance.Run();