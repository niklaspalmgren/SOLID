using RespectingOpenClosedPrinciple.Enums;
using RespectingOpenClosedPrinciple.Interfaces;
using RespectingOpenClosedPrinciple.Models;

namespace RespectingOpenClosedPrinciple
{
    internal sealed class BodyStyleSpecification : ISpecification<Car>
    {
        private readonly BodyStyle _bodyStyle;

        public BodyStyleSpecification(BodyStyle bodyStyle)
        {
            _bodyStyle = bodyStyle;
        }

        public bool IsSatisfied(Car car) => car.BodyStyle == _bodyStyle;

    }
}
