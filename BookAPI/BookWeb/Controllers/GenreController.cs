using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
using BookWeb.Enums;
using BookWeb.Interfaces;
using BookWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
    public class GenreController : BaseController
    {
        private IGenre _genre;
        private readonly UserManager<ApplicationUser> _userManager;
        public GenreController(IGenre genre, UserManager<ApplicationUser> userManager)
        {
            _genre = genre;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _genre.GetAll();

            if (model != null)
                return View(model);
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Genre genre)
        {
            genre.CreatedBy = _userManager.GetUserName(User);
            var createGenre = await _genre.AddAsync(genre);

            if (createGenre)
            {
                Alert("Genre created successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Genre not created", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editGenre = await _genre.GetById(id);

            if (editGenre == null)
            {
                return RedirectToAction("Index");
            }
            return View(editGenre);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Genre genre)
        {
            //var editAuthor = await _author.GetById(id);
            var editGenre = await _genre.Update(genre);

            if (editGenre)
            {
                Alert("Genre created successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Genre not created", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteGenre = await _genre.Delete(id);
            if (deleteGenre)
            {
                Alert("Genre deleted successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Genre not deleted", NotificationType.error);
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
