using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RentMovies.Domain.Entities;
using RentMovies.Ifraestructure;
using RentMovies.Web.Models;

namespace RentMovies.Web
{
    public class CategoriesController : Controller
    {
        private readonly DataContext _context;

        public CategoriesController()
        {
        }

       

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Details(int id)
            {
                return View(new CategoryViewModel { Id = id });
            }

            [HttpGet]
            public IActionResult Create()
            {
                return View();
            }


            public async Task<IActionResult> Edit(int id)
            {
                return View(new CategoryViewModel { Id = id });
            }

            public async Task<IActionResult> Delete(int id)
            {
                return View(new CategoryViewModel { Id = id });
            }

        }
    }

