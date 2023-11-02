using CodeFist_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeFist_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //para que se pueda usar el contexto
        private readonly Contexto contexto;
        public HomeController(Contexto contexto)
        {
            this.contexto = contexto;
        }
        //
        public IActionResult Index()
        {
            return View();
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