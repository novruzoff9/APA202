using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
            var members = _context.TeamMembers.Include(x=>x.SocialMedias).ToList();

            return View(members);

        }
    }
}
