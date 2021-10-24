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

            var admin = new User { Email = "a@a", Name="Admin", UserName="a@a", NormalizedUserName="A@A", NormalizedEmail="A@A", LockoutEnabled=true};
            var user = new User { Email = "u@u", Name = "User", UserName = "u@u", NormalizedUserName = "U@U", NormalizedEmail = "U@U", LockoutEnabled = true };
            var user2 = new User { Email = "u@u2", Name = "User2", UserName = "u@u2", NormalizedUserName = "U@U2", NormalizedEmail = "U@U2", LockoutEnabled = true };
            var user3 = new User { Email = "u@u3", Name = "User3", UserName = "u@u3", NormalizedUserName = "U@U3", NormalizedEmail = "U@U3", LockoutEnabled = true };
            hashed = password.HashPassword(admin,"123456");
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

            //categories    "Fruits","Vegetables","Dairy","Grains","Protein Foods","Drinks","Snacks","Dishes","Other"
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Apple",
                    Category = "Frutis",
                    Phe = 600,
                    Calories = 5200,
                    Protein=30,
                    Fat = 0,
                    Carb = 1400
                },
             //User's products
                new Product
                {
                    ProductId = 101,
                    Name = "Raspberries",
                    Category = "Frutis",
                    Phe = 3000,
                    Calories = 4900,
                    Protein=90,
                    Fat = 100,
                    Carb = 1200,
                    UserId=user.Id
                }
            );
            #endregion

            //Meals
            #region Meals

            var today=DateTime.Today;
            today = new DateTime(today.Year, today.Month, today.Day);

            //Meal names  "First Meal","Second Meal","Third Meal","Fourth Meal","Fifth Meal","Sixth Meal","Seventh Meal","Eighth Meal","Ninth Meal","Tenth Meal"
            modelBuilder.Entity<Meal>().HasData(
                //user1    meals
                new Meal
                {
                    MealId=1,
                    Name= "First Meal",
                    Date=today,
                    UserId=user.Id
                },
                new Meal
                {
                    MealId=2,
                    Name= "First Meal",
                    Date=today.AddDays(-1),
                    UserId=user.Id
                }
            );
            #endregion

            //UserProductFavs
            #region UserProductFavs
            modelBuilder.Entity<UserProductFav>().HasData(
                new UserProductFav
                {
                    UserId=user.Id,
                    ProductId=1
                },
                new UserProductFav
                {
                    UserId=user.Id,
                    ProductId=101
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
                    ProductId = 1,
                    Weight = 10000
                },
                //meal 2
                new MealProduct
                {
                    MealId = 2,
                    ProductId = 1,
                    Weight = 20000
                }
            );
            #endregion

            //UserProductLastAddeds
            #region UserProductLastAddeds
                modelBuilder.Entity<UserProductLastAdded>().HasData(
                //user1 last
                new UserProductLastAdded
                {
                    UserId=user.Id,
                    ProductId=1
                },
                new UserProductLastAdded
                {
                    UserId=user.Id,
                    ProductId=101
                }
            );
            #endregion

            //UserProductDish
            #region UserProductDish
                modelBuilder.Entity<UserProductDish>().HasData(
                //user1 dish
                new UserProductDish
                {
                    UserId=user.Id,
                    ProductId=1,
                    Weight=15000
                },
                new UserProductDish
                {
                    UserId=user.Id,
                    ProductId=101,
                    Weight=5000
                }
            );
            #endregion

            //UserDailyLimits
            #region UserDailyLimits
            modelBuilder.Entity<UserDailyLimits>().HasData(
                new UserDailyLimits { UserDailyLimitsId = 1, UserId = user.Id, PheLimit = 100000, CaloriesLimit =240000, ProteinLimit=16000, FatLimit=12000, CarbLimit = 15000 },
                new UserDailyLimits { UserDailyLimitsId = 2, UserId = user2.Id },
                new UserDailyLimits { UserDailyLimitsId = 3, UserId = user3.Id }
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
                    UserOffAlertId=2,
                    UserId=user.Id,
                    Date=today.AddDays(2)
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
                //user2 med
                new UserMedicine
                {
                    UserMedicineId = 2,
                    StartDate=today.AddDays(-3),
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
                    Date=today,
                    UserId=user.Id,
                    Type=2,
                    Value=980
                },
                //user1 TrackedValues weight
                new TrackedValue
                {
                    TrackedValueId = 2,
                    Date = today,
                    UserId = user.Id,
                    Type = 1,
                    Value = 10600
                }
            );
            #endregion

            //Exercises
            #region Exercises
             modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    ExerciseId=1,
                    Name="Running",
                    Calories=45000
                },
                new Exercise
                {
                    ExerciseId = 2,
                    Name = "Swimming",
                    Calories = 90000
                }
            );
            #endregion

            //UserExercises
            #region UserExercises
            modelBuilder.Entity<UserExercise>().HasData(
                //user1   exercises
                new UserExercise
                {
                    UserExerciseId=1,
                    ExerciseId=1,
                    Date=today,
                    UserId=user.Id,
                    Time=3000
                },
                new UserExercise
                {
                    UserExerciseId = 2,
                    ExerciseId = 2,
                    Date = today.AddDays(-1),
                    UserId = user.Id,
                    Time = 4500
                }
            );
            #endregion

        }
    }
}
