namespace LGroup.Curso.PadroesArquiteturais.DomainModel.Entities
{
    public class Matricula
    {
        public int Id { get; set; }

        //Para habilitar o LazyLoad temos que colocar o virtual na propriedade
        //Também temos que referenciar um Identificador para a foreignint key
        public int IdCurso { get; set; }
        public virtual Curso Curso { get; set; }


        //O IdAluno será a foreignkey de Aluno
        public int IdAluno { get; set; }
        public virtual Aluno Aluno { get; set; }
    }
}
