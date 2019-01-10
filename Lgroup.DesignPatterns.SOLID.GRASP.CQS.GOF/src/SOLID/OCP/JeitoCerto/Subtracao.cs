using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP.JeitoCerto
{
    public class Subtracao : IOperacao
    {
        public decimal NumeroA { get; set; }
        public decimal NumeroB { get; set; }
        public decimal Operar()
        {
            return NumeroA - NumeroB;
        }
    }
}
