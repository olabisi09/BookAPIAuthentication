﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data
{
    public class BookAPIDataContext: DbContext
    {
        public BookAPIDataContext(DbContextOptions<BookAPIDataContext> options) : base(options)
        {
        }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
