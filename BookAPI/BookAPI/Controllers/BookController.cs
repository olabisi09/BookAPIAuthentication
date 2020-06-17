using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Entities;
using BookAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBook _book;
        public BookController(IBook book)
        {
            _book = book;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _book.GetAll();
            return Ok(users);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _book.GetById(id);
            return Ok(user);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _book.Add(book);
        }

        [HttpPost("addBook")]
        public async Task<IActionResult> AddBook([FromBody] Book book)
        {
            var createBook = await _book.AddAsync(book);

            if (createBook)
            {
                return Ok("Book Created");
            }
            else
            {
                return BadRequest(new { message = "Unable to create book details" });
            }
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Book book)
        {
            book.Id = id;
            var updateBook = await _book.Update(book);

            if (updateBook)
            {
                return Ok("Book Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update book details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteBook = await _book.Delete(id);
            if (deleteBook)
            {
                return Ok("Book Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete book details" });
            }
        }
    }
}
