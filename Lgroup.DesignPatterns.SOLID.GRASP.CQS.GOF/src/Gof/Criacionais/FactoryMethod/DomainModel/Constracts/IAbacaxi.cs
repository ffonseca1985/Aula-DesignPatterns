using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.DomainModel.Constracts
{
    public interface IAbacaxi
    {
        string Nome { get; set; }
        string Localizacao { get; set; }
        string GetDescricao();
    }
}
