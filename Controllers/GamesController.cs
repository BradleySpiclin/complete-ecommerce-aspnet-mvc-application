using eGameStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Controllers
{
    public class GamesController : Controller
    {
        private readonly AppDbContext _context;

        public GamesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allGames = await _context.Games.Include(n => n.Developer).Include(n => n.Publisher).OrderBy(n => n.Name).ToListAsync();
            return View(allGames);
        }
    }
}
