using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tudose_Nicholas_Lab2.Models;

namespace Tudose_Nicholas_Lab2.Data
{
    public class Tudose_Nicholas_Lab2Context : DbContext
    {
        public Tudose_Nicholas_Lab2Context (DbContextOptions<Tudose_Nicholas_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tudose_Nicholas_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Tudose_Nicholas_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Tudose_Nicholas_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
