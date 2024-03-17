using Day3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using Day3.ViewModel;

namespace Day3.Controllers
{
    public class PassDataController : Controller
    {
        ITIEntities2 context = new ITIEntities2();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowStudent(int id)
        {
            //List<Instructor> ins = context.Instructors.Include(x => x.Dept_id).ToList();

            Instructor ins = 
                context.Instructors.Include(x => x.Department).FirstOrDefault(s => s.Id == id);

            StudentNameWithDeptNameViewModel stdM = new StudentNameWithDeptNameViewModel();

            // take copy from model and set in view model
            stdM.StudentName = ins.Name;
            stdM.DeptName = ins.Department.Name;
            stdM.ID = ins.Id;

            if(stdM.DeptName == "CS")
            {
                stdM.Color = "green";
            }
            else
            {
                stdM.Color = "blue";
            }

            return View(stdM);
        }
    }
}
