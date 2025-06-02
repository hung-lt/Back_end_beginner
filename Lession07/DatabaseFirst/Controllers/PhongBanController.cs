using DatabaseFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace DatabaseFirst.Controllers
{
    public class PhongBanController : Controller
    {
        private readonly QLNhanSuContext _context;
        public PhongBanController()
        {
            _context = new QLNhanSuContext();
        }
        public IActionResult Index()
        {
            var phongBans = _context.PhongBans.ToList();
            return View(phongBans);
        }
        public IActionResult Create(PhongBan phongBan)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.PhongBans.Add(phongBan);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("",ex.Message);
            }
            return View(phongBan);
        }
        public IActionResult Delete(string id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var phongBan = _context.PhongBans.Find(id);
            _context.PhongBans.Remove(phongBan);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
