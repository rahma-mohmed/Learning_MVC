using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using System.Linq;
using System.Collections.Generic;

namespace Day1.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Add()
        {
            List<Department> departments = context.Department.ToList();
            ViewData["Depts"] = departments;
            return View();
        }
        [HttpPost]
        public IActionResult SaveAdd(Student std)
        {
            if (ModelState.IsValid == true)
            {
                //save db
                context.Student.Add(std);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Department> departments = context.Department.ToList();
            ViewData["Depts"] = departments;
            return View("Add", std);
        }
        ITIEnitities context = new ITIEnitities();
        public IActionResult Index()
        {
            return View();
        }
        //student/edit/1?age=33 ==Form get or anchor tage
        public IActionResult Edit(int id )
        {
            List<Department> departments = context.Department.ToList();
            ViewData["Depts"] = departments;
            Student std = context.Student.FirstOrDefault(s=>s.ID==id);
            return View(std);//+all DEpt action==>view
        }

        //call db
        //student/edit/1
        //[HttpGet]//link or form method="get
        [HttpPost]//<form method="post">
        public IActionResult SaveEdit([FromRoute]int id,Student newStudent)
        {
            Student std = context.Student.FirstOrDefault(s => s.ID == id);
            std.Name = newStudent.Name;
            std.Age = newStudent.Age;
            std.Address = newStudent.Address;
            std.Image = newStudent.Image;
            std.Dept = newStudent.Dept;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
