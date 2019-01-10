using LGroup.Curso.Application.Constracts;
using LGroup.Curso.Application.Services;
using LGroup.Curso.Infra.Data.Contexts;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CommonServiceLocator.SimpleInjectorAdapter;
using LGroup.Curso.PadroesArquiteturais.Contracts.UnityOfWork;
using LGroup.Curso.Infra.Data.UnityOfWork;
using LGroup.Curso.PadroesArquiteturais.Contracts.Repositories;
using LGroup.Curso.Infra.Data.Repositories;

namespace LGroup.Curso.Infra.Ioc.ServiceLocator
{
    public static class Bootstrap
    {
        //Pacotes de instalação

        //install-package EntityFramework
        //install-package SimpleInjector
        //install-package CommonServiceLocator.SimpleInjectorAdapter -Version 2.8.1

        public static void Initialize(this Container container, Lifestyle lifeStyle)
        {

            var types = new List<Type>()
            {
                typeof(ContextExterno),
                typeof(ContextInterno)
            };
            
            container.RegisterCollection<DbContext>(types);
            types.ToList().ForEach(x => container.Register(x, x, lifeStyle));

            //Toda vez que eu selecionar a interface: IMatriculaApplicationService
            //em um construtor, a interface IMatriculaApplicationService vai retornar
            //a classe MatriculaApplicationService já instanciada
            //NOTA: Não preciso dar 'new'
            container.Register<IMatriculaApplicationService, MatriculaApplicationService>(lifeStyle);
            container.Register<IUnityOfWork, UnityOfWork>(lifeStyle);

            //Registrando os repositories
            container.Register<IMatriculaRepository, MatriculaRepository>(lifeStyle);
            container.Register<ICursoRepository, CursoRepository>(lifeStyle);
            container.Register<IProfessorRepository, ProfessorRepository>(lifeStyle);
            container.Register<IAlunoRepository, AlunoRepository>(lifeStyle);

            //Estamos pegando o container do ServiceLocator e adicionando
            //o container do SimpleInjector 
            //Agora o container do ServiceLocator esta preenchido!!
            Microsoft.Practices.ServiceLocation.ServiceLocator.SetLocatorProvider(
                () => new SimpleInjectorServiceLocatorAdapter(container));
        }
    }
}
