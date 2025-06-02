using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab07Session04.Controllers
{
    public class NxvMemberController : Controller
    {
        // GET: NxvMemberController
        public ActionResult NxvIndex()
        {
            return View();
        }

        // GET: NxvMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NxvMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NxvMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxvMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NxvMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: NxvMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NxvMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}