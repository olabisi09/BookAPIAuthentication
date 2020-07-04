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
    public class CategoryController : BaseController
    {
        private ICategory _category;
        private readonly UserManager<ApplicationUser> _userManager;
        public CategoryController(ICategory category, UserManager<ApplicationUser> userManager)
        {
            _category = category;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _category.GetAll();

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
        public async Task<IActionResult> Create(Category category)
        {
            category.CreatedBy = _userManager.GetUserName(User);
            var createCategory = await _category.AddAsync(category);

            if (createCategory)
            {
                Alert("Category created successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Category not created", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editCategory = await _category.GetById(id);

            if (editCategory == null)
            {
                return RedirectToAction("Index");
            }
            return View(editCategory);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Category category)
        {
            //var editAuthor = await _author.GetById(id);
            var editCategory = await _category.Update(category);

            if (editCategory)
            {
                Alert("Category edited successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Category not edited", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteCategory = await _category.Delete(id);
            if (deleteCategory)
            {
                Alert("Category deleted successfully", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Category not deleted", NotificationType.error);
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
