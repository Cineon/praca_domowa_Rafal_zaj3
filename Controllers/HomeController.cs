

using Microsoft.AspNetCore.Mvc;
using praca_domowa_Rafal_zaj3.Models;
using praca_domowa_Rafal_zaj3.ModelViews;
using System.Diagnostics;


namespace praca_domowa_Rafal_zaj3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contact()
        {
            var user = new User
            {
                FirstName = "Adam",
                LastName = "Nowak",
                Address = "ul. jeleniogórska 3, 80-180 Gdańsk",
                Email = "adam.nowak@gmail.com"
            };

            return View(user);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}