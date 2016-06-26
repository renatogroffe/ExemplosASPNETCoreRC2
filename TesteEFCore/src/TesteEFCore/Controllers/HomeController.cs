using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TesteEFCore.Data;

namespace TesteEFCore.Controllers
{
    public class HomeController : Controller
    {
        private ExemploContext _context;

        public HomeController(ExemploContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {
            return View(
                _context.Capitais.OrderBy(c => c.Estado).ToList());
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}