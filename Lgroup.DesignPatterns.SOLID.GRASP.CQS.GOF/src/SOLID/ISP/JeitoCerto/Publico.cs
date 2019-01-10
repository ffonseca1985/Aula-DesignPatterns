using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.JeitoCerto
{
    class Publico : IAssalariado
    {
        public string Nome { get; set; }
        public decimal SalarioFixo { get; set; }

        public decimal GetSalario()
        {
            return SalarioFixo;
        }
        public void SairFerias()
        {
            Console.Write("Fui pra praia...");
        }
    }
}
