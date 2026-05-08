using _05._06.Data;
using Microsoft.AspNetCore.Mvc;

namespace _05._06.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext context;

        public HomeController(AppDBContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
