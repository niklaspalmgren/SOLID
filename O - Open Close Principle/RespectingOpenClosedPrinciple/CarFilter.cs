using RespectingOpenClosedPrinciple.Interfaces;
using RespectingOpenClosedPrinciple.Models;

namespace RespectingOpenClosedPrinciple
{
    internal class CarFilter : IFilter<Car>
    {
        public List<Car> Filter(IEnumerable<Car> cars, ISpecification<Car> specification)
        {
            return cars.Where(x => specification.IsSatisfied(x)).ToList();
        }
    }
}
