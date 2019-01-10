using System;
using TemplateMethod.Contracts;

namespace TemplateMethod.DomanModel
{
    public class VendaAmericanas : VendaTemplate
    {
        private Random _random;
        public VendaAmericanas()
        {
            _random = new Random();
        }

        protected override void DarBaixa()
        {
            Console.WriteLine("Baixa no estoque");
        }

        protected override bool EfetuarPagamento()
        {
            //50% de chance
            return _random.Next(0, 100) <= 50;
        }

        protected override bool PuxarCapivara(string cpf)
        {
            //50% de chance
            return _random.Next(0, 100) <= 50;
        }

        protected override bool ValidarEstoque()
        {
            //50% de chance
            return _random.Next(0, 100) <= 50;
        }
    }
}
