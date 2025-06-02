using Microsoft.AspNetCore.Mvc;
using Lab07Session04.Models;

namespace Lab07Session04.Controllers
{
    public class NxvEmployeeController : Controller
    {
        private static List<NxvEmployee> NxvListEmployees = new List<NxvEmployee>
        {
            new NxvEmployee { NxvId = 230001122, NxvName = "Chung Trịnh", NxvBirthDay = new DateTime(1979, 5, 25), NxvEmail = "chungtrinhj@gmail.com", NxvPhone = "0978611889", NxvSalary = 12000000, NxvStatus = true },
            new NxvEmployee { NxvId = 2, NxvName = "Trần Thị B", NxvBirthDay = new DateTime(1992, 5, 15), NxvEmail = "b@example.com", NxvPhone = "0912233445", NxvSalary = 15000000, NxvStatus = true },
            new NxvEmployee { NxvId = 3, NxvName = "Lê Văn C", NxvBirthDay = new DateTime(1988, 9, 20), NxvEmail = "c@example.com", NxvPhone = "0922123456", NxvSalary = 11000000, NxvStatus = false },
            new NxvEmployee { NxvId = 4, NxvName = "Phạm Thị D", NxvBirthDay = new DateTime(1995, 3, 10), NxvEmail = "d@example.com", NxvPhone = "0933445566", NxvSalary = 13000000, NxvStatus = true },
            new NxvEmployee { NxvId = 5, NxvName = "Đỗ Văn E", NxvBirthDay = new DateTime(1991, 7, 25), NxvEmail = "e@example.com", NxvPhone = "0944567890", NxvSalary = 10000000, NxvStatus = false }
        };
        public IActionResult NxvIndex()
        {
            return View(NxvListEmployees);
        }

        // GET: /NxvEmployee/NxvCreate
        public IActionResult NxvCreate()
        {
            var model = new NxvEmployee();
            return View(model);
        }

        // POST: /NxvEmployee/NxvCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NxvCreate(NxvEmployee model)
        {
            try
            {
                // Tự động sinh mã nếu cần
                if (model.NxvId == 0)
                {
                    model.NxvId = NxvListEmployees.Max(e => e.NxvId) + 1;
                }
                NxvListEmployees.Add(model);
                return RedirectToAction(nameof(NxvIndex));
            }
            catch
            {
                return View();
            }
        }


        //  GET: /NxvEmployee/NxvEdit/id?
        public IActionResult NxvEdit(int id)
        {
            var model = NxvListEmployees.FirstOrDefault(x => x.NxvId == id);
            return View(model);
        }

    }
}