﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maris_Patricia_Lab2.Models;

namespace Maris_Patricia_Lab2.Data
{
    public class Maris_Patricia_Lab2Context : DbContext
    {
        public Maris_Patricia_Lab2Context (DbContextOptions<Maris_Patricia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Maris_Patricia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Maris_Patricia_Lab2.Models.Publisher> Publisher { get; set; }
    }
}
