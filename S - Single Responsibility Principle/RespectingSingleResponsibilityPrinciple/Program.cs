using RespectingSingleResponsibilityPrinciple;
using RespectingSingleResponsibilityPrinciple.Factories;

var bookFactory = new BookFactory();
var book = bookFactory.CreateBookWithDummyText("Over Night", "Niklas Palmgren");

var bookPrinter = new BookPrinter();
bookPrinter.PrintToConsole(book.Text);

Console.ReadLine();
