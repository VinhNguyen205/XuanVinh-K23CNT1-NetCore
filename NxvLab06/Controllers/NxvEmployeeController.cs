using Microsoft.AspNetCore.Mvc;
using NxvLab06.Models;

namespace NxvLab06.Controllers
{
    public class NxvEmployeeController : Controller
    {
        public static List<NxvEmployee> NxvListEmployee = new List<NxvEmployee>
        {
            new NxvEmployee { NxvId = 1, NxvName = "Nguyễn Xuân Vinh", NxvBirthDay = new DateTime(2000, 1, 1), NxvEmail = "realsteelworld2k5@gmail.com", NxvPhone = "0357335092", NxvSalary = 1000, NxvStatus = true },
            new NxvEmployee { NxvId = 2, NxvName = "Trần Thị B", NxvBirthDay = new DateTime(1995, 5, 10), NxvEmail = "b@example.com", NxvPhone = "0987654321", NxvSalary = 2000, NxvStatus = false },
            new NxvEmployee { NxvId = 3, NxvName = "Lê Văn C", NxvBirthDay = new DateTime(1990, 3, 15), NxvEmail = "c@example.com", NxvPhone = "0369852147", NxvSalary = 3000, NxvStatus = true },
            new NxvEmployee { NxvId = 4, NxvName = "Phạm Văn D", NxvBirthDay = new DateTime(1988, 11, 20), NxvEmail = "d@example.com", NxvPhone = "0398547210", NxvSalary = 1500, NxvStatus = false },
            new NxvEmployee { NxvId = 5, NxvName = "Đỗ Thị E", NxvBirthDay = new DateTime(1992, 6, 5), NxvEmail = "e@example.com", NxvPhone = "0387621985", NxvSalary = 2500, NxvStatus = true }
        };

        public IActionResult NxvIndex()
        {
            return View(NxvListEmployee);
        }

        [HttpGet]
        public IActionResult NxvCreate()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult NxvCreateSubmit(NxvEmployee emp)
        {
            // TODO: Khai báo danh sách tạm thời hoặc lưu trữ phù hợp
            // Ví dụ: lưu vào danh sách tĩnh (bạn tự thêm danh sách này)
            NxvListEmployee.Add(emp);

            return RedirectToAction("NxvIndex");
        }
    }
}