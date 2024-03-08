using Microsoft.AspNetCore.Mvc;
using S2_mvc.Models;
using System.Diagnostics;

namespace S2_mvc.Controllers
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
            ProductViewModel productViewModel = new();
            productViewModel.Name = "";
            productViewModel.Description = "";

            return View(productViewModel);
        }

        [HttpPost]
        public IActionResult Index(ProductViewModel viewModel)
        {
            return View(viewModel);
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
