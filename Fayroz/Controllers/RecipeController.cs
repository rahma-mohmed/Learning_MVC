using Microsoft.AspNetCore.Mvc;
using Fayroz.Models;

namespace Fayroz.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetRecipeCard([FromBody] List<Recipe> recipes)
        {
            return PartialView("_RecipeCard", recipes);
        }
    }
}