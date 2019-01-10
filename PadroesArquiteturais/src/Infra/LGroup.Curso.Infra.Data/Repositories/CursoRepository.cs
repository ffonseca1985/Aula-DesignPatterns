using LGroup.Curso.PadroesArquiteturais.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using System.Data.Entity;

namespace LGroup.Curso.Infra.Data.Repositories
{
    using PadroesArquiteturais.DomainModel.Entities;
    public class CursoRepository : ICursoRepository
    {
        private List<DbContext> _context;

        public CursoRepository(List<DbContext> context)
        {
            _context = context;
        }

        public void Add(Curso curso)
        {
            _context.ToList().ForEach(x =>
            {
                x.Set<Curso>().Add(curso);
                x.SaveChanges();
            });
        }

        public IEnumerable<Curso> GetAll()
        {
            //é obrigatório dar o ToList
            return _context[0].Set<Curso>().ToList();
        }
    }
}
