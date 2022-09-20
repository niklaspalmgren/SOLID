namespace RespectingOpenClosedPrinciple.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T item);
    }
}
