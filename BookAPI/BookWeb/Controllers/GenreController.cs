﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
using BookWeb.Interfaces;
using BookWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
    public class GenreController : Controller
    {
        private IGenre _genre;
        public GenreController(IGenre genre)
        {
            _genre = genre;
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

            var createGenre = await _genre.AddAsync(genre);

            if (createGenre)
            {
                return RedirectToAction("Index");
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
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteGenre = await _genre.Delete(id);
            if (deleteGenre)
            {
                return RedirectToAction("Index");
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
