using LGroup.Curso.PadroesArquiteturais.Contracts.UnityOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

//Este namespace contém um serviceLocator global e classes de melhores práticas
//da microsoft
//install-package commonServiceLocator
using Microsoft.Practices.ServiceLocation;

namespace LGroup.Curso.Infra.Data.UnityOfWork
{
    public class UnityOfWork : IUnityOfWork
    {
        private IEnumerable<DbContext> _contexts;
        private IEnumerable<DbContextTransaction> _transactions;
        public UnityOfWork()
        {
            _transactions = new List<DbContextTransaction>();
            //install-package commonServiceLocator
            //Agora estamos pegando todas as instancias de DbContext
            //que são ContextInterno e ContextExterno
            _contexts = ServiceLocator.Current.GetAllInstances<DbContext>();
        }

        public IUnityOfWork BeginTransaction()
        {
            //Estou pegando os contextos de cada banco de dados, abrindo a conexão
            //E inserindo na lista de transaction
            _contexts.ToList()
                .ForEach(x => _transactions.ToList().Add(x.Database.BeginTransaction()));

            return this;
        }

        public void Commit()
        {
            _transactions.ToList().ForEach(x => x.Commit());
        }

        public void Dispose()
        {
            _transactions.ToList().ForEach(x => x.Dispose());
        }

        public void Rollback()
        {
            _transactions.ToList().ForEach(x => x.Rollback());
        }
    }
}
