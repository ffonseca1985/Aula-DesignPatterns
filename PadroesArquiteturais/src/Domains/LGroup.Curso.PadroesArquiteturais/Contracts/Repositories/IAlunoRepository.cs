using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Collections.Generic;

namespace LGroup.Curso.PadroesArquiteturais.Contracts.Repositories
{
    public interface IAlunoRepository
    {
        void Add(Aluno aluno);
        IEnumerable<Aluno> GetAll();
    }
}
