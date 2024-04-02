using Microsoft.EntityFrameworkCore;
using PlakDükkanıYöneticiApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiApp.Context
{
    public class PlakDukkanıAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-6LKAQV9R; Database=PlakDukkanıApp;Trusted_Connection=true;trustservercertificate=true");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Sanatci> Sanatcis { get; set;}

    }
}
