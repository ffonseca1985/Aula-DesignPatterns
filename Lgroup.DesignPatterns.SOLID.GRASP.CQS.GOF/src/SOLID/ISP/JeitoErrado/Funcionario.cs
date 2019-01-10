using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.JeitoErrado
{
    public abstract class Funcionario
    {
        public double Salario { get; set; }
        public virtual double GetSalarioTotal()
        {
            return Salario;
        }
        public abstract void SairFerias();
        public abstract double GetComissao();
    }

    public class Representante : Funcionario
    {
        //Exemplo pra evitar perda de tempo
        public override double GetSalarioTotal()
        {
            //suponha o calculo já foi feito baseado na comissão
            return 12000;
        }

        public override double GetComissao()
        {
            return 0.12;
        }

        public override void SairFerias()
        {
            throw new NotImplementedException();
        }
    }
}
