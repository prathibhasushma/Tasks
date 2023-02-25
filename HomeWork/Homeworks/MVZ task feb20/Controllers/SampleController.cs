using Microsoft.AspNetCore.Mvc;
using MVZ_task_feb20.Models;
using System.Reflection.Metadata.Ecma335;

namespace MVZ_task_feb20.Controllers
{
    public class SampleController : Controller
    {
        //public string hello(string name)
        //{
        //     return "Happy valentine's Day"+" " + name;
        //}

        //public string hello(string fname,string lname)
        //{
        //    return "Happy valentine's Day" + " " + fname + " " +lname;
        //}

        public IActionResult Index(string name, int no)
        {
            ViewData["name"] = name;
            ViewData["no"] = no;
            return View();
        }

        public IActionResult GetCustomer()
        {
            Customer cust = new Customer()
            {
                customername = "Prathibha sushma",
                customerid = 101,
                city = "chennai",
                Contactno = "6383962275",
                gender = "Female"
            };
            return View(cust);


        }

        public IActionResult NewCustomer()
        {
            return View();
        }


        public IActionResult SubmitCustomer(Customer customer)
        {
            return View("CustomerDisplay", customer);
        }
    }
}
