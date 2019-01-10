using ProdutoRest.Data;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ProdutoRest.Contracts
{
    //Temos, no mínimo que falar que o item abaixo é um serviço
    [ServiceContract]
    public interface IProdutoService
    {
        //Temos que assinar o metodo com OperationContract
        [OperationContract]
        [WebInvoke(Method = "GET", 
                   RequestFormat = WebMessageFormat.Json,
                   ResponseFormat = WebMessageFormat.Json,
                   UriTemplate = "GetAll" )]
        List<Produto> GetAll();
    }
}