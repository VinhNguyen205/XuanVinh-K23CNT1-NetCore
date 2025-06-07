using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NxvLesson07.Models;

namespace NxvLesson07.Controllers
{
    public class NxvHomeController : Controller
    {
        private readonly ILogger<NxvHomeController> _logger;

        public NxvHomeController(ILogger<NxvHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NxvIndex()
        {
            return View();
        }

        public IActionResult NxvAbout()
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
