using Microsoft.AspNetCore.Mvc;
using OrangeStore.Models;

namespace OrangeStore.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();

            product.Id = 101;
            product.Name = "Mango";
            product.Description = "phone";
            product.Price = 1000;



            return View(product);
        }
    }
}
