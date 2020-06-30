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
    public class CategoryService : ICategory
    {
        private BookWebDataContext _context;
        public CategoryService(BookWebDataContext context)
        {
            _context = context;
        }

        public void Add(Category category)
        {
            category.DateCreated = DateTime.Now;
            _context.Add(category);
            _context.SaveChanges();
        }
        public async Task<bool> AddAsync(Category category)
        {
            try
            {
                await _context.AddAsync(category);
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
            var category = await _context.Category.FindAsync(Id);

            if (category != null)
            {
                _context.Category.Remove(category);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {

            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetById(int Id)
        {
            var category = await _context.Category.FindAsync(Id);

            return category;
        }

        public async Task<bool> Update(Category category)
        {
            var cat = await _context.Category.FindAsync(category.Id);
            if (cat != null)
            {
                cat.CategoryName = category.CategoryName;
                cat.Location = category.Location;

                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
