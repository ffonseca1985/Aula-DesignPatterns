using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.JeitoCerto
{
    public class Vendedor : IComissionado
    {
        public string Nome { get; set; }

        public decimal TxComissao { get; set; }

        public decimal GetSalario()
        {
            return GetTotalVendas() * TxComissao;
        }

        public decimal GetTotalVendas()
        {
            return 120000M;
        }
    }
}
