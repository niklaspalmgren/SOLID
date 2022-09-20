using ViolatingOpenClosedPrinciple.Enums;

namespace ViolatingOpenClosedPrinciple.Factories
{
    public class CarFactory
    {
        public List<Car> CreateDemoCars()
        {

            var cars = new List<Car>
            {
                new Car { Model = "Seat", Fuel = Fuel.Petrol, BodyStyle = BodyStyle.SUV, FuelConsumption = 1.2 },
                new Car { Model = "Mazda 3", Fuel = Fuel.Petrol, BodyStyle = BodyStyle.Minivan, FuelConsumption = 0.7 },
                new Car { Model = "BMW 332", Fuel = Fuel.Petrol, BodyStyle = BodyStyle.Coupe, FuelConsumption = 0.8 },
                new Car { Model = "Corvette", Fuel = Fuel.Petrol, BodyStyle = BodyStyle.Convertible, FuelConsumption = 1.4 },
                new Car { Model = "Tyota RAV 4", Fuel = Fuel.Diesel, BodyStyle = BodyStyle.SUV, FuelConsumption = 0.6 }
            };

            return cars;
        }
    }
}
