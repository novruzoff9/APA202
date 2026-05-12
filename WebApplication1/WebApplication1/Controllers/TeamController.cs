using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;


        public TeamController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var members = _context.TeamMembers.ToList();

            return View(members);
        }
    }
}
