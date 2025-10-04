using System.Diagnostics;
using lab1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab1.Controllers
{
    public class BlogConroller : Controller
    {
        private readonly ILogger<BlogConroller> _logger;

        public BlogConroller(ILogger<BlogConroller> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new BlogViewModel()
            {
                Title = "My first blog post",
                Description = "This is the description of my first blog post."
            });
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
