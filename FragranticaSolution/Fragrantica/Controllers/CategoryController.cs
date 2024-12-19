using Microsoft.AspNetCore.Mvc;

namespace Fragrantica.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
