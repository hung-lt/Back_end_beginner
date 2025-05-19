using System.Diagnostics;
using HocDataTransfer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HocDataTransfer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        static List<Customer> customers = new List<Customer>()
        {
            new Customer() {Id = 1, Name = "Đinh Hoài Nam", Phone = "0549095949" },
            new Customer() {Id = 2, Name = "Đinh Nam", Phone = "0549095949" },
        };

        public IActionResult Index()
        {
            //Các cách truyền dữ liệu từ controller sang view
            //1. sử dụng ViewBag
            ViewBag.message1 = "ViewBag là một đối tượng dynamic dùng để " +
                "truyền dữ liệu từ Controller sang View trong cùng 1 requuest";

            //2. Sử dụng ViewData
            ViewData["message2"] = "ViewData là một kiểu từ điển, dùng để " +
                "truyền dữ liệu từ controller sang view cùng 1 request. " + 
                "Ở bên View phải thực hiện ép kiểu tường minh";
            List<string> name = new List<string>()
            {
                "Dũng", "Bình", "Hoàng"
            };
            ViewData["name"] = name;

            //3. Sử dụng TempData
            TempData["message3"] = "TempData là một dictionary dùng để" + 
                "truyền tải dữ liệu từ Controller sang view dữ liệu vẫn còn" + 
                "tồn tại khi chuyển hướng sang 1 request tiếp theo";
            return View(customers);
            //return RedirectToAction("GetData");
            //4.Sử dụng model
            // - bên controller:return View(model)
            //- Bên View: 
            // - @model:  Khai báo model class
            // - @Model: Khai báo đối tượng 
        }

        public IActionResult GetData()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        { 
            return View(); 
        }
        [HttpPost]
        //dùng Session để lưu trữ từ trang này sang trang khác
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "12345")
            {
                HttpContext.Session.SetString("fullname", "Đinh Hoài Nam");
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
