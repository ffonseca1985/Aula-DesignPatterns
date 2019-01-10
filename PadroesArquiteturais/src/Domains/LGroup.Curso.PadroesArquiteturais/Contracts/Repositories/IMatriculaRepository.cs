using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Collections.Generic;

namespace LGroup.Curso.PadroesArquiteturais.Contracts.Repositories
{
    public interface IMatriculaRepository
    {
        void Add(Matricula matricula);
        IEnumerable<Matricula> GetAll();
    }
}
