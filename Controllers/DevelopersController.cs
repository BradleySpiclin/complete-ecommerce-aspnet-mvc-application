﻿using eGameStore.Data;
using eGameStore.Data.Services;
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
            var allDevelopers = await _service.GetAll();
            return View(allDevelopers);
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}
