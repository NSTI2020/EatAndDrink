using System;
using EatAndDrink.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace EatAndDrink.Repository.Data
{
    public class EDContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<UnitMeasure> UnitMeasures { get; set; }

        public EDContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().HasKey(id => id.Id);
            builder.Entity<Product>().HasKey(id => id.Id);
            builder.Entity<SubCategory>().HasKey(id => id.Id);
            builder.Entity<UnitMeasure>().HasKey(id => id.Id);
        }


    }
}
