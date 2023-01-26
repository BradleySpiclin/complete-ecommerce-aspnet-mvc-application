using eGameStore.Data;
using eGameStore.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGamesService _service;

        public GamesController(IGamesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allGames = await _service.GetAllAsync();
            return View(allGames);
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
