using eGameStore.Data;
using eGameStore.Data.Services;
using eGameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Controllers
{
    public class PublishersController : Controller
    {
        private readonly IPublishersService _service;

        public PublishersController(IPublishersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allPublishers= await _service.GetAllAsync();
            return View(allPublishers);
        }
		public IActionResult Create()
		{
			return View();
		}
		// POST: Publishers/Create/
		[HttpPost]
		public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Publisher publisher)
		{
			if (!ModelState.IsValid)
				return View(publisher);

			await _service.AddAsync(publisher);
			return RedirectToAction(nameof(Index));
		}
	}
}
