using BookWeb.Dtos;
using BookWeb.Entities;
using BookWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Interfaces
{
    public interface IAccount
    {
        Task<bool> CreateUser(ApplicationUser user, string password);

        Task<SignInModel> SignIn(LoginDto loginDetails);

        Task<bool> Login(LoginViewModel loginModel);

        //Task<bool> Signup(ApplicationUser user, string password);
    }
}
