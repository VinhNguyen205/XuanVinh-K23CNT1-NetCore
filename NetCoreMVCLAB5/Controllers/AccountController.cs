using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLABS.Models;

namespace NetCoreMVCLAB5.Controllers
{
    public class AccountController : Controller
    {
        // Lưu danh sách account tạm thời trong RAM
        private static List<Account> _accounts = new List<Account>();

        // GET: Account
        public ActionResult Index()
        {
            return View(_accounts); // Trả danh sách hiện tại
        }

        // GET: Account/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        [HttpPost]
        public IActionResult Create(Account account)
        {
            if (ModelState.IsValid)
            {
                // Gán ID tự động nếu cần
                account.Id = _accounts.Count > 0 ? _accounts.Max(a => a.Id) + 1 : 1;
                _accounts.Add(account); // Lưu vào danh sách tạm

                return RedirectToAction("Index");
            }

            return View(account);
        }

        // GET: Account/Details/5
        public ActionResult Details(int id)
        {
            var acc = _accounts.FirstOrDefault(a => a.Id == id);
            if (acc == null) return NotFound();
            return View(acc);
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            var acc = _accounts.FirstOrDefault(a => a.Id == id);
            if (acc == null) return NotFound();
            return View(acc);
        }

        // POST: Account/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Account updated)
        {
            var acc = _accounts.FirstOrDefault(a => a.Id == id);
            if (acc == null) return NotFound();

            acc.FullName = updated.FullName;
            acc.Email = updated.Email;
            acc.Phone = updated.Phone;
            acc.Address = updated.Address;
            acc.Avatar = updated.Avatar;
            acc.Birthday = updated.Birthday;
            acc.Password = updated.Password;
            acc.Facebook = updated.Facebook;

            return RedirectToAction(nameof(Index));
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyPhone(string phone)
        {
            Regex _isPhone = new Regex(@"^(\(?[0-9]{3}\)?)[-.\s]?[0-9]{3}[-.\s]?[0-9]{4}$");
            if (!_isPhone.IsMatch(phone))
            {
                return Json($"Số điện thoại {phone} không đúng định dạng, VĐ: 0986421127, hotline: 098.421.1327");
            }
            return Json(true);
        }

        // GET: Account/Delete/5
        public ActionResult Delete(int id)
        {
            var acc = _accounts.FirstOrDefault(a => a.Id == id);
            if (acc == null) return NotFound();
            return View(acc);
        }

        // POST: Account/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var acc = _accounts.FirstOrDefault(a => a.Id == id);
            if (acc != null) _accounts.Remove(acc);
            return RedirectToAction(nameof(Index));
        }
    }
}

