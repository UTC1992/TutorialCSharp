// See https://aka.ms/new-console-template for more information

using TutorialCSharp.Days;
using TutorialCSharp.Excersises;
using TutorialCSharp.Generics;

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

IRepository<Currency> currencyRepository;
