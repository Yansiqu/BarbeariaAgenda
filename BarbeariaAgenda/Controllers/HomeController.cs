using Microsoft.AspNetCore.Mvc;

namespace BarbeariaAgenda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
