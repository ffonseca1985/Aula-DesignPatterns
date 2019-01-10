using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.JeitoCerto
{
    public interface IComissionado : IFuncionario
    {
        decimal TxComissao { get; set; }
        decimal GetTotalVendas();
    }
}
