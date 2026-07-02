using System.Diagnostics;
using logis.data;
using logis.Models;
using Microsoft.AspNetCore.Mvc;

namespace logis.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Services.ToList();
            return View(data);
        }

        
    }
}
