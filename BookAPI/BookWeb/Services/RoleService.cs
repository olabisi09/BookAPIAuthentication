using BookWeb.Entities;
using BookWeb.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Services
{
    public class RoleService : IRole
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private IConfiguration _config;
        public RoleService(SignInManager<ApplicationUser> signInManager,
                                UserManager<ApplicationUser> userManager,
                                RoleManager<ApplicationRole> roleManager,
                                 IConfiguration config)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<bool> CreateRole(ApplicationRole role)
        {
            try
            {
                var checkRole = await _roleManager.CreateAsync(role);
                if (checkRole.Succeeded)
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public async Task<bool> DeleteRole(string Id)
        {
            var delete = await _roleManager.FindByIdAsync(Id);
            if(delete != null)
            {
                await _roleManager.DeleteAsync(delete);
                return true;
            }
            return false;
        }
        public async Task<List<ApplicationRole>> GetAll()
        {

            return await _roleManager.Roles.ToListAsync();
        }
        public async Task<ApplicationRole> GetById(string Id)
        {
            var role = await _roleManager.FindByIdAsync(Id);

            return role;
        }
        public async Task<bool> Update(ApplicationRole r)
        {
            var role = await _roleManager.FindByIdAsync(r.Id);
            if (role != null)
            {
                role.Name = r.Name;
                return true;
            }

            return false;
        }
    }
}
