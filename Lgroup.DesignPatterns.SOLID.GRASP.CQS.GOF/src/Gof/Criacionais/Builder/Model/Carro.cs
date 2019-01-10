using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Model
{
    public class Carro
    {
        public decimal Preco { get; set; }
        public string Motor { get; set; }
        public string Cor { get; set; }
        public Adicionais Adicionais { get; set; }
        public int Ano { get; set; }
        public Licenciamento  Licenciamento { get; set; }
        public decimal GetTotal()
        {
            return Preco + Adicionais.Total + Licenciamento.Total;
        }
    }

    public class Adicionais
    {
        public decimal Total { get; set; } = 1000M;
    }

    public class Licenciamento
    {
        public decimal Total { get; set; } = 1200M;
    }
}
