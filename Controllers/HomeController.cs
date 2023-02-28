using Microsoft.AspNetCore.Mvc;
using MvcControllerServicesApp.Models;
using System.Diagnostics;

namespace MvcControllerServicesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        readonly ITimeService timeService;

        //public HomeController(ILogger<HomeController> logger)
        //{
            
        //}

        public HomeController(ILogger<HomeController> logger, ITimeService timeService)
        {
            this.timeService = timeService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //return View();
            return Content($"{timeService.Time}");
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