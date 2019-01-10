using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.JeitoErrado
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Email Email { get; set; }

        //1-Produto cuida de produto => Quem cuida de estoque é o estoque!!! 
        public void AtualizarEstoque(Estoque estoque, int qtde)
        {
            estoque.Qtde += qtde;
        }

        //GRASP => De acordo o padrão Creator do Grasp não posso criar email.
        //1 - Produto cuida de produto, ex: validações etc. (SPR => tenho mais de uma responsabilidade!!!)
        public void EnviarEmail(string de, string para, string mensagem)
        {
            Email = new Email();
            Email.De = de;
            Email.Para = para;
            Email.Mensagem = mensagem;

            Email.EnviarEmail();
        }
    }

    public class Estoque
    {
        public Produto Produto { get; set; }
        public int Qtde { get; set; }
    }

    public class Email
    {
        public string De { get; set; }
        public string Para { get; set; }
        public string Mensagem { get; set; }

        internal void EnviarEmail()
        {
            Console.WriteLine(string.Format("De: {0}, Para:{1}, Mensagem: {2}", De, Para, Mensagem));
        }
    }
}
