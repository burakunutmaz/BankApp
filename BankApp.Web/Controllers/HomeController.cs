using Microsoft.AspNetCore.Mvc;
using BankApp.Web.Data.Context;

namespace BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly BankContext _context;

        public HomeController(BankContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }
    }
}
