using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.JeitoCerto
{
    public class Calculadora
    {
        //Não estou passando uma classe concrete e sim uma abstração
        //A classe calculadora não conhece a implementação da operação que esta vindo
        //Quem decide qual operação vai ser executada é o client que chama calculadora
        //Ou seja eu inverti o controle da operação... quem tem controle da implementação
        //é o cliente e não calculado
        public decimal Operar(IOperacao operacao)
        {
            return operacao.Operar();
        }
    }
}
