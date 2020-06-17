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
    [Route("api/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private ILanguage _language;
        public LanguageController(ILanguage language)
        {
            _language = language;
        }

        [HttpPost]
        public void Post([FromBody] Language language)
        {
            _language.Add(language);
        }

        [HttpPost("AddLanguage")]
        public async Task<IActionResult> AddLanguage([FromBody] Language language)
        {
            var createLanguage = await _language.AddAsync(language);

            if (createLanguage)
            {
                return Ok("Language Created");
            }
            else
            {
                return BadRequest(new { message = "Unable to create language details" });
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var users = await _language.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user = await _language.GetById(id);
            return Ok(user);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Language language)
        {
            language.Id = id;
            var updateLanguage = await _language.Update(language);

            if (updateLanguage)
            {
                return Ok("Language Updated");
            }
            else
            {
                return BadRequest(new { message = "Unable to update Language details" });
            }
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleteLanguage = await _language.Delete(id);
            if (deleteLanguage)
            {
                return Ok("Language Deleted");
            }
            else
            {
                return BadRequest(new { message = "Unable to delete language details" });
            }
        }
    }
}
