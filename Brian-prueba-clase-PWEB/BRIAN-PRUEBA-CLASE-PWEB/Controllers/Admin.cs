using Microsoft.AspNetCore.Mvc;

namespace BRIAN_PRUEBA_CLASE_PWEB.Controllers
{
    public class Admin : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
