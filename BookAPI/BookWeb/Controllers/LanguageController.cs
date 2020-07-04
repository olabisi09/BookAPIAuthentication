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
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
    public class LanguageController : BaseController
    {
        private ILanguage _language;
        public LanguageController(ILanguage language)
        {
            _language = language;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _language.GetAll();

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
        public async Task<IActionResult> Create(Language language)
        {

            var createLanguage = await _language.AddAsync(language);

            if (createLanguage)
            {
                Alert("Language created successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Language not created", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editLanguage = await _language.GetById(id);

            if (editLanguage == null)
            {
                return RedirectToAction("Index");
            }
            return View(editLanguage);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Language language)
        {
            var editLanguage = await _language.Update(language);

            if (editLanguage)
            {
                Alert("Language edited successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Language not edited", NotificationType.error);
            }
            return View();
        }
        public async Task<IActionResult> Delete(int id)
        {
            var deleteLanguage = await _language.Delete(id);
            if (deleteLanguage)
            {
                Alert("Language deleted successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Language not deleted", NotificationType.error);
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
