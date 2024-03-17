using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Day3.Controllers
{
    public class DeptController : Controller
    {
        public IActionResult Index()
        {
            List<string> Branches = new List<string>();
            Branches.Add("Mansoura");
            Branches.Add("Monof");
            Branches.Add("Aswan");
            Branches.Add("smart");
            Branches.Add("Assiut");
            ViewData["Branches"] = Branches;
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}
