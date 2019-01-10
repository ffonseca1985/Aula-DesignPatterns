using DomainEvents.Events;
using DomainEvents.ServiceLocators;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DomainEvents.Model
{
    public class Venda
    {
        public List<int> Produtos { get; set; }
        public Venda()
        {
            Produtos = new List<int>() { 1, 2 };
        }
        public void Finalizar()
        {
            Console.WriteLine("Finalizei a venda com sucesso");

            Task.Run(()=> {

                foreach (var item in Produtos)
                {
                    DisparadorEventoEncomenda.Disparar(
                        new EncomentaEvent(item.ToString()));
                }
            });
        }
    }
}
