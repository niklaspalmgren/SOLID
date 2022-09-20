using RespectingOpenClosedPrinciple.Enums;
using RespectingOpenClosedPrinciple.Interfaces;
using RespectingOpenClosedPrinciple.Models;

namespace RespectingOpenClosedPrinciple.Factories
{
    internal class CarSpecificationFactory
    {
        public ISpecification<Car> CreateFuelSpecification(Fuel fuel)
        {
            return new FuelSpecification(fuel);
        }

        public ISpecification<Car> CreateBodyStyleSpecification(BodyStyle bodyStyle)
        {
            return new BodyStyleSpecification(bodyStyle);
        }
    }
}
