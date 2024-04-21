using Day3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public IActionResult Testhelper(List<string> sport)
        {
            Department Dept= new Department();
            Dept.Name = "CS";
            return View(Dept);
        }

        public IActionResult testBinding(int id, int salary, string name, int[] degree)
        {
            return Content($"Ok id={id} \t salary={salary} \t name={name} \n degree[0]={degree[0]} degree[1]={degree[1]} degree[2]={degree[2]}");
        }

        public IActionResult testBindingDic(Dictionary<string, int> Phones)
        {
            return Content("OK ");
        }

        public IActionResult testBindingObjec(int id, string name, Department Dept1)
        {
            return Content($"Ok ID:{Dept1.Id}, Name:{Dept1.Name}, Department Manger:{Dept1.Manager}");
        }

        //Form,Root,QueryString,File provider

        public IActionResult Add()
        {
            Department dept = new Department();
            return View(dept);
        }

        ITIEntities2 context = new ITIEntities2();

        public IActionResult SaveAdd(Department newdept)
        {
            if (newdept.Name != null && newdept.Manager != null)
            {
                context.Departments.Add(newdept);
                context.SaveChanges();
                return RedirectToAction("ShowDeptDetails");
            }
            return View("Add" , newdept); 
        }

        public IActionResult Remove([FromRoute]int id)
        {
            var departmentToRemove = context.Departments.Find(id);
            if (departmentToRemove != null)
            {
                context.Departments.Remove(departmentToRemove);
                context.SaveChanges();
                return RedirectToAction("ShowDeptDetails");
            }
            return NotFound();
        }


        public IActionResult ShowDeptDetails()
        {
            List<Department> deptsModel = context.Departments.ToList();
            return View("ShowDeptDetails" , deptsModel);
        }

    }
}
