using ViolatingOpenClosedPrinciple.Enums;

namespace ViolatingOpenClosedPrinciple
{
    public class CarFilter
    {
        public List<Car> FilterByBodyStyle(IEnumerable<Car> cars, BodyStyle bodyStyle) =>
                cars.Where(m => m.BodyStyle == bodyStyle).ToList();

        public List<Car> FilterByFuel(IEnumerable<Car> cars, Fuel fuel) =>
                cars.Where(m => m.Fuel == fuel).ToList();

    }
}
