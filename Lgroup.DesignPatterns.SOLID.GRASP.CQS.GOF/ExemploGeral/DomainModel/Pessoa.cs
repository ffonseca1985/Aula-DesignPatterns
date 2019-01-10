using System;

namespace ExemploGeral.DomainModel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public Sexo Sexo { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
    }
    public enum Sexo
    {
        Masculino, 
        Feminino
    }
    public enum EstadoCivil
    {
        Solteiro, 
        Casado,
        Viuvo,
        Divorciado,
        Amigado
    }
}
