using ReceivingParameter.Models;
using Microsoft.AspNetCore.Mvc;

namespace ReceivingParameter.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer(){Id=1,Name="Dung",Address="Ha Noi",Phone="0913444555"},
            new Customer(){Id=2,Name="Hoang",Address="Bac Giang",Phone="0913444555"},
            new Customer(){Id=1,Name="Minh",Address="Nam Dinh",Phone="0913444555"}
        };
        public IActionResult Index()
        {
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }

        //Tiep nhan tham so
        //Cach 1: Su dung Request
        //public IActionResult Save()
        //{
        //    Customer cus = new Customer();
        //    cus.Id = int.Parse(Request.Form["id"].ToString());
        //    cus.Name = Request.Form["name"];
        //    cus.Address = Request.Form["address"];
        //    cus.Phone = Request.Form["phone"];
        //    customers.Add(cus);
        //    return RedirectToAction("Index");
        //}

        //Cach 2: Su dung IFormCollecion
        //public IActionResult Save(IFormCollection form)
        //{
        //    Customer cus = new Customer();
        //    cus.Id = int.Parse(form["id"].ToString());
        //    cus.Name = form["name"];
        //    cus.Address = form["address"];
        //    cus.Phone = form["phone"];
        //    customers.Add(cus);
        //    return RedirectToAction("Index");
        //}

        //Cach 3: Su dung doi so cua action, chi nhan cac tham so trung ten
        //public IActionResult Save(string id, string name, string address, string phone)
        //{
        //    Customer cus = new Customer();
        //    cus.Id = int.Parse(id);
        //    cus.Name = name;
        //    cus.Address = address;
        //    cus.Phone = phone;
        //    customers.Add(cus);
        //    return RedirectToAction("Index");
        //}

        //Cach 4: Su dung Model
        //+, Tao model chua cac thuoc tinh trung ten voi cac tham so
        //+, Su dung lop model de lam doi so cua action
        public IActionResult Save(Customer cus)
        {
            customers.Add(cus);
            return RedirectToAction("Index");
        }
    }
}
