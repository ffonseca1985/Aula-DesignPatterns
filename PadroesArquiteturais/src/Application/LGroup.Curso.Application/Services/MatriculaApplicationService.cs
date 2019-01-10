using System;
using LGroup.Curso.Application.Constracts;
using LGroup.Curso.PadroesArquiteturais.Contracts.UnityOfWork;
using LGroup.Curso.PadroesArquiteturais.DomainModel.Entities;
using LGroup.Curso.PadroesArquiteturais.Contracts.Repositories;

namespace LGroup.Curso.Application.Services
{
    public class MatriculaApplicationService
        : IMatriculaApplicationService
    {
        //Esta classe é reponsável por orquestrar
        //os serviços do domain, repositorio e tarefas externas
        //Logo, é nele que tenho que ter a transação
        private IUnityOfWork _unityOfWork;
        private IAlunoRepository _alunoRepository;
        private IMatriculaRepository _matriculaRepository;

        public MatriculaApplicationService(
            IUnityOfWork unityOfWork,
            IAlunoRepository alunoRepository,
            IMatriculaRepository matriculaRepository)
        {
            _unityOfWork = unityOfWork;
            _alunoRepository = alunoRepository;
            _matriculaRepository = matriculaRepository;
        }

        public void Add(Matricula matricula)
        {
            using (var conection = _unityOfWork.BeginTransaction())
            {
                try
                {
                    _matriculaRepository.Add(matricula);

                    conection.Commit();
                }
                catch
                {
                    conection.Rollback();
                }   
            }   
        }
    }
}
