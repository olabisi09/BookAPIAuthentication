using BookWeb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Interfaces
{
    public interface ILanguage
    {
        void Add(Language language);
        Task<bool> AddAsync(Language language);
        Task<bool> Update(Language language);
        Task<IEnumerable<Language>> GetAll();
        Task<Language> GetById(int Id);
        Task<bool> Delete(int Id);
    }
}
