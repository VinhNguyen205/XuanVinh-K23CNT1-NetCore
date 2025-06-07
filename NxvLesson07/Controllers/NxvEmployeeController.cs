using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NxvLesson07.Models;

namespace NxvLesson07.Controllers
{
    public class NxvEmployeeController : Controller
    {
        // Mock Data:
        private static List<NxvEmployee> nxvListEmployee = new List<NxvEmployee>()
        {
              new NxvEmployee
            {
                NxvId = 117,
                NxvName = "Nguyễn Xuân Vinh",
                NxvBirthDay = new DateTime(2005, 6, 30),
                NxvEmail = "realsteelworld2k5@gmail.com",
                NxvPhone = "0357335092",
                NxvSalary = 12000000,
                NxvStatus = true
            },
            new NxvEmployee
            {
                NxvId = 2,
                NxvName = "Trần Thị B",
                NxvBirthDay = new DateTime(1992, 5, 20),
                NxvEmail = "b.tran@example.com",
                NxvPhone = "0987654321",
                NxvSalary = 10000000,
                NxvStatus = false
            },
            new NxvEmployee
            {
                NxvId = 3,
                NxvName = "Lê Văn C",
                NxvBirthDay = new DateTime(1985, 8, 10),
                NxvEmail = "c.le@example.com",
                NxvPhone = "0933123456",
                NxvSalary = 15000000,
                NxvStatus = true
            },
            new NxvEmployee
            {
                NxvId = 4,
                NxvName = "Phạm Thị D",
                NxvBirthDay = new DateTime(1998, 3, 25),
                NxvEmail = "d.pham@example.com",
                NxvPhone = "0909090909",
                NxvSalary = 9500000,
                NxvStatus = true
            },
            new NxvEmployee
            {
                NxvId = 5,
                NxvName = "Đỗ Mạnh E",
                NxvBirthDay = new DateTime(1995, 11, 5),
                NxvEmail = "e.do@example.com",
                NxvPhone = "0944556677",
                NxvSalary = 11000000,
                NxvStatus = false
            }
        };
        // GET: NxvEmployeeController
        public ActionResult NxvIndex()
        {
            return View(nxvListEmployee);
        }

        // GET: NxvEmployeeController/NxvDetails/5
        public ActionResult NxvDetails(int id)
        {
            var nxvEmployee = nxvListEmployee.FirstOrDefault(x => x.NxvId == id);
            return View(nxvEmployee);
        }

        // GET: NxvEmployeeController/NxvCreate
        public ActionResult NxvCreate()
        {
            var nxvEmployee = new NxvEmployee();
            return View(nxvEmployee);
        }

        // POST: NxvEmployeeController/NxvCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NxvCreate(NxvEmployee nxvModel)
        {
            try
            {
                // Thêm mới nhân viên vào list
                nxvModel.NxvId = nxvListEmployee.Max(x=>x.NxvId) + 1;
                nxvListEmployee.Add(nxvModel);
                return RedirectToAction(nameof(NxvIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxvEmployeeController/NxvEdit/5
        public ActionResult NxvEdit(int id)
        {
            var nxvEmployee = nxvListEmployee.FirstOrDefault(x=>x.NxvId==id);
            return View(nxvEmployee);
        }

        // POST: NxvEmployeeController/NxvEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NxvEdit(int id, NxvEmployee nxvModel)
        {
            try
            {
                for (int i = 0; i < nxvListEmployee.Count(); i++)     
                    {
                    if (nxvListEmployee[i].NxvId == id)
                    {
                        nxvListEmployee[i] = nxvModel;
                        break;
                    }
                }
                return RedirectToAction(nameof(NxvIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxvEmployeeController/NxvDelete/5
        public ActionResult NxvDelete(int id)
        {
            var nxvEmployee = nxvListEmployee.FirstOrDefault(x => x.NxvId == id);
            if (nxvEmployee == null)
            {
                return View(nxvEmployee); // Trả về 404 nếu không tìm thấy
            }
            return View(nxvEmployee);
        }

        // POST: NxvEmployeeController/NxvDelete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NxvDelete(int id, NxvEmployee nxvModel)
        {
            try
            {
                var nxvEmployee = nxvListEmployee.FirstOrDefault(x => x.NxvId == id);
                if (nxvEmployee != null)
                {
                    nxvListEmployee.Remove(nxvEmployee); // Xoá khỏi danh sách
                }
                return RedirectToAction(nameof(NxvIndex)); // Quay lại danh sách
            }
            catch
            {
                return View(nxvModel); // Trả lại view nếu có lỗi
            }
        }
    }
}
