namespace ExemploGenerico.Contracts
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T t);
        ISpecification<T> And(ISpecification<T> specification);
        ISpecification<T> or(ISpecification<T> specification);
        ISpecification<T> Not(ISpecification<T> specification);
    }
}
