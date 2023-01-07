using eGameStore.Data;
using eGameStore.Data.Base;
using eGameStore.Data.Services;
using eGameStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eGameStore.Controllers
{
    public class DevelopersController : Controller
    {
        private readonly IDevelopersService _service;

        public DevelopersController(IDevelopersService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allDevelopers = await _service.GetAllAsync();
            return View(allDevelopers);
        }

        public IActionResult Create() 
        {
            return View();
        }
        // POST: Developers/Create/
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Developer developer) 
        {
            if(!ModelState.IsValid) 
                return View(developer);
            
            await _service.AddAsync(developer);
            return RedirectToAction(nameof(Index));
        }

        // Get request
        public async Task<IActionResult> Details(int id) 
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if(actorDetails == null) 
                return View("NotFound");
            
            return View(actorDetails);
        }


        // GET: Developers/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null)
                return View("NotFound");
            
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Developer developer)
        {
            if (!ModelState.IsValid)
                return View(developer);
    
            await _service.UpdateAsync(id, developer);
            return RedirectToAction(nameof(Index));
        }

        // GET: Developers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id);
            if (actorDetails == null) 
                return View("NotFound");
    
            return View(actorDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var developerDetails = await _service.GetByIdAsync(id);
            if (developerDetails == null) 
                return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
