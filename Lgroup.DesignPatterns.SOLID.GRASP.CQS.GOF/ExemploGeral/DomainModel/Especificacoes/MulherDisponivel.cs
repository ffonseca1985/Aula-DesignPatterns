using System;
using System.Linq.Expressions;

namespace ExemploGeral.DomainModel.Especificacoes
{
    public class MulherDisponivel
    {
        //Aqui estou dizendo que dado uma pessoa vou verificar se
        //ela é valida ou não..
        public static Expression<Func<Pessoa, bool>> IsValid()
        {
            //uma especificação é uma expressão
            Expression<Func<Pessoa, bool>> expression = 
                            (Pessoa x) => x.Sexo == Sexo.Feminino
                            && (x.EstadoCivil == EstadoCivil.Solteiro
                            || x.EstadoCivil == EstadoCivil.Divorciado
                            || x.EstadoCivil == EstadoCivil.Viuvo);

            return expression;
        }
    }
}
