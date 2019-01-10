using Composite.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.DomainModel.Services
{
    //Esta classe irá formar qualquer serviço de formatação
    //que vc precisar...
    //Com o auxilio das classes existentes iremos gerar todos os tipos 
    //de formatção que quisermos
    public class FormatacaoGeralService
        : IFormatacao
    {
        private IList<IFormatacao> _formatacoes;

        public FormatacaoGeralService()
        {
            _formatacoes = new List<IFormatacao>();
        }

        public void Adicionar(IFormatacao formatacao)
        {
            _formatacoes.Add(formatacao);
        }

        public void Remover(IFormatacao formatacao)
        {
            _formatacoes.Remove(formatacao);
        }
        public void Formatar()
        {
            _formatacoes.ToList().ForEach(x => x.Formatar());
        }
    }
}
