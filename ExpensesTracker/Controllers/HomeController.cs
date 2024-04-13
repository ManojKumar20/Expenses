using Microsoft.AspNetCore.Mvc;

namespace ExpensesTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
