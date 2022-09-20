using ViolatingOpenClosedPrinciple.Enums;

namespace ViolatingOpenClosedPrinciple
{
    public class Car
    {

        public string Model { get; init; } = string.Empty;
        public Fuel Fuel { get; init; }
        public BodyStyle BodyStyle { get; init; }
        public double FuelConsumption { get; init; }
        public double HorsePower { get; init; }
    }
}
