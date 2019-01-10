using Decorator.DomainModel.Decorator.Contracts;
using Decorator.Contracts;

namespace Decorator.DomainModel.Decorator.Arma
{
    public class ArmaComMira : IArmaDecorator
    {
        private IArma _arma;
        public ArmaComMira(IArma arma) 
            : base(arma)
        {
            _arma = arma;
        }

        public override void Montar()
        {
            //Montar a arma existente
            //Adicionar algon
            //No caso uma mira
             _arma.Nome += " => Adicionei uma mira na arma existente \n";
        }
    }
}
