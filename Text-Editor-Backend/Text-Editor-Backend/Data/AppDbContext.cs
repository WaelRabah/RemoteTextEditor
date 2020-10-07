using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Text_Editor_Backend.Models;

namespace Text_Editor_Backend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Writer> writers { get; set; }
        public DbSet<Text> Texts { get; set; }
    }
}