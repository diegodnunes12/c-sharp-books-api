﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BooksApi.Models;

namespace BooksApi.Data
{
    public class BooksApiContext : DbContext
    {
        public BooksApiContext (DbContextOptions<BooksApiContext> options)
            : base(options)
        {
        }

        public DbSet<BooksApi.Models.Publisher> Publisher { get; set; }

        public DbSet<BooksApi.Models.Book> Book { get; set; }
    }
}
