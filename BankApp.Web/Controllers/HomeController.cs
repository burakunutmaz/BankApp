using Microsoft.AspNetCore.Mvc;

namespace BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
