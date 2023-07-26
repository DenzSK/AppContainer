using AppContainer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Drawing;

namespace AppContainer.Controllers
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
            var model = new List<AppContainerModel>();
            model.Add(new AppContainerModel { Image = "/media/ToDoApp.png", AppController = "ToDoList", AppAction = "Index" });
            model.Add(new AppContainerModel { Image = "/media/BMICalculatorApp.png", AppController = "BMI", AppAction = "Index" });
            model.Add(new AppContainerModel { Image = "/media/RandomQuotesApp.png", AppController = "Quotes", AppAction = "Index" });
            model.Add(new AppContainerModel { Image = "/media/WeatherForecastApp.png", AppController = "Weather", AppAction = "Index" });
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}