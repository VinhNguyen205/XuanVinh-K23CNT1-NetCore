using System.Diagnostics;
using NxvLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace NxvLab06.Controllers
{
    public class NxvHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult NxvCreate()
        {
            return View();
        }
        public IActionResult StudentInfo()
        {
            ViewBag.Name = "Nguyễn Xuân Vinh";
            ViewBag.MSSV = "2310900117";
            ViewBag.Email = "realsteelworld2k5@gmail.com";
            return View();
        }
        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
