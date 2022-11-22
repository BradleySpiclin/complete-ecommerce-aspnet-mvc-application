using eGameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly AppDbContext _context;


        public DevelopersController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allDevelopers = await _context.Developer.ToListAsync();
            return View(allDevelopers);
        }
    }
}
