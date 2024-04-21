using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using Day1.ViewModel;
using System.Linq;
using System.Collections.Generic;
using System;
using Microsoft.EntityFrameworkCore;

namespace Day1.Controllers
{
    public class PassDataController : Controller
    {
        ITIEnitities context = new ITIEnitities();
        public IActionResult Index()
        {
           
            //extra info with model 
            List<string> Branches = new List<string>();
            Branches.Add("Smart");
            Branches.Add("Alex");
            Branches.Add("Mansoura");
            Branches.Add("Assiut");
            Branches.Add("Menof");
            //Magic string =>runtime
            //typecasting value==>object  =>view
            ViewData["branchList"] = Branches;
            ViewData["msg"] = "Hello From Controller";

            //magicstring
            ViewBag.date = DateTime.Now.ToString();

            List<Department> deptsModel= context.Department.ToList();
            #region view overload
            //name view not the same name of action &model null
            //return View("showAll");
            //name view not the same name of action &with model
            //return View("showAll", deptsModel);
            //view name the same name of action & model null
            //return View();        //view:index &model null
            #endregion
            //view name the same name of action & with model 
            return View("index",deptsModel);   //view index & model=deptsModel

        }

        public IActionResult ShowStudentDEtails(int id)
        {
            Student stdModel=
                context.Student.Include(s=>s.Department).FirstOrDefault(s=>s.ID==id);

            //viewModel mapping 
            StudentNAmeWithDepartmentNAmeViewModel stdVM = 
                new StudentNAmeWithDepartmentNAmeViewModel();
            //take copy from Model set in ViewModel
            stdVM.StudentName = stdModel.Name;
            stdVM.DeptName = stdModel.Department.Name;
            stdVM.Id = stdModel.ID;
            if (stdVM.DeptName == "SD")
                stdVM.Color = "green";
            else
                stdVM.Color = "red";

            return View(stdVM); //StudentNAmeWithDepartmentNAmeViewModel
        }
    }
}
