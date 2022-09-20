using RespectingSingleResponsibilityPrinciple.Factories;

var bookFactory = new BookFactory();
var book = bookFactory.CreateBookWithDummyText("Over Night", "Niklas Palmgren");

book.PrintBookTextToConsole();

Console.ReadLine();