namespace RespectingOpenClosedPrinciple.Interfaces
{
    public interface IFilter<T>
    {
        List<T> Filter(IEnumerable<T> monitors, ISpecification<T> specification);
    }
}
