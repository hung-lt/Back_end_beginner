using Microsoft.AspNetCore.Mvc;
using LuuTheHung.Models;

namespace LuuTheHung.Controllers
{
    public class BaiVietController : Controller
    {
        static List<BaiViet> baiViets = new List<BaiViet>()
        {
            new BaiViet(){MaBaiViet = 1,TieuDe="Bai viet 1",NoiDung="Noi dung 1",NgayDang = "10/01/2025"},
            new BaiViet(){MaBaiViet = 2,TieuDe="Bai viet 2",NoiDung="Noi dung 2",NgayDang = "11/05/2025"}
        };


        public IActionResult Index()
        {
            return View(baiViets);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BaiViet bai)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    baiViets.Add(bai);
                    return RedirectToAction("Index");
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, ex.Message);
            }
            return View(bai);
        }
        

    }
}
