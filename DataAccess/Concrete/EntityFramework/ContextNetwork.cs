
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class ContextNetwork:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer(@"Server=DESKTOP-A7SVTRK;Database=NetWorkYetgen;Trusted_Connection=true");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Person> Persons { get; set; }


    }
}
