using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class DeptController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /*public IActionResult Index()
        {
            ITIEntities context = new ITIEntities();
            List<Department> depts = context.Departments.ToList();
            return View("All", depts);
        }*/
    }
}
