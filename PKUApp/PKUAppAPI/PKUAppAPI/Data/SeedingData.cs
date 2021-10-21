using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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

            #endregion

            //Products
            #region Products

            #endregion

            //Meals
            #region Meals

            #endregion

            //UserProductFavs
            #region UserProductFavs

            #endregion

            // MealProducts
            #region MealProducts

            #endregion

            //UserProductLastAddeds
            #region UserProductLastAddeds

            #endregion

            //UserProductDish
            #region UserProductDish

            #endregion

            //UserDailyLimits
            #region UserDailyLimits
            modelBuilder.Entity<UserDailyLimits>().HasData(
                new UserDailyLimits { UserDailyLimitsId = 1, UserId = user.Id },
                new UserDailyLimits { UserDailyLimitsId = 2, UserId = user2.Id },
                new UserDailyLimits { UserDailyLimitsId = 3, UserId = user3.Id }
                );
            #endregion

            //UserOffAlerts
            #region UserOffAlerts

            #endregion

            //UserMedicines
            #region UserMedicines

            #endregion

            //TrackedValues
            #region TrackedValues

            #endregion

            //Exercises
            #region Exercises

            #endregion

            //UserExercises
            #region UserExercises

            #endregion

        }
    }
}
