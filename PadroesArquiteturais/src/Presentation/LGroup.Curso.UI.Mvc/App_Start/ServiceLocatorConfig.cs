using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//PAra inicializar os containers precisamos da seguinte referência
using LGroup.Curso.Infra.Ioc.ServiceLocator;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using System.Web.Mvc;
using SimpleInjector.Integration.Web.Mvc;

namespace LGroup.Curso.UI.Mvc.App_Start
{
    public class ServiceLocatorConfig
    {
        //Para que o Mvc se adpate aos container do Simpleinjector
        //e para que possamos passar o lifestyle compativel com
        //o MVC, precisamos instalar o seguinte item:
        //install-package simpleInjector.integration.web.mvc

        public static void Initialize()
        {
            var container = new Container();

            container.Options.DefaultLifestyle = new WebRequestLifestyle();

            //Registrando as controllers do mvc
            container.RegisterMvcControllers();

            //Note: Quem define o lifestyle é a UI
            container.Initialize(new WebRequestLifestyle());

            //Não Obrigatório
            //=> Vai em cada construtor, verifica se tem uma interface injetada
            //=> Se tiver ele verifica se tem no container, se tiver ok, caso contrário
            //=> um erro ocorrerá
            container.Verify();

            //Esta resolvendo os construtores das controlers(Dando o new nas interfaces)
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}