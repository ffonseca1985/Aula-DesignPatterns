using System;
using Decorator.Contracts;

namespace Decorator.DomainModel.Decorator.Contracts
{
    //É a arma mais os acessórios
    public abstract class IArmaDecorator
    {
        private IArma _arma;
        public IArmaDecorator(IArma arma)
        {
            _arma = arma;
        }

        //Virtual quer dizer que pode ser modificada 
        //pelo filho.
        public virtual void Montar()
        {
            _arma.Montar();
        }
    }
}
