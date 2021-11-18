using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PKUAppAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PKUAppAPI.Data
{
    public static class SeedingData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Users
            #region Users
            var password = new PasswordHasher<User>();
            string hashed = "";

            var admin = new User { Id= "d318a720-1017-4703-98cf-44954069d6e5", Email = "a@a", Name = "Admin", UserName = "a@a", NormalizedUserName = "A@A", NormalizedEmail = "A@A", LockoutEnabled = true };
            var user = new User { Id = "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", Email = "u@u", Name = "User", UserName = "u@u", NormalizedUserName = "U@U", NormalizedEmail = "U@U", LockoutEnabled = true };
            var user2 = new User { Id = "46ad44f4-c682-4c31-8f04-b364d516a8ed", Email = "u@u2", Name = "User2", UserName = "u@u2", NormalizedUserName = "U@U2", NormalizedEmail = "U@U2", LockoutEnabled = true };
            var user3 = new User { Id = "b40c12be-c3bc-4765-80ca-2f637e603f8a", Email = "u@u3", Name = "User3", UserName = "u@u3", NormalizedUserName = "U@U3", NormalizedEmail = "U@U3", LockoutEnabled = true };
            hashed = password.HashPassword(admin, "123456");
            admin.PasswordHash = hashed;
            hashed = password.HashPassword(user, "123456");
            user.PasswordHash = hashed;
            hashed = password.HashPassword(user2, "123456");
            user2.PasswordHash = hashed;
            hashed = password.HashPassword(user3, "123456");
            user3.PasswordHash = hashed;

            modelBuilder.Entity<User>().HasData(
                admin,
                user,
                user2,
                user3
                );

            //UserRole
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "8923e08e-d84a-4d9c-aa85-7f45e356c0ec",
                    UserId = admin.Id
                }
            );

            #endregion

            //Products
            #region Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Apple",
                    Category = "Fruits",
                    Phe = 600,
                    Calories = 5200,
                    Protein = 30,
                    Fat = 0,
                    Carb = 1400
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Egg",
                    Category = "Protein Foods",
                    Phe = 68000,
                    Calories = 14300,
                    Protein = 1260,
                    Fat = 1000,
                    Carb = 100
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Orange",
                    Category = "Fruits",
                    Phe = 4300,
                    Calories = 6300,
                    Protein = 130,
                    Fat = 0,
                    Carb = 1600
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Wheat Bread",
                    Category = "Grains",
                    Phe = 26500,
                    Calories = 27000,
                    Protein = 1040,
                    Fat = 300,
                    Carb = 4900
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Bananas",
                    Category = "Fruits",
                    Phe = 4900,
                    Calories = 8900,
                    Protein = 110,
                    Fat = 0,
                    Carb = 2300
                },
                new Product
                {
                    ProductId = 6,
                    Name = "Milk 3.2%",
                    Category = "Dairy",
                    Phe = 16300,
                    Calories = 6100,
                    Protein = 320,
                    Fat = 300,
                    Carb = 500
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Sugar",
                    Category = "Other",
                    Phe = 0,
                    Calories = 38900,
                    Protein = 0,
                    Fat = 0,
                    Carb = 10000
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Tomatoes",
                    Category = "Vegetables",
                    Phe = 3000,
                    Calories = 1600,
                    Protein = 120,
                    Fat = 0,
                    Carb = 300
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Rice",
                    Category = "Grains",
                    Phe = 36400,
                    Calories = 37000,
                    Protein = 680,
                    Fat = 100,
                    Carb = 8200
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Potatoes",
                    Category = "Vegetables",
                    Phe = 7600,
                    Calories = 8600,
                    Protein = 170,
                    Fat = 0,
                    Carb = 2000
                },
                new Product
                {
                    ProductId = 11,
                    Name = "Lettuce",
                    Category = "Vegetables",
                    Phe = 5500,
                    Calories = 1500,
                    Protein = 140,
                    Fat = 0,
                    Carb = 300
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Chicken Breast",
                    Category = "Protein Foods",
                    Phe = 52500,
                    Calories = 26300,
                    Protein = 1470,
                    Fat = 1600,
                    Carb = 1500
                },
                new Product
                {
                    ProductId = 13,
                    Name = "Cheddar Cheese",
                    Category = "Dairy",
                    Phe = 131100,
                    Calories = 40300,
                    Protein = 2500,
                    Fat = 3300,
                    Carb = 100
                },
                new Product
                {
                    ProductId = 14,
                    Name = "Avocados",
                    Category = "Fruits",
                    Phe = 9700,
                    Calories = 16000,
                    Protein = 200,
                    Fat = 1500,
                    Carb = 900
                },
               new Product
               {
                   ProductId = 15,
                   Name = "Broccoli",
                   Category = "Vegetables",
                   Phe = 11700,
                   Calories = 3400,
                   Protein = 280,
                   Fat = 0,
                   Carb = 700
               },
               new Product
               {
                   ProductId = 16,
                   Name = "Cucumber",
                   Category = "Vegetables",
                   Phe = 3100,
                   Calories = 1200,
                   Protein = 60,
                   Fat = 0,
                   Carb = 200
               },
               new Product
               {
                   ProductId = 17,
                   Name = "Olive",
                   Category = "Other",
                   Phe = 0,
                   Calories = 88400,
                   Protein = 0,
                   Fat = 10000,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 18,
                   Name = "Water",
                   Category = "Drinks",
                   Phe = 0,
                   Calories = 0,
                   Protein = 0,
                   Fat = 0,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 19,
                   Name = "Apple Juice",
                   Category = "Drinks",
                   Phe = 100,
                   Calories = 4700,
                   Protein = 10,
                   Fat = 0,
                   Carb = 120
               },
               new Product
               {
                   ProductId = 20,
                   Name = "Orange Juice",
                   Category = "Drinks",
                   Phe = 900,
                   Calories = 4500,
                   Protein = 70,
                   Fat = 0,
                   Carb = 1000
               },
               new Product
               {
                   ProductId = 21,
                   Name = "Yogurt",
                   Category = "Dairy",
                   Phe = 28600,
                   Calories = 6300,
                   Protein = 530,
                   Fat = 200,
                   Carb = 700
               },
               new Product
               {
                   ProductId = 22,
                   Name = "Butter",
                   Category = "Dairy",
                   Phe = 4100,
                   Calories = 71700,
                   Protein = 90,
                   Fat = 8100,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 23,
                   Name = "Pasta",
                   Category = "Grains",
                   Phe = 28200,
                   Calories = 13000,
                   Protein = 530,
                   Fat = 200,
                   Carb = 2400
               },
               new Product
               {
                   ProductId = 24,
                   Name = "Croissant",
                   Category = "Grains",
                   Phe = 41600,
                   Calories = 40600,
                   Protein = 820,
                   Fat = 2100,
                   Carb = 4600
               },
               new Product
               {
                   ProductId = 25,
                   Name = "Salami",
                   Category = "Protein Foods",
                   Phe = 45100,
                   Calories = 23800,
                   Protein = 1420,
                   Fat = 1900,
                   Carb = 200
               },
               new Product
               {
                   ProductId = 26,
                   Name = "Lamb",
                   Category = "Protein Foods",
                   Phe = 86000,
                   Calories = 35900,
                   Protein = 2200,
                   Fat = 2900,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 27,
                   Name = "Tuna",
                   Category = "Protein Foods",
                   Phe = 1137,
                   Calories = 19800,
                   Protein = 2910,
                   Fat = 800,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 28,
                   Name = "Tofu",
                   Category = "Protein Foods",
                   Phe = 76800,
                   Calories = 14500,
                   Protein = 1600,
                   Fat = 900,
                   Carb = 400
               },
               new Product
               {
                   ProductId = 29,
                   Name = "Beff",
                   Category = "Protein Foods",
                   Phe = 119000,
                   Calories = 23700,
                   Protein = 3040,
                   Fat = 1200,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 30,
                   Name = "Pork",
                   Category = "Protein Foods",
                   Phe = 38400,
                   Calories = 63200,
                   Protein = 930,
                   Fat = 6600,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 31,
                   Name = "Cola",
                   Category = "Drinks",
                   Phe = 0,
                   Calories = 4100,
                   Protein = 0,
                   Fat = 0,
                   Carb = 1000
               },
               new Product
               {
                   ProductId = 32,
                   Name = "Sprite",
                   Category = "Drinks",
                   Phe = 0,
                   Calories = 3900,
                   Protein = 0,
                   Fat = 0,
                   Carb = 950
               },
               new Product
               {
                   ProductId = 33,
                   Name = "Fries",
                   Category = "Snacks",
                   Phe = 14600,
                   Calories = 28000,
                   Protein = 320,
                   Fat = 1200,
                   Carb = 3900
               },
               new Product
               {
                   ProductId = 34,
                   Name = "Chips",
                   Category = "Snacks",
                   Phe = 17600,
                   Calories = 29500,
                   Protein = 300,
                   Fat = 1800,
                   Carb = 4100
               },
               new Product
               {
                   ProductId = 35,
                   Name = "Roasted Peanuts",
                   Category = "Snacks",
                   Phe = 142700,
                   Calories = 59900,
                   Protein = 2800,
                   Fat = 5300,
                   Carb = 1500
               },
               new Product
               {
                   ProductId = 36,
                   Name = "Potato Chips",
                   Category = "Snacks",
                   Phe = 38800,
                   Calories = 49600,
                   Protein = 850,
                   Fat = 2700,
                   Carb = 5800
               },
               new Product
               {
                   ProductId = 37,
                   Name = "Crackers",
                   Category = "Snacks",
                   Phe = 33000,
                   Calories = 49200,
                   Protein = 720,
                   Fat = 2300,
                   Carb = 6400
               },
               new Product
               {
                   ProductId = 38,
                   Name = "Pepperoni Pizza",
                   Category = "Dishes",
                   Phe = 61200,
                   Calories = 29100,
                   Protein = 1220,
                   Fat = 1300,
                   Carb = 3200
               },
               new Product
               {
                   ProductId = 39,
                   Name = "Cheese Pizza",
                   Category = "Dishes",
                   Phe = 66400,
                   Calories = 26600,
                   Protein = 1150,
                   Fat = 1000,
                   Carb = 3300
               },
               new Product
               {
                   ProductId = 40,
                   Name = "Cheeseburger",
                   Category = "Dishes",
                   Phe = 66000,
                   Calories = 28600,
                   Protein = 1460,
                   Fat = 1500,
                   Carb = 2400
               },
               new Product
               {
                   ProductId = 41,
                   Name = "Hamburger",
                   Category = "Dishes",
                   Phe = 62400,
                   Calories = 26100,
                   Protein = 1490,
                   Fat = 1100,
                   Carb = 2700
               },
               new Product
               {
                   ProductId = 42,
                   Name = "Lasagne",
                   Category = "Dishes",
                   Phe = 32900,
                   Calories = 13500,
                   Protein = 730,
                   Fat = 500,
                   Carb = 1500
               },
               new Product
               {
                   ProductId = 43,
                   Name = "Hotdog",
                   Category = "Dishes",
                   Phe = 41700,
                   Calories = 24700,
                   Protein = 1060,
                   Fat = 1500,
                   Carb = 1800
               },
               new Product
               {
                   ProductId = 44,
                   Name = "Ketchup",
                   Category = "Other",
                   Phe = 2600,
                   Calories = 11200,
                   Protein = 130,
                   Fat = 0,
                   Carb = 2600
               },
               new Product
               {
                   ProductId = 45,
                   Name = "Mustard",
                   Category = "Other",
                   Phe = 16700,
                   Calories = 6700,
                   Protein = 440,
                   Fat = 400,
                   Carb = 500
               },
               new Product
               {
                   ProductId = 46,
                   Name = "Mayonnaise",
                   Category = "Other",
                   Phe = 15400,
                   Calories = 72100,
                   Protein = 100,
                   Fat = 7900,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 47,
                   Name = "Salt",
                   Category = "Other",
                   Phe = 0,
                   Calories = 0,
                   Protein = 0,
                   Fat = 0,
                   Carb = 0
               },
               new Product
               {
                   ProductId = 48,
                   Name = "Red Pepper",
                   Category = "Vegetables",
                   Phe = 3300,
                   Calories = 3100,
                   Protein = 100,
                   Fat = 0,
                   Carb = 600
               },
               new Product
               {
                   ProductId = 49,
                   Name = "Ham",
                   Category = "Protein Foods",
                   Phe = 64100,
                   Calories = 26300,
                   Protein = 1630,
                   Fat = 2100,
                   Carb = 200
               },
               new Product
               {
                   ProductId = 50,
                   Name = "Onions",
                   Category = "Vegetables",
                   Phe = 2500,
                   Calories = 4000,
                   Protein = 110,
                   Fat = 0,
                   Carb = 900
               },

                //categories    "Fruits","Vegetables","Dairy","Grains","Protein Foods","Drinks","Snacks","Dishes","Other"

                //User's products

                new Product
                {
                    ProductId = 101,
                    Name = "Raspberries",
                    Category = "Frutis",
                    Phe = 3000,
                    Calories = 4900,
                    Protein = 90,
                    Fat = 100,
                    Carb = 1200,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 102,
                    Name = "Grapes",
                    Category = "Frutis",
                    Phe = 1300,
                    Calories = 6700,
                    Protein = 60,
                    Fat = 0,
                    Carb = 1700,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 103,
                    Name = "Fanta",
                    Category = "Drinks",
                    Phe = 0,
                    Calories = 4300,
                    Protein = 0,
                    Fat = 0,
                    Carb = 1100,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 104,
                    Name = "Meatballs",
                    Category = "Dishes",
                    Phe = 14800,
                    Calories = 18000,
                    Protein = 1100,
                    Fat = 600,
                    Carb = 600,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 105,
                    Name = "Carrots",
                    Category = "Vegetables",
                    Phe = 6100,
                    Calories = 4100,
                    Protein = 90,
                    Fat = 0,
                    Carb = 1000,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 106,
                    Name = "Enoki",
                    Category = "Other",
                    Phe = 1500,
                    Calories = 3700,
                    Protein = 270,
                    Fat = 0,
                    Carb = 800,
                    UserId = user.Id
                },
                new Product
                {
                    ProductId = 107,
                    Name = "Camembert",
                    Category = "Dairy",
                    Phe = 110500,
                    Calories = 30000,
                    Protein = 1980,
                    Fat = 2400,
                    Carb = 0,
                    UserId = user.Id
                }
            );
            #endregion

            //Meals
            #region Meals

            var today = DateTime.Today.AddDays(1);
            today = new DateTime(today.Year, today.Month, today.Day);

            //Meal names  "First Meal","Second Meal","Third Meal","Fourth Meal","Fifth Meal","Sixth Meal","Seventh Meal","Eighth Meal","Ninth Meal","Tenth Meal"
            modelBuilder.Entity<Meal>().HasData(
                //user1    meals
                new Meal
                {
                    MealId = 1,
                    Name = "First Meal",
                    Date = today,
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 2,
                    Name = "Second Meal",
                    Date = today,
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 3,
                    Name = "Third Meal",
                    Date = today,
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 4,
                    Name = "First Meal",
                    Date = today.AddDays(-1),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 5,
                    Name = "Second Meal",
                    Date = today.AddDays(-1),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 6,
                    Name = "First Meal",
                    Date = today.AddDays(-3),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 7,
                    Name = "Second Meal",
                    Date = today.AddDays(-3),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 8,
                    Name = "Third Meal",
                    Date = today.AddDays(-3),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 9,
                    Name = "First Meal",
                    Date = today.AddDays(-6),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 10,
                    Name = "Second Meal",
                    Date = today.AddDays(-6),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 11,
                    Name = "First Meal",
                    Date = today.AddDays(-7),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 12,
                    Name = "Second Meal",
                    Date = today.AddDays(-7),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 13,
                    Name = "Third Meal",
                    Date = today.AddDays(-7),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 14,
                    Name = "First Meal",
                    Date = today.AddDays(-10),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 15,
                    Name = "Second Meal",
                    Date = today.AddDays(-10),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 16,
                    Name = "Third Meal",
                    Date = today.AddDays(-10),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 17,
                    Name = "Fourth Meal",
                    Date = today.AddDays(-10),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 18,
                    Name = "First Meal",
                    Date = today.AddDays(-13),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 19,
                    Name = "Second Meal",
                    Date = today.AddDays(-13),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 20,
                    Name = "First Meal",
                    Date = today.AddDays(-15),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 21,
                    Name = "Second Meal",
                    Date = today.AddDays(-15),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 22,
                    Name = "Third Meal",
                    Date = today.AddDays(-15),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 23,
                    Name = "First Meal",
                    Date = today.AddDays(-20),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 24,
                    Name = "Second Meal",
                    Date = today.AddDays(-20),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 25,
                    Name = "First Meal",
                    Date = today.AddDays(-24),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 26,
                    Name = "Second Meal",
                    Date = today.AddDays(-24),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 27,
                    Name = "First Meal",
                    Date = today.AddDays(-27),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 28,
                    Name = "Second Meal",
                    Date = today.AddDays(-27),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 29,
                    Name = "Third Meal",
                    Date = today.AddDays(-27),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 30,
                    Name = "First Meal",
                    Date = today.AddDays(-29),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 31,
                    Name = "First Meal",
                    Date = today.AddDays(1),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 32,
                    Name = "Second Meal",
                    Date = today.AddDays(1),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 33,
                    Name = "First Meal",
                    Date = today.AddDays(2),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 34,
                    Name = "Second Meal",
                    Date = today.AddDays(2),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 35,
                    Name = "First Meal",
                    Date = today.AddDays(3),
                    UserId = user.Id
                },
                new Meal
                {
                    MealId = 36,
                    Name = "First Meal",
                    Date = today.AddDays(5),
                    UserId = user.Id
                }


            );
            #endregion

            //UserProductFavs
            #region UserProductFavs
            modelBuilder.Entity<UserProductFav>().HasData(
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 1
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 105
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 8
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 12
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 103
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 47
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 32
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 4
                },
                new UserProductFav
                {
                    UserId = user.Id,
                    ProductId = 17
                }
            );
            #endregion

            // MealProducts
            #region MealProducts
            modelBuilder.Entity<MealProduct>().HasData(
                //meal 1
                new MealProduct
                {
                    MealId = 1,
                    ProductId = 38,
                    Weight = 45000
                },
                //meal 2
                new MealProduct
                {
                    MealId = 2,
                    ProductId = 40,
                    Weight = 25000
                },
                //meal 3
                new MealProduct
                {
                    MealId = 3,
                    ProductId = 43,
                    Weight = 30000
                },
                //meal 4
                new MealProduct
                {
                    MealId = 4,
                    ProductId = 25,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 4,
                    ProductId = 4,
                    Weight = 25000
                },
                //meal 5
                new MealProduct
                {
                    MealId = 5,
                    ProductId = 2,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 5,
                    ProductId = 12,
                    Weight = 25000
                },
                //meal 6
                new MealProduct
                {
                    MealId = 6,
                    ProductId = 1,
                    Weight = 10000
                },
                new MealProduct
                {
                    MealId = 6,
                    ProductId = 3,
                    Weight = 10000
                },
                new MealProduct
                {
                    MealId = 6,
                    ProductId = 5,
                    Weight = 10000
                },
                //meal 7
                new MealProduct
                {
                    MealId = 7,
                    ProductId = 42,
                    Weight = 36000
                },
                //meal 8
                new MealProduct
                {
                    MealId = 8,
                    ProductId = 6,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 8,
                    ProductId = 50,
                    Weight = 8000
                },
                new MealProduct
                {
                    MealId = 8,
                    ProductId = 10,
                    Weight = 35000
                },
                //meal 9
                new MealProduct
                {
                    MealId = 9,
                    ProductId = 21,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 9,
                    ProductId = 101,
                    Weight = 10000
                },
                //meal 10
                new MealProduct
                {
                    MealId = 10,
                    ProductId = 33,
                    Weight = 25000
                },
                new MealProduct
                {
                    MealId = 10,
                    ProductId = 32,
                    Weight = 20000
                },
                //meal 11
                new MealProduct
                {
                    MealId = 11,
                    ProductId = 39,
                    Weight = 35000
                },
                //meal 12
                new MealProduct
                {
                    MealId = 12,
                    ProductId = 28,
                    Weight = 8000
                },
                new MealProduct
                {
                    MealId = 12,
                    ProductId = 36,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 12,
                    ProductId = 105,
                    Weight = 5000
                },
                //meal 13
                new MealProduct
                {
                    MealId = 13,
                    ProductId = 107,
                    Weight = 10000
                },
                new MealProduct
                {
                    MealId = 13,
                    ProductId = 37,
                    Weight = 15000
                },
                //meal 14
                new MealProduct
                {
                    MealId = 14,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 14,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 15
                new MealProduct
                {
                    MealId = 15,
                    ProductId = 41,
                    Weight = 25000
                },
                new MealProduct
                {
                    MealId = 15,
                    ProductId = 31,
                    Weight = 18000
                },
                //meal 16
                new MealProduct
                {
                    MealId = 16,
                    ProductId = 4,
                    Weight = 18000
                },
                new MealProduct
                {
                    MealId = 16,
                    ProductId = 46,
                    Weight = 3000
                },
                new MealProduct
                {
                    MealId = 16,
                    ProductId = 49,
                    Weight = 10000
                },
                //meal 17
                new MealProduct
                {
                    MealId = 17,
                    ProductId = 40,
                    Weight = 28000
                },
                //meal 18
                new MealProduct
                {
                    MealId = 18,
                    ProductId = 40,
                    Weight = 25000
                },
                new MealProduct
                {
                    MealId = 18,
                    ProductId = 32,
                    Weight = 5000
                },
                //meal 19
                new MealProduct
                {
                    MealId = 19,
                    ProductId = 40,
                    Weight = 25000
                },
                new MealProduct
                {
                    MealId = 19,
                    ProductId = 32,
                    Weight = 5000
                },
                //meal 20
                new MealProduct
                {
                    MealId = 20,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 20,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 21
                new MealProduct
                {
                    MealId = 21,
                    ProductId = 28,
                    Weight = 8000
                },
                new MealProduct
                {
                    MealId = 21,
                    ProductId = 36,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 21,
                    ProductId = 105,
                    Weight = 5000
                },
                //meal 22
                new MealProduct
                {
                    MealId = 22,
                    ProductId = 38,
                    Weight = 45000
                },
                //meal 23
                new MealProduct
                {
                    MealId = 23,
                    ProductId = 107,
                    Weight = 10000
                },
                new MealProduct
                {
                    MealId = 23,
                    ProductId = 37,
                    Weight = 15000
                },
                //meal 24
                new MealProduct
                {
                    MealId = 24,
                    ProductId = 6,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 24,
                    ProductId = 50,
                    Weight = 8000
                },
                new MealProduct
                {
                    MealId = 24,
                    ProductId = 10,
                    Weight = 35000
                },
                //meal 25
                new MealProduct
                {
                    MealId = 25,
                    ProductId = 4,
                    Weight = 18000
                },
                new MealProduct
                {
                    MealId = 25,
                    ProductId = 46,
                    Weight = 3000
                },
                new MealProduct
                {
                    MealId = 25,
                    ProductId = 49,
                    Weight = 10000
                },
                //meal 26
                new MealProduct
                {
                    MealId = 26,
                    ProductId = 41,
                    Weight = 25000
                },
                new MealProduct
                {
                    MealId = 26,
                    ProductId = 31,
                    Weight = 18000
                },
                //meal 27
                new MealProduct
                {
                    MealId = 27,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 27,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 28
                new MealProduct
                {
                    MealId = 28,
                    ProductId = 43,
                    Weight = 30000
                },
                //meal 29
                new MealProduct
                {
                    MealId = 29,
                    ProductId = 21,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 29,
                    ProductId = 101,
                    Weight = 10000
                },
                //meal 30
                new MealProduct
                {
                    MealId = 30,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 30,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 31
                new MealProduct
                {
                    MealId = 31,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 31,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 32
                new MealProduct
                {
                    MealId = 32,
                    ProductId = 4,
                    Weight = 18000
                },
                new MealProduct
                {
                    MealId = 32,
                    ProductId = 46,
                    Weight = 3000
                },
                new MealProduct
                {
                    MealId = 32,
                    ProductId = 49,
                    Weight = 10000
                },
                //meal 33
                new MealProduct
                {
                    MealId = 33,
                    ProductId = 31,
                    Weight = 15000
                },
                new MealProduct
                {
                    MealId = 33,
                    ProductId = 24,
                    Weight = 18000
                },
                //meal 34
                new MealProduct
                {
                    MealId = 34,
                    ProductId = 107,
                    Weight = 10000
                },
                new MealProduct
                {
                    MealId = 34,
                    ProductId = 37,
                    Weight = 15000
                },
                //meal 35
                new MealProduct
                {
                    MealId = 35,
                    ProductId = 2,
                    Weight = 20000
                },
                new MealProduct
                {
                    MealId = 35,
                    ProductId = 12,
                    Weight = 25000
                },
                //meal 36
                new MealProduct
                {
                    MealId = 36,
                    ProductId = 43,
                    Weight = 30000
                }
            );
            #endregion

            //UserProductLastAddeds
            #region UserProductLastAddeds
            modelBuilder.Entity<UserProductLastAdded>().HasData(
            //user1 last
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 1
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 101
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 10
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 11
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 34
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 41
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 103
            },
            new UserProductLastAdded
            {
                UserId = user.Id,
                ProductId = 106
            }
        );
            #endregion

            //UserProductDish
            #region UserProductDish
            modelBuilder.Entity<UserProductDish>().HasData(
            //user1 dish
            new UserProductDish
            {
                UserId = user.Id,
                ProductId = 1,
                Weight = 15000
            },
            new UserProductDish
            {
                UserId = user.Id,
                ProductId = 101,
                Weight = 5000
            },
            new UserProductDish
            {
                UserId = user.Id,
                ProductId = 5,
                Weight = 10000
            },
            new UserProductDish
            {
                UserId = user.Id,
                ProductId = 14,
                Weight = 7500
            },
            new UserProductDish
            {
                UserId = user.Id,
                ProductId = 102,
                Weight = 5000
            }
        );
            #endregion

            //UserDailyLimits
            #region UserDailyLimits
            modelBuilder.Entity<UserDailyLimits>().HasData(
                new UserDailyLimits { UserDailyLimitsId = 1, UserId = user.Id, PheLimit = 100000, CaloriesLimit = 240000, ProteinLimit = 16000, FatLimit = 12000, CarbLimit = 15000, AddCalories = true },
                new UserDailyLimits { UserDailyLimitsId = 2, UserId = user2.Id, PheLimit = 0, CaloriesLimit = 0, ProteinLimit = 0, FatLimit = 0, CarbLimit = 0 },
                new UserDailyLimits { UserDailyLimitsId = 3, UserId = user3.Id, PheLimit = 0, CaloriesLimit = 0, ProteinLimit = 0, FatLimit = 0, CarbLimit = 0 }
            );
            #endregion

            //UserOffAlerts
            #region UserOffAlerts
            modelBuilder.Entity<UserOffAlert>().HasData(
                //user1 alerts
                new UserOffAlert
                {
                    UserOffAlertId = 1,
                    UserId = user.Id,
                    Date = today.AddDays(1)
                },
                new UserOffAlert
                {
                    UserOffAlertId = 2,
                    UserId = user.Id,
                    Date = today.AddDays(2)
                }
            );
            #endregion

            //UserMedicines
            #region UserMedicines
            modelBuilder.Entity<UserMedicine>().HasData(
                //user1 med
                new UserMedicine
                {
                    UserMedicineId = 1,
                    StartDate = today,
                    UserId = user.Id,
                    Phe = 1200,
                    Calories = 5200,
                    Protein = 3000,
                    Fat = 1800,
                    Carb = 3400
                },
                new UserMedicine
                {
                    UserMedicineId = 2,
                    StartDate = today.AddDays(-15),
                    EndDate = today.AddDays(-5),
                    UserId = user.Id,
                    Phe = 1500,
                    Calories = 5000,
                    Protein = 3400,
                    Fat = 1700,
                    Carb = 3800
                },
                new UserMedicine
                {
                    UserMedicineId = 3,
                    StartDate = today.AddDays(-25),
                    EndDate = today.AddDays(-18),
                    UserId = user.Id,
                    Phe = 1100,
                    Calories = 5300,
                    Protein = 3200,
                    Fat = 1900,
                    Carb = 3500
                },
                //user2 med
                new UserMedicine
                {
                    UserMedicineId = 22,
                    StartDate = today.AddDays(-3),
                    UserId = user.Id,
                    Phe = 1000,
                    Calories = 4200,
                    Protein = 3600,
                    Fat = 2800,
                    Carb = 4400
                }
            );
            #endregion

            //TrackedValues
            #region TrackedValues
            // 1-weight, 2-phe
            modelBuilder.Entity<TrackedValue>().HasData(
                //user1 TrackedValues phe
                new TrackedValue
                {
                    TrackedValueId = 1,
                    Date = today,
                    UserId = user.Id,
                    Type = 2,
                    Value = 980
                },
                new TrackedValue
                {
                    TrackedValueId = 2,
                    Date = today.AddDays(-2),
                    UserId = user.Id,
                    Type = 2,
                    Value = 960
                },
                new TrackedValue
                {
                    TrackedValueId = 3,
                    Date = today.AddDays(-8),
                    UserId = user.Id,
                    Type = 2,
                    Value = 930
                },
                new TrackedValue
                {
                    TrackedValueId = 4,
                    Date = today.AddDays(-12),
                    UserId = user.Id,
                    Type = 2,
                    Value = 970
                },
                new TrackedValue
                {
                    TrackedValueId = 5,
                    Date = today.AddDays(-15),
                    UserId = user.Id,
                    Type = 2,
                    Value = 900
                },
                new TrackedValue
                {
                    TrackedValueId = 6,
                    Date = today.AddDays(-19),
                    UserId = user.Id,
                    Type = 2,
                    Value = 880
                },
                new TrackedValue
                {
                    TrackedValueId = 7,
                    Date = today.AddDays(-22),
                    UserId = user.Id,
                    Type = 2,
                    Value = 930
                },
                new TrackedValue
                {
                    TrackedValueId = 8,
                    Date = today.AddDays(-25),
                    UserId = user.Id,
                    Type = 2,
                    Value = 900
                },
                new TrackedValue
                {
                    TrackedValueId = 9,
                    Date = today.AddDays(-27),
                    UserId = user.Id,
                    Type = 2,
                    Value = 870
                },
                new TrackedValue
                {
                    TrackedValueId = 10,
                    Date = today.AddDays(-29),
                    UserId = user.Id,
                    Type = 2,
                    Value = 850
                },
                //user1 TrackedValues weight
                new TrackedValue
                {
                    TrackedValueId = 101,
                    Date = today,
                    UserId = user.Id,
                    Type = 1,
                    Value = 10600
                },
                new TrackedValue
                {
                    TrackedValueId = 102,
                    Date = today.AddDays(-2),
                    UserId = user.Id,
                    Type = 1,
                    Value = 1060
                },
                new TrackedValue
                {
                    TrackedValueId = 103,
                    Date = today.AddDays(-4),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10690
                },
                new TrackedValue
                {
                    TrackedValueId = 104,
                    Date = today.AddDays(-8),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10720
                },
                new TrackedValue
                {
                    TrackedValueId = 105,
                    Date = today.AddDays(-10),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10700
                },
                new TrackedValue
                {
                    TrackedValueId = 106,
                    Date = today.AddDays(-12),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10710
                },
                new TrackedValue
                {
                    TrackedValueId = 107,
                    Date = today.AddDays(-15),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10740
                },
                new TrackedValue
                {
                    TrackedValueId = 108,
                    Date = today.AddDays(-18),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10750
                },
                new TrackedValue
                {
                    TrackedValueId = 109,
                    Date = today.AddDays(-25),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10800
                },
                new TrackedValue
                {
                    TrackedValueId = 110,
                    Date = today.AddDays(-29),
                    UserId = user.Id,
                    Type = 1,
                    Value = 10870
                }
            );
            #endregion

            //Exercises
            #region Exercises
            modelBuilder.Entity<Exercise>().HasData(
               new Exercise
               {
                   ExerciseId = 1,
                   Name = "Running",
                   Calories = 45000
               },
               new Exercise
               {
                   ExerciseId = 2,
                   Name = "Swimming",
                   Calories = 90000
               },
               new Exercise
               {
                   ExerciseId = 3,
                   Name = "Road Biking",
                   Calories = 41500
               },
               new Exercise
               {
                   ExerciseId = 4,
                   Name = "Dance",
                   Calories = 48000
               },
               new Exercise
               {
                   ExerciseId = 5,
                   Name = "Jumping Rope",
                   Calories = 56000
               },
               new Exercise
               {
                   ExerciseId = 6,
                   Name = "Walking",
                   Calories = 14000
               },
               new Exercise
               {
                   ExerciseId = 7,
                   Name = "Stair Treadmill",
                   Calories = 58000
               },
               new Exercise
               {
                   ExerciseId = 8,
                   Name = "Stationary Cycling",
                   Calories = 18000
               },
               new Exercise
               {
                   ExerciseId = 9,
                   Name = "Stretching",
                   Calories = 9000
               },
               new Exercise
               {
                   ExerciseId = 10,
                   Name = "Calisthenics",
                   Calories = 13000
               },
               new Exercise
               {
                   ExerciseId = 11,
                   Name = "Treadmill Walking",
                   Calories = 14000
               },
               new Exercise
               {
                   ExerciseId = 12,
                   Name = "Circuit Training",
                   Calories = 24000
               },
               new Exercise
               {
                   ExerciseId = 13,
                   Name = "Exercise Ball",
                   Calories = 13000
               },
               new Exercise
               {
                   ExerciseId = 14,
                   Name = "Sailing",
                   Calories = 16000
               },
               new Exercise
               {
                   ExerciseId = 15,
                   Name = "Badminton",
                   Calories = 32000
               },
               new Exercise
               {
                   ExerciseId = 16,
                   Name = "Golf",
                   Calories = 18000
               },
               new Exercise
               {
                   ExerciseId = 17,
                   Name = "Gymnastics",
                   Calories = 20000
               },
               new Exercise
               {
                   ExerciseId = 18,
                   Name = "Roller Skating",
                   Calories = 43000
               },
               new Exercise
               {
                   ExerciseId = 19,
                   Name = "Skating",
                   Calories = 32000
               },
               new Exercise
               {
                   ExerciseId = 20,
                   Name = "Ski Touring",
                   Calories = 41500
               },
               new Exercise
               {
                   ExerciseId = 21,
                   Name = "Polo",
                   Calories = 50000
               },
               new Exercise
               {
                   ExerciseId = 22,
                   Name = "Squash",
                   Calories = 45000
               },
               new Exercise
               {
                   ExerciseId = 23,
                   Name = "Tennis",
                   Calories = 28500
               },
               new Exercise
               {
                   ExerciseId = 24,
                   Name = "Table Tennis",
                   Calories = 21500
               },
               new Exercise
               {
                   ExerciseId = 25,
                   Name = "Frisbee",
                   Calories = 14000
               },
               new Exercise
               {
                   ExerciseId = 26,
                   Name = "Valleyball",
                   Calories = 22000
               },
               new Exercise
               {
                   ExerciseId = 27,
                   Name = "Beach Valleyball",
                   Calories = 50000
               },
               new Exercise
               {
                   ExerciseId = 28,
                   Name = "Basketball",
                   Calories = 25000
               },
               new Exercise
               {
                   ExerciseId = 29,
                   Name = "Cheerleading",
                   Calories = 36000
               },
               new Exercise
               {
                   ExerciseId = 30,
                   Name = "Lacrosse",
                   Calories = 50000
               },
               new Exercise
               {
                   ExerciseId = 31,
                   Name = "Handball",
                   Calories = 50000
               },
               new Exercise
               {
                   ExerciseId = 32,
                   Name = "Hockey",
                   Calories = 50000
               },
               new Exercise
               {
                   ExerciseId = 33,
                   Name = "Football",
                   Calories = 43000
               },
               new Exercise
               {
                   ExerciseId = 34,
                   Name = "Cricket",
                   Calories = 27000
               },
               new Exercise
               {
                   ExerciseId = 35,
                   Name = "Rugby",
                   Calories = 38000
               },
               new Exercise
               {
                   ExerciseId = 36,
                   Name = "Baseball",
                   Calories = 25000
               }


           );
            #endregion

            //UserExercises
            #region UserExercises
            modelBuilder.Entity<UserExercise>().HasData(
                //user1   exercises
                new UserExercise
                {
                    UserExerciseId = 1,
                    ExerciseId = 1,
                    Date = today,
                    UserId = user.Id,
                    Time = 3000
                },
                new UserExercise
                {
                    UserExerciseId = 2,
                    ExerciseId = 2,
                    Date = today.AddDays(-1),
                    UserId = user.Id,
                    Time = 4500
                },
                new UserExercise
                {
                    UserExerciseId = 3,
                    ExerciseId = 3,
                    Date = today.AddDays(-3),
                    UserId = user.Id,
                    Time = 9000
                },
                new UserExercise
                {
                    UserExerciseId = 4,
                    ExerciseId = 1,
                    Date = today.AddDays(-6),
                    UserId = user.Id,
                    Time = 6000
                },
                new UserExercise
                {
                    UserExerciseId = 5,
                    ExerciseId = 2,
                    Date = today.AddDays(-7),
                    UserId = user.Id,
                    Time = 6000
                },
                new UserExercise
                {
                    UserExerciseId = 6,
                    ExerciseId = 28,
                    Date = today.AddDays(-10),
                    UserId = user.Id,
                    Time = 9000
                },
                new UserExercise
                {
                    UserExerciseId = 7,
                    ExerciseId = 3,
                    Date = today.AddDays(-12),
                    UserId = user.Id,
                    Time = 4500
                },
                new UserExercise
                {
                    UserExerciseId = 8,
                    ExerciseId = 3,
                    Date = today.AddDays(-13),
                    UserId = user.Id,
                    Time = 4500
                },
                new UserExercise
                {
                    UserExerciseId = 9,
                    ExerciseId = 8,
                    Date = today.AddDays(-15),
                    UserId = user.Id,
                    Time = 12000
                },
                new UserExercise
                {
                    UserExerciseId = 10,
                    ExerciseId = 8,
                    Date = today.AddDays(-18),
                    UserId = user.Id,
                    Time = 4000
                },
                new UserExercise
                {
                    UserExerciseId = 11,
                    ExerciseId = 2,
                    Date = today.AddDays(-20),
                    UserId = user.Id,
                    Time = 4500
                },
                new UserExercise
                {
                    UserExerciseId = 12,
                    ExerciseId = 28,
                    Date = today.AddDays(-25),
                    UserId = user.Id,
                    Time = 10000
                },
                new UserExercise
                {
                    UserExerciseId = 13,
                    ExerciseId = 1,
                    Date = today.AddDays(-28),
                    UserId = user.Id,
                    Time = 10000
                },
                new UserExercise
                {
                    UserExerciseId = 14,
                    ExerciseId = 2,
                    Date = today.AddDays(-29),
                    UserId = user.Id,
                    Time = 8000
                },
                new UserExercise
                {
                    UserExerciseId = 15,
                    ExerciseId = 28,
                    Date = today.AddDays(1),
                    UserId = user.Id,
                    Time = 10000
                },
                new UserExercise
                {
                    UserExerciseId = 16,
                    ExerciseId = 1,
                    Date = today.AddDays(2),
                    UserId = user.Id,
                    Time = 10000
                },
                new UserExercise
                {
                    UserExerciseId = 17,
                    ExerciseId = 2,
                    Date = today.AddDays(3),
                    UserId = user.Id,
                    Time = 8000
                }
            );
            #endregion

        }
    }
}
