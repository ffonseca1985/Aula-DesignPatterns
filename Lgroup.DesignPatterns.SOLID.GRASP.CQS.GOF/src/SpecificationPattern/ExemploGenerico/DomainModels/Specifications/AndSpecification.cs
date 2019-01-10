using ExemploGenerico.Contracts;

namespace ExemploGenerico.DomainModels.Specifications
{
    public class AndSpecification<T>
    {
        public ISpecification<T> _left;
        public ISpecification<T> _right;
        public AndSpecification(ISpecification<T> left, 
            ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
        public bool IsSatisfiedBy(T t)
        {
            return this._left.IsSatisfiedBy(t) &&
                   this._right.IsSatisfiedBy(t); 
        }
    }
}
