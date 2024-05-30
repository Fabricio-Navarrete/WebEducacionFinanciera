using Microsoft.AspNetCore.Mvc;

namespace ProyectoEducacionFinanciera.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
