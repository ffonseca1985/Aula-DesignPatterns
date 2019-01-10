using OCP.JeitoCerto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Jeito errado
            var operacoes = new JeitoErrado.OperacoesMatematicas();
            var soma = operacoes.Operar(1, 1, JeitoErrado.TipoOperacao.soma);

            //Jeito certo
            var operacoes2 = new Calculadora();

            var soma2 = new Soma();
            soma2.NumeroA = 1;
            soma2.NumeroB = 2;

            var somar = operacoes2.Operar(soma2);

            var substracao = new Subtracao();
            substracao.NumeroA = 1;
            substracao.NumeroB = 2;

            var subtrair = operacoes2.Operar(substracao);

            var multiplicacao = new Multiplicacao();
            multiplicacao.NumeroA = 1;
            multiplicacao.NumeroB = 2;

            var multiplicar = operacoes2.Operar(multiplicacao);
        }
    }
}
