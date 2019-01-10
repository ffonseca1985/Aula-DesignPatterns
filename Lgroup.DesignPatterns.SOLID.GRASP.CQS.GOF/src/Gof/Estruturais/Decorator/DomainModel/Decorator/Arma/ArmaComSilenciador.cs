using Decorator.DomainModel.Decorator.Contracts;
using Decorator.Contracts;

namespace Decorator.DomainModel.Decorator.Arma
{
    public class ArmaComSilenciador : IArmaDecorator
    {
        private IArma _arma;
        public ArmaComSilenciador(IArma arma) 
            : base(arma)
        {
            _arma = arma;
        }

        public override void Montar()
        {
            _arma.Nome += " => Adicionei um silenciador na arma existente \n";
        }
    }
}
