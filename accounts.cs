using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class accounts : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
