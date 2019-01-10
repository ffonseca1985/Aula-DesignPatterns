using System;

namespace SRP.JeitoCerto
{
    public class Estoque
    {
         public Produto Produto { get; set; }
         public int Qtde { get; set; }

        //1-Produto cuida de produto => Quem cuida de estoque é o estoque!!! 
        public void Adicionar(int qtde)
        {
            ValidarEntrada(qtde);
            this.Qtde += qtde;
        }

        public void Remover(int qtde)
        {
            ValidarEntrada(qtde);
            this.Qtde -= qtde;            
        }

        public bool ValidarEstoqueAtual(int qtde)
        {
            return this.Qtde - qtde < 0;
        }

        private void ValidarEntrada(int qtde)
        {
            if (qtde < 0)
                throw new ApplicationException("A quantidade deve ser positiva");
        }
    }
}
