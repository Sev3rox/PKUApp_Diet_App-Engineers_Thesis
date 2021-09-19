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
        public DbSet<Meal> Meals { get; set; }
        public DbSet<UserProductFav> UserProductFavs { get; set; }
        public DbSet<MealProduct> MealProducts { get; set; }
        public DbSet<UserProductLastAdded> UserProductLastAddeds { get; set; }
        public DbSet<UserProductDish> UserProductDish { get; set; }
        public DbSet<UserDailyLimits> UserDailyLimits { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Products)
                .WithOne(e => e.User);

            modelBuilder.Entity<User>()
                .HasMany(c => c.Meals)
                .WithOne(e => e.User);

            modelBuilder.Entity<User>()
                        .HasOne(e => e.DailyLimits)
                        .WithOne(e => e.User)
                        .HasForeignKey<UserDailyLimits>(e => e.UserId);

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

            modelBuilder.Entity<UserProductLastAdded>()
                .HasKey(bc => new { bc.UserId, bc.ProductId });
            modelBuilder.Entity<UserProductLastAdded>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserProductLastAddeds)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserProductLastAdded>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.UserProductLastAddeds)
                .HasForeignKey(bc => bc.ProductId);
            
            modelBuilder.Entity<UserProductDish>()
                .HasKey(bc => new { bc.UserId, bc.ProductId });
            modelBuilder.Entity<UserProductDish>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.UserProductDish)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<UserProductDish>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.UserProductDish)
                .HasForeignKey(bc => bc.ProductId);


            //modelBuilder.ApplyConfiguration(new RoleConfiguration());

            // Code to seed data
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
