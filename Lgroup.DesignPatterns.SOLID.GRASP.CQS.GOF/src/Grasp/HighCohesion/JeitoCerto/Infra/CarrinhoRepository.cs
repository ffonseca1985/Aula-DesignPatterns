using HighCohesion.JeitoCerto.DomainModel;
using System;

namespace HighCohesion.JeitoCerto.Infra
{
    public class CarrinhoRepository
    {
        public void Add(CarrinhoCompra carrinho)
        {
            Console.WriteLine("Adicionar Carrinho");
        }

        //Simulação...
        public CarrinhoCompra GetCarrinho(string sessao)
        {
            return new CarrinhoCompra();
        }
    }
}
