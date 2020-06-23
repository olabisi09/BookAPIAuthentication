using BookAPI.Dtos;
using BookAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Interfaces
{
    public interface IAccount
    {
        Task<bool> CreateUser(ApplicationUser user, string password);

        Task<SignInModel> SignIn(LoginDto loginDetails);
    }
}
