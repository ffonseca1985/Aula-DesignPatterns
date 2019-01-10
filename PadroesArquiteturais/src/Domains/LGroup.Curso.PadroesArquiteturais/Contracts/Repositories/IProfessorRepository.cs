using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Collections.Generic;

namespace LGroup.Curso.PadroesArquiteturais.Contracts.Repositories
{
    public interface IProfessorRepository
    {
        void Add(Professor professor);
        IEnumerable<Professor> GetAll();
    }
}
