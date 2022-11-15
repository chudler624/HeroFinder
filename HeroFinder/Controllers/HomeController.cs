using HeroFinder.Models;
using HeroFinder.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HeroFinder.Controllers
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

        public IActionResult HeroPage(string hero)
        {
            var heroApi = new HeroApi();
            var heroModel = heroApi.GetHero(hero);

            return View(heroModel);
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