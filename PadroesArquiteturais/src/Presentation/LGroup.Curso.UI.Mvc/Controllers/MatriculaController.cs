using LGroup.Curso.Application.Constracts;
using System.Web.Mvc;

namespace LGroup.Curso.UI.Mvc.Controllers
{
    public class MatriculaController : Controller
    {
        private IMatriculaApplicationService _matriculaApplicationService;

        public MatriculaController(IMatriculaApplicationService matriculaApplicationService)
        {
            _matriculaApplicationService = matriculaApplicationService;
        }
        // GET: Matricula
        public ActionResult Index()
        {
            _matriculaApplicationService.Add(null);
            return View();
        }
    }
}