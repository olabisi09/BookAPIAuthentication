using BookWeb.Data;
using BookWeb.Entities;
using BookWeb.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookWeb.Services
{
    public class LanguageService : ILanguage
    {
        private BookWebDataContext _context;
        public LanguageService(BookWebDataContext context)
        {
            _context = context;
        }

        public void Add(Language language)
        {
            _context.Add(language);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Language language)
        {
            try
            {
                await _context.AddAsync(language);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> Delete(int Id)
        {
            // find the entity/object
            var language = await _context.Genres.FindAsync(Id);

            if (language != null)
            {
                _context.Genres.Remove(language);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Language>> GetAll()
        {

            return await _context.Languages.ToListAsync();
        }

        public async Task<Language> GetById(int Id)
        {
            var language = await _context.Languages.FindAsync(Id);

            return language;
        }

        public async Task<bool> Update(Language language)
        {
            var cat = await _context.Languages.FindAsync(language.Id);
            if (cat != null)
            {
                cat.LanguageName = language.LanguageName;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
