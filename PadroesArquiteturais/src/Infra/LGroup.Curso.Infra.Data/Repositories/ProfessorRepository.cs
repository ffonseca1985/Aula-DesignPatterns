using System;
using System.Collections.Generic;
using LGroup.Curso.PadroesArquiteturais.Contracts.Repositories;
using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity;
using System.Linq;

namespace LGroup.Curso.Infra.Data.Repositories
{
    public class ProfessorRepository
        : IProfessorRepository
    {
        private List<DbContext> _context;

        public ProfessorRepository(List<DbContext> context)
        {
            _context = context;
        }

        public void Add(Professor professor)
        {
            _context.ToList().ForEach(x =>
            {
                x.Set<Professor>().Add(professor);
                x.SaveChanges();
            });
        }

        public IEnumerable<Professor> GetAll()
        {
            return _context[0].Set<Professor>().ToList();
        }
    }
}
