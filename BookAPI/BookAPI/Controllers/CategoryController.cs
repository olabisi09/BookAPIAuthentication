using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Entities;
using BookAPI.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategory _category;
        public CategoryController(ICategory category)
        {
            _category = category;
        }

        [HttpPost]
        public void Post([FromBody] Category category)
        {
            _category.Add(category);
        }

        [HttpPost("AddCategory")]
        public async Task<IActionResult> AddCategory([FromBody] Category category)
        {
            var createCategory = await _category.AddAsync(category);

            if (createCategory)
            {
                return Ok("Category Created");
            }
            else
            {
                return BadRequest(new { message = "Unable to create Category details" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _category.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _category.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Category category)
        {
            category.Id = id;
            var updateCategory = await _category.Update(category);

            if (updateCategory)
            {
                return Ok("Category Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update category details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteCategory = await _category.Delete(id);
            if (deleteCategory)
            {
                return Ok("Category Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete category details" });
            }
        }
    }
}
