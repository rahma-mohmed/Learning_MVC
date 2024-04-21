using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskIT.Models;
using TaskIT.Services;

namespace TaskIT.Controllers
{
    public class HomeController : Controller
    {
        BookRepository BookServices = new BookRepository();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<Book> books = BookServices.getAll();
            return View(books);
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
