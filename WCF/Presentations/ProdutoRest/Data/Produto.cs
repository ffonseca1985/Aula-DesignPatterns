using System.Runtime.Serialization;

namespace ProdutoRest.Data
{
    [DataContract]
    public class Produto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public decimal Preco { get; set; }
    }
}