using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using volksdex.Data;
using volksdex.Models;
using System.Linq;

namespace volksdex.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly VolksdexContext _context;

        public HomeController(ILogger<HomeController> logger, VolksdexContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var carros = _context.Carros.ToList();
            return View(carros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
