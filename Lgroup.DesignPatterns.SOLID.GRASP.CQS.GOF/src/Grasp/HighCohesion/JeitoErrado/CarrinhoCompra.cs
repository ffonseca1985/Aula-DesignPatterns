using System.Collections.Generic;

namespace HighCohesion.JeitoErrado
{
    //Padrão active records
    public class CarrinhoCompra
    {
        private IConnection _connection;
        private ICommand _command;

        public CarrinhoCompra(IConnection connection, ICommand command)
        {
            _connection = connection;
            _command = command;
        }

        public Pedido Pedido { get; set; }
        public List<ItemCarrinho> Itens { get; set; } 

        public void CriarPedido()
        {
            //Vai provavelmente irá ter uma factory para
            //criar a instancia do pedido baseado no carrinho

            _connection.Open();

            _command.Execute(_connection, "insert into....");
            
            _connection.Close();
        } 
    }
}
