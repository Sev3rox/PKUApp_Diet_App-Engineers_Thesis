using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Models
{
    public class PKUAppDbContext : IdentityDbContext<User>
    {
        public PKUAppDbContext(DbContextOptions<PKUAppDbContext> options): base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserProductFav> UserProductFavs { get; set; }
        public DbSet<MealProduct> MealProducts { get; set; }
        public DbSet<UserMeal> UserMeals { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Products)
                .WithOne(e => e.User);

            modelBuilder.Entity<UserProductFav>()
                .HasKey(bc => new { bc.UserId, bc.ProductId });
            modelBuilder.Entity<UserProductFav>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserProductFavs)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserProductFav>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.UserProductFavs)
                .HasForeignKey(bc => bc.ProductId);

            modelBuilder.Entity<MealProduct>()
                .HasKey(bc => new { bc.MealId, bc.ProductId });
            modelBuilder.Entity<MealProduct>()
                .HasOne(bc => bc.Meal)
                .WithMany(b => b.MealProducts)
                .HasForeignKey(bc => bc.MealId);
            modelBuilder.Entity<MealProduct>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.MealProducts)
                .HasForeignKey(bc => bc.ProductId);

            modelBuilder.Entity<UserMeal>()
                .HasKey(bc => new { bc.UserId, bc.MealId });
            modelBuilder.Entity<UserMeal>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserMeals)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserMeal>()
                .HasOne(bc => bc.Meal)
                .WithMany(c => c.UserMeals)
                .HasForeignKey(bc => bc.MealId);


            //modelBuilder.ApplyConfiguration(new RoleConfiguration());

            //categorySeed(modelBuilder);

            // Code to seed data
        }

        public void categorySeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Fruits" },
                new Category { CategoryId = 2, Name = "Vegetables" },
                new Category { CategoryId = 3, Name = "Dairy" },
                new Category { CategoryId = 4, Name = "Grains" },
                new Category { CategoryId = 5, Name = "Protein Foods" },
                new Category { CategoryId = 6, Name = "Drinks" },
                new Category { CategoryId = 7, Name = "Snacks" },
                new Category { CategoryId = 8, Name = "Dishes" },
                new Category { CategoryId = 9, Name = "Other" }


                );
        }
    }



    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                }
            );
        }
    }
}
