using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.JeitoErrado
{
    public class OperacoesMatematicas
    {
        public decimal Operar(decimal numA, decimal numB, TipoOperacao tipoOperacao)
        {
            if (tipoOperacao == TipoOperacao.soma)
                return numA + numB;

            if (tipoOperacao == TipoOperacao.subtracao)
                return numA - numB;

            if (tipoOperacao == TipoOperacao.divizao)
            {
                if (numB == 0)
                    throw new DivideByZeroException("O denominador não pode ser nulo");

                return numA / numB;
            }

            else
                return numA * numB;
        }
    }

    public enum TipoOperacao
    {
        soma, 
        subtracao,
        divizao,
        multiplicacao
    }
}
