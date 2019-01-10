using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using LGroup.Curso.PadroesArquiteturais.DomainModel.ValueObjects;
using System;
using System.Collections.Generic;

namespace LGroup.Curso.PadroesArquiteturais.DomainModel.Entities
{
    public class Curso
    {
        private Curso() { }
        public Curso(string nome)
        {
            this.Nome = nome;
            this.Matriculas = new List<Matricula>();
        }
        public int Id { get; private set; }
        public string Nome { get; private set; }

        //Preço não é FK, é um OV (objecto de valor)
        public Preco Preco { get; private set; }

        public void AddPreco(decimal cotacao, Moeda moeda, decimal valor) {

            if (cotacao == default(decimal))
                throw new ApplicationException("cotação invalida");

            if (valor <= default(decimal))
                throw new ApplicationException("valor invalido");

            this.Preco = new Preco(cotacao, moeda, valor);
        }
        
        public List<Matricula> Matriculas { get; set; }
    }
}
