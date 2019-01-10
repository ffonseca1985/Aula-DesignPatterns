using Builder.Contracts;
using Builder.Model;
using System;

namespace Builder.Builders
{
    public class FiatBuilder : MontadoraBuilder
    {
        public override void BuildAdiciais(bool tem)
        {
            base.Carro.Adicionais = new Adicionais();

            if (!tem)
                base.Carro.Adicionais.Total = 0M;
        }

        public override void BuildAno(int ano)
        {
            base.Carro.Ano = ano;

            if (ano > 2016)
                base.Carro.Preco *= 1.3M;
        }

        public override void BuildCor(string cor)
        {
            base.Carro.Cor = cor;

            if (cor == "branca")
                base.Carro.Preco *= 0.97M;
        }

        public override void BuildLicenciamento(bool tem)
        {
            base.Carro.Licenciamento = new Licenciamento();

            if (!tem)
                base.Carro.Licenciamento.Total = 0;
        }

        public override void BuildMotor(string tipo)
        {
            base.Carro.Motor = tipo;

            if (tipo == "V3")
                base.Carro.Preco += 100;

            else if (tipo == "V4")
                base.Carro.Preco += 200;

            else if(tipo == "V5")
                base.Carro.Preco += 300;
            else 
                base.Carro.Preco += 500;
        }

        public override void BuildPreco(decimal preco)
        {
            base.Carro.Preco = preco;
        }
    }
}
