using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Day1.Controllers
{
    public class StateController : Controller
    {
        //1:15
        public IActionResult setCookie()//Login
        {
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(1);

            Response.Cookies.Append("username", "christen", cookieOptions);//persisste cookie
            Response.Cookies.Append("color", "yellow");//session cookie
            return Content("Cookie saves");
        }
        public IActionResult getCookie()
        {
            string name=Request.Cookies["username"].ToString();
            string color = Request.Cookies["color"].ToString();
            return Content($"get data from cookie {name} ,{color}");

        }

        public IActionResult setState()
        {
            //state save 
            string name = "ITI";
            int age = 23;
            HttpContext.Session.SetString("stdName", name);//
            HttpContext.Session.SetInt32("stdAge", age);
            return  Content("Save");
        }

        public IActionResult getState()
        {
            string n = HttpContext.Session.GetString("stdName");
            int? a = HttpContext.Session.GetInt32("stdAge");//.Value;
            return Content($"get success {n} , {a}");
        }
       public IActionResult set()
        {
            //set data TempData
            TempData["NAme"] = "ITI";
            return Content("Data Saved");
        }
        public IActionResult get1()
        
        {
            //get data TempData
            string name = "empty";
            if (TempData.ContainsKey("NAme"))
            {
               name= TempData["NAme"].ToString();
               TempData.Keep("NAme");
            }
            return Content($"get1 call and tempdata = {name}");
        }
        public IActionResult get2()
        {
            //get data TempData
            string name = "empty";
            
            if (TempData.ContainsKey("NAme"))
            {
                name = TempData.Peek("NAme").ToString();
            }
            return Content($"get2 call and tempdata = {name}");
        }
    }
}
