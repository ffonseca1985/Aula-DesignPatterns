using System.Collections.Generic;
using entity = LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;

namespace LGroup.Curso.PadroesArquiteturais.Contracts.Repositories
{
    public interface ICursoRepository
    {
        void Add(entity.Curso aluno);
        IEnumerable<entity.Curso> GetAll();
    }
}
