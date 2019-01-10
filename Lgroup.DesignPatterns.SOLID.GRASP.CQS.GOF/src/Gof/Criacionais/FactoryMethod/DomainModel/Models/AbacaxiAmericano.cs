using FactoryMethod.DomainModel.Constracts;

namespace FactoryMethod.DomainModel.Models
{
    public class AbacaxiAmericano : IAbacaxi
    {
        public string Localizacao { get; set; }
        public string Nome { get; set; }
        public string GetDescricao()
        {
            return $"{this.Nome} - {this.Localizacao}";
        }
    }
}
