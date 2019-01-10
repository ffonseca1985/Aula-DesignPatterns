using Bridge.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;

namespace Bridge.DomainModel
{
    public class EstoqueLGroupAltaDisponibilidade
    {
        private static IDictionary<int, int> _fila;
        private ILogistica _estoque;
        public readonly object _lock = new object();

        public EstoqueLGroupAltaDisponibilidade(ILogistica estoque)
        {
            _fila = new Dictionary<int, int>();
            _estoque = estoque;
            
        }
        public void BaixarEstoqueAltaDisponibilidade(int idProduto, int qtde)
        {
            Task.Run(() =>
            {
                lock (_lock)
                {
                    Console.WriteLine($"Estoque em Fila");
                    _fila.Add(new KeyValuePair<int, int>(idProduto, qtde));

                    Thread.Sleep(1000);

                    _estoque.BaixarEstoque(_fila.Keys.FirstOrDefault(), _fila[_fila.Keys.First()]);
                    _fila.Remove(1);

                    Console.WriteLine($"Estoque Adicionado");
                }
            });
        }

    }
}
