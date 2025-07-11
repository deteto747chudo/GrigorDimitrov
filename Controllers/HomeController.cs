using GrigorDimitrov.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GrigorDimitrov.Controllers
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
            var model = new GrigorModel
            {
                Title = "Григор Димитров",
                Description = "Официална фен страница на Григор Димитров.",
                GalleryImages = new List<string>
                {
                    "https://people.com/thmb/v3vqz_OO9gcZZHfZRtXCeXtKZvQ=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc():focal(982x615:984x617)/Grigor-Dimitrov-and-Eiza-Gonzalez-070725-96f7badf05934c46969ad885d15fb71d.jpg",
                    "https://bntnews.bg/f/news/b/1346/1ab460e251808258844e49d4b1a6b2ef.jpeg",
                    "https://image-cdn.essentiallysports.com/wp-content/uploads/grigor-dimitrov-roger-federer.jpg?width=600"
                }
            };

            return View(model);
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
