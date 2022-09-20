using RespectingOpenClosedPrinciple.Enums;
using RespectingOpenClosedPrinciple.Interfaces;
using RespectingOpenClosedPrinciple.Models;

namespace RespectingOpenClosedPrinciple
{
    public sealed class FuelSpecification : ISpecification<Car>
    {
        private readonly Fuel _fuel;

        public FuelSpecification(Fuel fuel)
        {
            _fuel = fuel;
        }

        public bool IsSatisfied(Car car) => car.Fuel == _fuel;
    }
}
