using Observer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.DomainModel
{
    //Muito parecido com o composite do estrutural
    public class NewsLetters : INewsLetters
    {
        public IList<IAssinante> _assinantes;

        public NewsLetters()
        {
            _assinantes = new List<IAssinante>();
        }

        public void EnviarEmail()
        {
            _assinantes.ToList().ForEach(x => x.ReceberEmail());
        }

        public void Registrar(IAssinante assinante)
        {
            _assinantes.Add(assinante);
        }

        public void Remove(IAssinante assinante)
        {
            _assinantes.Remove(assinante);
        }
    }
}
