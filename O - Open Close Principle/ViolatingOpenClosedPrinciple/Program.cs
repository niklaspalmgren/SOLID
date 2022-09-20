
using ViolatingOpenClosedPrinciple;
using ViolatingOpenClosedPrinciple.Enums;
using ViolatingOpenClosedPrinciple.Factories;

var carFactory = new CarFactory();
var cars = carFactory.CreateDemoCars();

var filter = new CarFilter();

var petrolCars = filter.FilterByFuel(cars, Fuel.Petrol);
var suvCars = filter.FilterByBodyStyle(cars, BodyStyle.SUV);

Console.WriteLine("All petrol cars");
foreach (var car in petrolCars)
{
    Console.WriteLine($"Model: {car.Model}, Fuel: {car.Fuel}, Body Style: {car.BodyStyle}, Fuel Consumption: {car.FuelConsumption}");
}

Console.WriteLine("");

Console.WriteLine("All SUV cars");
foreach (var car in suvCars)
{
    Console.WriteLine($"Model: {car.Model}, Fuel: {car.Fuel}, Body Style: {car.BodyStyle}, Fuel Consumption: {car.FuelConsumption}");
}