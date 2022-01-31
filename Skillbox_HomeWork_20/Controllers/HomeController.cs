using Microsoft.AspNetCore.Mvc;
using Skillbox_HomeWork_20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skillbox_HomeWork_20.Controllers
{
    public class HomeController : Controller
    {
        PhoneBook db;

        public HomeController(PhoneBook context)
        {
            db = context;
        }

        public IActionResult Index()
        {
            return View(db.People.ToList());
        }

        [HttpGet]
        public IActionResult Contact(int? id)
        {
            if (id == null) return RedirectToAction("Index");

            ViewBag.SelectPerson = (Person) db.People.Find(id);
            return View();
        }
    }
}
