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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

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
                new Category { CategoryId = 8, Name = "Other" }
                
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
