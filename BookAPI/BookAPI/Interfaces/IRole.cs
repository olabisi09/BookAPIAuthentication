using BookAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Interfaces
{
    public interface IRole
    {
        Task<bool> CreateRole(ApplicationRole role);
        Task<bool> DeleteRole(string Id);
        Task<List<ApplicationRole>> GetAll();
        Task<ApplicationRole> GetById(string Id);
        Task<bool> Update(ApplicationRole r);
    }
}
