using ExemploGenerico.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploGenerico.DomainModels.Specifications
{
    public class OrSpecification<T>
    {
        public ISpecification<T> _left;
        public ISpecification<T> _right;
        public OrSpecification(ISpecification<T> left,
            ISpecification<T> right)
        {
            _left = left;
            _right = right;
        }
        public bool IsSatisfiedBy(T t)
        {
            return this._left.IsSatisfiedBy(t) ||
                   this._right.IsSatisfiedBy(t);
        }
    }
}
