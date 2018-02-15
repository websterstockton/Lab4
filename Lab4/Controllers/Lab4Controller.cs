using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab4.Controllers
{
    public class Lab4Controller : Controller
    {
        string[] bevNames = { "Coffee", "Tea", "Coke", "Beer", "Wine", "Whiskey" };
        public Lab4Controller()
        {

        }

        public IActionResult Index()
        {
            DateTime time = DateTime.Now;

            return View(time);
        }

        public IActionResult Page2(int id)
        {
            if (id <= 5)
                return View(id);
            else
                return View();
        }

        public IActionResult Page3()
        {
            ViewData["Title"] = "Beverages";
            return View(bevNames);
        }
    }
}