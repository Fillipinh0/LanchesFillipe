using Microsoft.AspNetCore.Mvc;

namespace LanchesFillipe.Controllers
{
    public class TesteController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Demo()
        {
            return View();
        }
    }
}
