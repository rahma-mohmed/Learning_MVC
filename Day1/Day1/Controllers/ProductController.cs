using Microsoft.AspNetCore.Mvc;
using Day1.Models;

namespace Day1.Controllers
{
    public class ProductController : Controller
    {
        /*public string GetInfo()
        {
            return "Hello from new controller";
        }*/

        // File
        // content string
        // view
        // json
        // open page

        /*  public IActionResult GetContent()
          {
              ContentResult result = new ContentResult();
              result.Content = "Hello from Content result";
              return result;
          }

          public ViewResult GetView()
          {
              ViewResult result = new ViewResult();
              result.ViewName = "ShowProduct";
              return result;
          }

          public IActionResult show(int id)
          {
              if (id % 2 == 0) {
                  ViewResult viewResult = new ViewResult();
                  viewResult.ViewName = "ShowProduct";
                  return viewResult;
              }
              else
              {
                  *//*ViewResult result = new ViewResult();
                  result.ViewName = "Details";
                  return result;*//*

                  return Json(new { id = 1 , Name = "Rahma"}) ;
              }
          }*/

        public IActionResult test()
        {
            RedirectResult res = new RedirectResult("https://twitter.com/home");
            return res;
        }

        public IActionResult details(int id)
        {
            Product res = ProductList.Products.FirstOrDefault(x => x.Id == id);
            return View("Details" ,res);
        }

        public IActionResult getall() { 
            List<Product> res = ProductList.Products;
            return View("GetAll" , res);
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
