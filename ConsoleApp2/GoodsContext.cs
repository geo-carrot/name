using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class GoodsContext : DbContext
    {
        public DbSet<Good> Goods { get; set; }

        public DbSet<Category> Categories { get; set; }

        private string _path = "goods.db";


        public GoodsContext()
        {
            if (File.Exists(_path))
            {
                Database.Migrate();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={ _path}");
        }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    IdCategory = Guid.NewGuid(),
                    Name = "овощи"
                },
                new Category
                {
                    IdCategory = Guid.NewGuid(),
                    Name = "фрукты"
                }
                );
        }


    }
}
