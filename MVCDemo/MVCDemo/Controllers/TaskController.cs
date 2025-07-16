using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
