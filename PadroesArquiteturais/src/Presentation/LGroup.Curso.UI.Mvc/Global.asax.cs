using LGroup.Curso.UI.Mvc.App_Start;
using System.Web.Mvc;
using System.Web.Routing;

namespace LGroup.Curso.UI.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ServiceLocatorConfig.Initialize();
        }
    }
}
