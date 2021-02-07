using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();
            for (var i = 1; i < 4; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category" + i.ToString() });
            }
            return View(categories);
        }
        public IActionResult Details(string category) 
        {
            ViewBag.category = category;
            return View();  
        }
        public IActionResult AddCategory() 
        {
            return View();
        }
    } 
}
