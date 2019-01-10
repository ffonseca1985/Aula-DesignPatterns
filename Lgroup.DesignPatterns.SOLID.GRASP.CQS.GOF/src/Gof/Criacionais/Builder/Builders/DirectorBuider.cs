using Builder.Contracts;
using Builder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class DirectorBuider
    {
        private MontadoraBuilder _montadora;
        public DirectorBuider(MontadoraBuilder montadora)
        {
            _montadora = montadora;
        }

        //Observações para analisar depois
        //1 - O carro pode ser uma abstração
        //2 - O builder não garante que o methodo builder será chamado
        //3 - Mas se chamado ele garante a integridade
        //4 - Para garantir a chamada  temos o pattern (Template Method)
        //TODO => Ver depois
        public void Builder(Carro carro)
        {
            _montadora.BuildPreco(carro.Preco);
            _montadora.BuildMotor(carro.Motor);
            _montadora.BuildAno(carro.Ano);
            _montadora.BuildLicenciamento(false);
            _montadora.BuildAdiciais(true);
            _montadora.BuildCor(carro.Cor);
        }

        public Carro GetCarro()
        {
            return _montadora.GetCarro();
        }
    }
}
