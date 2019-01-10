using ProdutoRest.Contracts;
using ProdutoRest.Data;
using System.Collections.Generic;

namespace ProdutoRest.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProdutoService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ProdutoService.svc or ProdutoService.svc.cs at the Solution Explorer and start debugging.
    public class ProdutoService : IProdutoService
    {
        public List<Produto> GetAll()
        {
            //Posso disponibilizar este serviço de diversar formas
            //Por exemplo:
            //serviço via HTTP
            //serviço via TCP
            //serviço via Pipe
            //serviço via Msmq

            //Logo antes de disponibilizar o serviço, preciso definir 
            //um endpoint:
            //O que diz o endpoint:
            //ABC => 
            //Addrees => localhost:8080/ProdutoService/
            //Binding => basichttpBinding, webhttpbinding, wstcpbinding etc
            //Contract => IProdutoService
            return new List<Produto>()
            {
                new Produto() { Id = 1, Nome = "curso online", Preco= 100m},
                new Produto() { Id = 2, Nome = "curso presencial", Preco = 500m }
            };
        }
    }
}
