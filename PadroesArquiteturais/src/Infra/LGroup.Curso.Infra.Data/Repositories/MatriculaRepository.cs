using LGroup.Curso.PadroesArquiteturais.Contracts.Repositories;
using System;
using System.Collections.Generic;
using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity;
using System.Linq;

namespace LGroup.Curso.Infra.Data.Repositories
{
    public class MatriculaRepository : IMatriculaRepository
    {
        private List<DbContext> _context;

        public MatriculaRepository(List<DbContext> context)
        {
            _context = context;
        }

        public void Add(Matricula matricula)
        {
            _context.ToList().ForEach(x =>
            {
                x.Set<Matricula>().Add(matricula);
                x.SaveChanges();
            });
        }

        public IEnumerable<Matricula> GetAll()
        {
            return _context[0].Set<Matricula>().ToList();
        }
    }
}
