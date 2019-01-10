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
    public class AlunoRepository : IAlunoRepository
    {
        private List<DbContext> _context;

        public AlunoRepository(List<DbContext> context)
        {
            _context = context;
        }
        
        public void Add(Aluno aluno)
        {
            _context.ToList().ForEach(
                x => 
                {
                    x.Set<Aluno>().Add(aluno);
                    x.SaveChanges();
                });

        }

        public IEnumerable<Aluno> GetAll()
        {
            //é obrigatório dar o ToList
            return _context[0].Set<Aluno>().ToList();
        }
    }
}
