using System;

namespace LGroup.Curso.PadroesArquiteturais.Contracts.UnityOfWork
{
    public interface IUnityOfWork : IDisposable
    {
        //Duas Formas
        //1 - Transacionando apenas o objeto
        //2 - Transacionando o objeto e o banco
        IUnityOfWork BeginTransaction();
        void Commit();
        void Rollback();

    }
}
