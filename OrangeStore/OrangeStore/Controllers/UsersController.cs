using Microsoft.AspNetCore.Mvc;

namespace OrangeStore.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
