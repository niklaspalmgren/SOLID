using RespectingOpenClosedPrinciple;
using RespectingOpenClosedPrinciple.Enums;
using RespectingOpenClosedPrinciple.Factories;

var filter = new CarFilter();

// factories
var carFactory = new CarFactory();
var carSpecificationFactory = new CarSpecificationFactory();

// Demo data
var cars = carFactory.CreateDemoCars();

// Filtered demo data
var petrolCars = filter.Filter(cars, carSpecificationFactory.CreateFuelSpecification(Fuel.Petrol));
var suvCars = filter.Filter(cars, carSpecificationFactory.CreateBodyStyleSpecification(BodyStyle.SUV));

Console.WriteLine("All petrol cars");
foreach (var car in petrolCars)
{
    Console.WriteLine($"Model: {car.Model}, Fuel: {car.Fuel}, Body Style: {car.BodyStyle}, Fuel Consumption: {car.FuelConsumption}");
}

Console.WriteLine();

Console.WriteLine("All SUV cars");
foreach (var car in suvCars)
{
    Console.WriteLine($"Model: {car.Model}, Fuel: {car.Fuel}, Body Style: {car.BodyStyle}, Fuel Consumption: {car.FuelConsumption}");
}