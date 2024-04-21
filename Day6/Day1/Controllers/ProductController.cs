using Microsoft.AspNetCore.Mvc;
using Day1.Models;
using System.Linq;
using System.Collections.Generic;

namespace Day1.Controllers
{
    //scaffolding 
    public class ProductController : Controller
    {
        //product/details/1
        public IActionResult Details(int id)
        {
            
            //Model
           Product proModel=
                ProductList.Products.FirstOrDefault(p => p.ID == id);
            //send to view
            return View("Details", proModel);
        }

        public IActionResult getAll()
        {
            //Model
            List<Product> proModel = ProductList.Products.ToList();
            //send to view
            return View("getAll", proModel);
        }




        //Product/getInfo
        public string getInfo()//action
        {
            return "Hello From First MVC Action";
        } 
    
        //product/getcontent
        public IActionResult getContent()
        {
            ContentResult result = new ContentResult();
            result.Content = "hello from second action";
            return result;
        }


        //return view
        public IActionResult getview()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "ShowPRoduct";
            return result; 
            //sarch where
                //views/product
                //views/shared
        }
        public IActionResult show(int id)
        {
            if (id % 2==0)
            {
                return Content("sorry");
            }else
            {
              //  return Json(new { name = "adsasf", age = 30 });
                return View("ShowPRoduct");
            }
        }
    }
}
