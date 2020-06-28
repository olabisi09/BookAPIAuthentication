using BookWeb.Dtos;
using BookWeb.Entities;
using BookWeb.Interfaces;
using BookWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class AccountController : Controller
    {
        private IAccount _account;
        private IUser _user;
        public AccountController(IAccount account, IUser user)
        {
            _account = account;
            _user = user;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDto registerUser)
        {
            ApplicationUser user = new ApplicationUser();

            user.FirstName = registerUser.FirstName;
            user.LastName = registerUser.LastName;
            user.UserName = registerUser.Username;
            user.Email = registerUser.Email;


            var newUser = await _account.CreateUser(user, registerUser.Password);
            if (newUser)
                return RedirectToAction("Index");

            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginDto userDto)
        {
            var user = await _account.SignIn(userDto);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        public async Task<IActionResult> Index()
        {
            var model = await _user.GetAll();

            if (model != null)
                return View(model);
            return View();
        }

        //[HttpGet("{id}")]
        //public async Task<IActionResult> GetById(int id)
        //{
        //    var user = await _user.GetById(id);
        //    return Ok(user);
        //}

        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] User user)
        //{
        //    user.Id = id;
        //    var updateUser = await _user.Update(user);

        //    if (updateUser)
        //    {
        //        return Ok("User Updated");
        //    }
        //    else
        //    {
        //        return BadRequest(new { message = "Unable to update user details" });
        //    }
        //}

        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    var deleteUser = await _user.Delete(id);
        //    if (deleteUser)
        //    {
        //        return Ok("User Deleted");
        //    }
        //    else
        //    {
        //        return BadRequest(new { message = "Unable to delete user details" });
        //    }
        //}
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
