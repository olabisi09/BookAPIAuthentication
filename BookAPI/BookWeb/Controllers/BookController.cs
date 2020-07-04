using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BookWeb.Entities;
using BookWeb.Enums;
using BookWeb.Interfaces;
using BookWeb.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookWeb.Controllers
{
    //[Route("api/book")]
    //[ApiController]
    public class BookController : BaseController
    {
        private IBook _book;
        private readonly UserManager<ApplicationUser> _userManager;
        public BookController(IBook book, UserManager<ApplicationUser> userManager)
        {
            _book = book;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _book.GetAll();

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
        public async Task<IActionResult> Create(Book book)
        {
            book.CreatedBy = _userManager.GetUserName(User);
            var createBook = await _book.AddAsync(book);

            if (createBook)
            {
                Alert("Book created successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not created!", NotificationType.error);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var editBook = await _book.GetById(id);

            if (editBook == null)
            {
                
                return RedirectToAction("Index");
            }
            
            return View(editBook);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            var updateBook = await _book.Update(book);

            if (updateBook)
            {
                Alert("Book edited successfully.", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("An error occured while trying to edit this book", NotificationType.error);
            }
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                Alert("Book deleted", NotificationType.success);
                return RedirectToAction("Index");
            }
            else
            {
                Alert("Book not deleted", NotificationType.error);
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
