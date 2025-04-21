using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return Add();
        }
        public IActionResult Edit()
        {
            return Edit();
        }
    }
}
