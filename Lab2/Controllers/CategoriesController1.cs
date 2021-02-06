using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Browse(string category) 
        {
            ViewBag.category = category;
            return View();  
        }
    }
}
