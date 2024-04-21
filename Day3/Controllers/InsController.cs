using Day3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day3.Controllers
{
    public class InsController : Controller
    {
        public IActionResult Index2()
        {
            return View();
        }


        ITIEntities2 context = new ITIEntities2();

        public IActionResult Edit(int id) {
            Instructor instructor = context.Instructors.FirstOrDefault(x => x.Id == id);
            List<Department> Dept = context.Departments.ToList();
            ViewData["Depts"] = Dept;
            return View(instructor);
        }

        [HttpPost]
        public IActionResult SaveEdit([FromRoute]int Id , Instructor ins)
        {
            Instructor inst = context.Instructors.FirstOrDefault(x => x.Id == Id);
            inst.Id = ins.Id;
            inst.Name = ins.Name;
            ins.Image = ins.Image;
            ins.Address = ins.Address;
            inst.Salary = ins.Salary;
            context.SaveChanges();
            return RedirectToAction("Index2");
        }
    }
}
