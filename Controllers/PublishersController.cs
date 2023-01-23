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
            var allPublishers = await _service.GetAllAsync();
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

		// Get request
		public async Task<IActionResult> Details(int id)
		{
			var publisherDetails = await _service.GetByIdAsync(id);
			if (publisherDetails == null)
				return View("NotFound");

			return View(publisherDetails);
		}


		// GET: Publishers/Edit/1
		public async Task<IActionResult> Edit(int id)
		{
			var publisherDetails = await _service.GetByIdAsync(id);
			if (publisherDetails == null)
				return View("NotFound");

			return View(publisherDetails);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Publisher publisher)
		{
			if (!ModelState.IsValid)
				return View(publisher);

			await _service.UpdateAsync(id, publisher);
			return RedirectToAction(nameof(Index));
		}

		// GET: Publishers/Delete/1
		public async Task<IActionResult> Delete(int id)
		{
			var publisherDetails = await _service.GetByIdAsync(id);
			if (publisherDetails == null)
				return View("NotFound");

			return View(publisherDetails);
		}

		[HttpPost, ActionName("Delete")]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var publisherDetails = await _service.GetByIdAsync(id);
			if (publisherDetails == null)
				return View("NotFound");

			await _service.DeleteAsync(id);
			return RedirectToAction(nameof(Index));
		}
	}
}
