using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Xml.Linq;

namespace Day3.Controllers
{
    public class StateController : Controller
    {
        public IActionResult get1()
        {
            TempData["Name"] = "Rahma";
            return Content("Data Saved");
        }

        public IActionResult get2()
        {
            string name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                //name = TempData["Name"].ToString();
                //TempData.Keep("Name");

                name = TempData.Peek("Name").ToString();
            }
            
            return Content($"get call and tempdata = {name}");
        }

        public IActionResult get3()
        {
            string name = "empty";
            if (TempData.ContainsKey("Name"))
            {
                name = TempData["Name"].ToString();
            }

            return Content($"get call and tempdata = {name}");
        }

        public IActionResult SetSession()
        {
            string name = "Rahma";
            int age = 21;
            HttpContext.Session.SetString("stdName", name);
            HttpContext.Session.SetInt32("stdAge",age);
            return Content("Data Saved");
        }

        public IActionResult GetSession()
        {
            string nam = HttpContext.Session.GetString("stdName");
            int? ag = HttpContext.Session.GetInt32("stdAge");
            return Content($"Get success {nam} , {ag}");
        }

        public IActionResult SetCoolkie()
        {
            // session cookie
            Response.Cookies.Append("userName", "Rahma");
            //persistent cookie
            CookieOptions cookieOptions = new CookieOptions();
            cookieOptions.Expires = DateTimeOffset.Now.AddDays(1);
            Response.Cookies.Append("age", "20" , cookieOptions);
            return Content("Data Saves");
        }

        public IActionResult GetCookie()
        {
            string name = Request.Cookies["userName"].ToString();
            string age = Request.Cookies["age"].ToString();
            return Content($"Get Data from cookie {name} , {age}");

        }
    }
}
