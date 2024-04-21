using Day1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day1.Controllers
{
    //Share -controllerNAme
    public class DeptController : Controller
    {
        public IActionResult TestHelper()// List<string> sport , bool football,bool volly ,string gender)
        {
            Department department = new Department();
            department.Name = "SD";
            return View(department);
        }

        ITIEnitities context = new ITIEnitities();
        public IActionResult Add()
        {
            //Model
            Department dept = new Department();
            return View(dept);//model=null
        }
        //test
        [HttpPost]
        public IActionResult SaveAdd(Department newdept)
        {
            if(newdept.Name !=null && newdept.ManagerName!=null)
            {
                //save db
                context.Department.Add(newdept);
                context.SaveChanges();
                //display index view

                return RedirectToAction("Index");//csharp//index action name not viewNAme
            }
            //Add
            return View("Add",newdept);//html
        }


        //DEpt/testBinding ==primitive type &collection
        //degree[0]=100&degree[1]=20
        public IActionResult testBinding(int id,int salary,string name,int[] degree)
        {
            return Content($"OK id={id} \t salary={salary} \t name={name} \n degree[0]={degree[0]} degree[1]={degree[1]}");
        }
        //Dictionary?Phones[Ahmed]=1234&Phones[Ali]=6767
        public IActionResult testBindDic(Dictionary<string,int> Phones,int id)
        {
            return Content("oK");
        }
        
        //Object?id=1&name=ahed&managerName=kdjks
        public IActionResult TestBindObject(Department dept1)
        {
            return Content("Ok");
        }


        int count = 0;
        
        //get all
        public IActionResult Index()
        {
            count++;
            //get al depatment
            List<Department> deptsModel = 
                context.Department.ToList();

            return View("Index",deptsModel);//Model =null
        }
        public IActionResult GetStudents(int id)//dpetid
        {

            List<Student> stdsModel= context.Student.Where(s => s.Dept == id).ToList();
            return View("ShowAllStudent", stdsModel);//connection betwen view with model
            
        }
    }
}
