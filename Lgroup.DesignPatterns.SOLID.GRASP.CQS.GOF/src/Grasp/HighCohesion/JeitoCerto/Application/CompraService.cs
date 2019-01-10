using HighCohesion.JeitoCerto.DomainModel;
using HighCohesion.JeitoCerto.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighCohesion.JeitoCerto.Application
{
    public class CompraService
    {
        //Responsavel por finalizar a compra
        private CarrinhoRepository _carrinhoRepository;
        private PedidoRespository _pedidoRepository;

        public CompraService()
        {
            _carrinhoRepository = new CarrinhoRepository();
            _pedidoRepository = new PedidoRespository();
        }

        public void FinalizarCompra(string sessao)
        {
            CarrinhoCompra carrinho = _carrinhoRepository.GetCarrinho(sessao);
            var pedido = carrinho.CriarPedidoApartirCarrinho();

            _pedidoRepository.Add(pedido);
        }
    }
}
