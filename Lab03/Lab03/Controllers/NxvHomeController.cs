using System.Diagnostics;
using lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers
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
            var products = new List<NxvProduct>
            {
                new NxvProduct { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" },
                new NxvProduct { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" },
                new NxvProduct { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" }
            };
            return View(products);
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
        public IActionResult GetHotProducts()
        {
            // Giả lập dữ liệu (thay bằng truy vấn từ database nếu cần)
            var products = new List<NxvProduct>
        {
            new NxvProduct { Id = 1, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" },
            new NxvProduct { Id = 2, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" },
            new NxvProduct { Id = 3, Name = "Nồi cơm điện cao tần Nagakawa NAG0102", Image = "/product1.jpg" }
        };

            return PartialView("_NxvHotProduct", products);
        }
    }
}
