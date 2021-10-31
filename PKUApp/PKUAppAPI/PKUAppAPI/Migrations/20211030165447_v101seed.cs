using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class v101seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "04552528-8283-4b70-9718-26721ccb8a31" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cb24fec-9d0b-488a-8b06-e51deca24685");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9863e18f-4f1b-4471-b7c4-df3c3bbb014e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04552528-8283-4b70-9718-26721ccb8a31");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b40c12be-c3bc-4765-80ca-2f637e603f8a", 0, "18357373-1618-44fe-a020-4d8172650250", "u@u3", false, true, null, "User3", "U@U3", "U@U3", "AQAAAAEAACcQAAAAEDKEwLjBwfV06htfGIiLDTUvlfuCIsaAVpApINMjIH6uc2IjUY1uQt4g6ii54eGBgQ==", null, false, "cc49661c-6fcf-479f-baa7-84da95c9752a", false, "u@u3" },
                    { "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0, "fa15560d-dce2-492e-9112-636157ccdbaf", "u@u", false, true, null, "User", "U@U", "U@U", "AQAAAAEAACcQAAAAEFk9QN1tZ9wRpBlyKHBB3LbFER4TJ24U+4lKMjwBHFrCI4Cn+ZlbVqg+5Ayl3WkgEA==", null, false, "f1f4ef86-9f7f-4223-ad91-e32f7de7d837", false, "u@u" },
                    { "d318a720-1017-4703-98cf-44954069d6e5", 0, "dc752587-177e-4445-8942-7d6d441b264e", "a@a", false, true, null, "Admin", "A@A", "A@A", "AQAAAAEAACcQAAAAED0gRk1uJvm4ukkq8+MW1kpuhCn4aWGo7TnWPEIlGiloWT0DHvuUOB1SY4BXS2Chrw==", null, false, "c94d8b2b-2a78-4c48-8c62-76275c7da00c", false, "a@a" },
                    { "46ad44f4-c682-4c31-8f04-b364d516a8ed", 0, "30000ff4-6c88-40db-b7f9-a454cadc702b", "u@u2", false, true, null, "User2", "U@U2", "U@U2", "AQAAAAEAACcQAAAAEM/5Gn6UPRhNx+rMkkuN47jzEirWzOqlDttipkGaZXOfAvPns1CUBqh1mEFe0JsIbA==", null, false, "3986a0b5-e0b7-4524-8a2a-59d2eec44b59", false, "u@u2" }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Calories", "Name" },
                values: new object[,]
                {
                    { 23, 28500, "Tennis" },
                    { 24, 21500, "Table Tennis" },
                    { 25, 14000, "Frisbee" },
                    { 26, 22000, "Valleyball" },
                    { 27, 50000, "Beach Valleyball" },
                    { 28, 25000, "Basketball" },
                    { 29, 36000, "Cheerleading" },
                    { 31, 50000, "Handball" },
                    { 22, 45000, "Squash" },
                    { 32, 50000, "Hockey" },
                    { 33, 43000, "Football" },
                    { 34, 27000, "Cricket" },
                    { 35, 38000, "Rugby" },
                    { 36, 25000, "Baseball" },
                    { 30, 50000, "Lacrosse" },
                    { 21, 50000, "Polo" },
                    { 1, 45000, "Running" },
                    { 19, 32000, "Skating" },
                    { 4, 48000, "Dance" },
                    { 20, 41500, "Ski Touring" },
                    { 3, 41500, "Road Biking" },
                    { 2, 90000, "Swimming" },
                    { 6, 14000, "Walking" },
                    { 7, 58000, "Stair Treadmill" },
                    { 8, 18000, "Stationary Cycling" },
                    { 9, 9000, "Stretching" },
                    { 5, 56000, "Jumping Rope" },
                    { 11, 14000, "Treadmill Walking" },
                    { 12, 24000, "Circuit Training" },
                    { 13, 13000, "Exercise Ball" },
                    { 14, 16000, "Sailing" },
                    { 15, 32000, "Badminton" },
                    { 16, 18000, "Golf" },
                    { 10, 13000, "Calisthenics" },
                    { 18, 43000, "Roller Skating" },
                    { 17, 20000, "Gymnastics" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Calories", "Carb", "Category", "Fat", "Name", "Phe", "Protein", "UserId" },
                values: new object[,]
                {
                    { 37, 49200, 6400, "Snacks", 2300, "Crackers", 33000, 720, null },
                    { 36, 49600, 5800, "Snacks", 2700, "Potato Chips", 38800, 850, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Calories", "Carb", "Category", "Fat", "Name", "Phe", "Protein", "UserId" },
                values: new object[,]
                {
                    { 35, 59900, 1500, "Snacks", 5300, "Roasted Peanuts", 142700, 2800, null },
                    { 32, 3900, 950, "Drinks", 0, "Sprite", 0, 0, null },
                    { 33, 28000, 3900, "Snacks", 1200, "Fries", 14600, 320, null },
                    { 31, 4100, 1000, "Drinks", 0, "Cola", 0, 0, null },
                    { 30, 63200, 0, "Protein Foods", 6600, "Pork", 38400, 930, null },
                    { 38, 29100, 3200, "Dishes", 1300, "Pepperoni Pizza", 61200, 1220, null },
                    { 34, 29500, 4100, "Snacks", 1800, "Chips", 17600, 300, null },
                    { 39, 26600, 3300, "Dishes", 1000, "Cheese Pizza", 66400, 1150, null },
                    { 47, 0, 0, "Other", 0, "Salt", 0, 0, null },
                    { 41, 26100, 2700, "Dishes", 1100, "Hamburger", 62400, 1490, null },
                    { 42, 13500, 1500, "Dishes", 500, "Lasagne", 32900, 730, null },
                    { 43, 24700, 1800, "Dishes", 1500, "Hotdog", 41700, 1060, null },
                    { 44, 11200, 2600, "Other", 0, "Ketchup", 2600, 130, null },
                    { 45, 6700, 500, "Other", 400, "Mustard", 16700, 440, null },
                    { 46, 72100, 0, "Other", 7900, "Mayonnaise", 15400, 100, null },
                    { 29, 23700, 0, "Protein Foods", 1200, "Beff", 119000, 3040, null },
                    { 48, 3100, 600, "Vegetables", 0, "Red Pepper", 3300, 100, null },
                    { 49, 26300, 200, "Protein Foods", 2100, "Ham", 64100, 1630, null },
                    { 50, 4000, 900, "Vegetables", 0, "Onions", 2500, 110, null },
                    { 40, 28600, 2400, "Dishes", 1500, "Cheeseburger", 66000, 1460, null },
                    { 28, 14500, 400, "Protein Foods", 900, "Tofu", 76800, 1600, null },
                    { 20, 4500, 1000, "Drinks", 0, "Orange Juice", 900, 70, null },
                    { 26, 35900, 0, "Protein Foods", 2900, "Lamb", 86000, 2200, null },
                    { 1, 5200, 1400, "Fruits", 0, "Apple", 600, 30, null },
                    { 2, 14300, 100, "Protein Foods", 1000, "Egg", 68000, 1260, null },
                    { 3, 6300, 1600, "Fruits", 0, "Orange", 4300, 130, null },
                    { 4, 27000, 4900, "Grains", 300, "Wheat Bread", 26500, 1040, null },
                    { 5, 8900, 2300, "Fruits", 0, "Bananas", 4900, 110, null },
                    { 6, 6100, 500, "Dairy", 300, "Milk 3.2%", 16300, 320, null },
                    { 7, 38900, 10000, "Other", 0, "Sugar", 0, 0, null },
                    { 8, 1600, 300, "Vegetables", 0, "Tomatoes", 3000, 120, null },
                    { 10, 8600, 2000, "Vegetables", 0, "Potatoes", 7600, 170, null },
                    { 11, 1500, 300, "Vegetables", 0, "Lettuce", 5500, 140, null },
                    { 12, 26300, 1500, "Protein Foods", 1600, "Chicken Breast", 52500, 1470, null },
                    { 13, 40300, 100, "Dairy", 3300, "Cheddar Cheese", 131100, 2500, null },
                    { 14, 16000, 900, "Fruits", 1500, "Avocados", 9700, 200, null },
                    { 15, 3400, 700, "Vegetables", 0, "Broccoli", 11700, 280, null },
                    { 16, 1200, 200, "Vegetables", 0, "Cucumber", 3100, 60, null },
                    { 17, 88400, 0, "Other", 10000, "Olive", 0, 0, null },
                    { 18, 0, 0, "Drinks", 0, "Water", 0, 0, null },
                    { 19, 4700, 120, "Drinks", 0, "Apple Juice", 100, 10, null },
                    { 21, 6300, 700, "Dairy", 200, "Yogurt", 28600, 530, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Calories", "Carb", "Category", "Fat", "Name", "Phe", "Protein", "UserId" },
                values: new object[,]
                {
                    { 22, 71700, 0, "Dairy", 8100, "Butter", 4100, 90, null },
                    { 23, 13000, 2400, "Grains", 200, "Pasta", 28200, 530, null },
                    { 24, 40600, 4600, "Grains", 2100, "Croissant", 41600, 820, null },
                    { 25, 23800, 200, "Protein Foods", 1900, "Salami", 45100, 1420, null },
                    { 27, 19800, 0, "Protein Foods", 800, "Tuna", 1137, 2910, null },
                    { 9, 37000, 8200, "Grains", 100, "Rice", 36400, 680, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "d318a720-1017-4703-98cf-44954069d6e5" });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "MealId", "Date", "Name", "UserId" },
                values: new object[,]
                {
                    { 21, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 22, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 23, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 24, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 25, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 27, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 28, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 29, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 30, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 31, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 32, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 33, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 34, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 35, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 36, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 20, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 19, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 26, new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 17, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Fourth Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 18, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 2, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 3, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 4, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 5, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 6, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 7, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 8, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 1, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 10, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 11, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 12, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 13, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 14, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 15, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Second Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 16, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Third Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 9, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "First Meal", "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Calories", "Carb", "Category", "Fat", "Name", "Phe", "Protein", "UserId" },
                values: new object[,]
                {
                    { 107, 30000, 0, "Dairy", 2400, "Camembert", 110500, 1980, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 106, 3700, 800, "Other", 0, "Enoki", 1500, 270, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 104, 18000, 600, "Dishes", 600, "Meatballs", 14800, 1100, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 105, 4100, 1000, "Vegetables", 0, "Carrots", 6100, 90, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 102, 6700, 1700, "Frutis", 0, "Grapes", 1300, 60, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Calories", "Carb", "Category", "Fat", "Name", "Phe", "Protein", "UserId" },
                values: new object[,]
                {
                    { 101, 4900, 1200, "Frutis", 100, "Raspberries", 3000, 90, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 103, 4300, 1100, "Drinks", 0, "Fanta", 0, 0, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "TrackedValues",
                columns: new[] { "TrackedValueId", "Date", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { 102, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 1060 },
                    { 110, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10870 },
                    { 109, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10800 },
                    { 108, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10750 },
                    { 107, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10740 },
                    { 106, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10710 },
                    { 105, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10700 },
                    { 104, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10720 },
                    { 103, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10690 },
                    { 101, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10600 },
                    { 9, new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 870 },
                    { 8, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 900 },
                    { 7, new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 930 },
                    { 6, new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 880 },
                    { 5, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 900 },
                    { 4, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 970 },
                    { 3, new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 930 },
                    { 2, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 960 },
                    { 1, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 980 },
                    { 10, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 850 }
                });

            migrationBuilder.InsertData(
                table: "UserDailyLimits",
                columns: new[] { "CaloriesLimit", "CarbLimit", "FatLimit", "PheLimit", "ProteinLimit", "UserId", "AddCalories" },
                values: new object[] { 240000, 15000, 12000, 100000, 16000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", true });

            migrationBuilder.InsertData(
                table: "UserDailyLimits",
                columns: new[] { "CaloriesLimit", "CarbLimit", "FatLimit", "PheLimit", "ProteinLimit", "UserId" },
                values: new object[] { 0, 0, 0, 0, 0, "46ad44f4-c682-4c31-8f04-b364d516a8ed" });

            migrationBuilder.InsertData(
                table: "UserDailyLimits",
                columns: new[] { "CaloriesLimit", "CarbLimit", "FatLimit", "PheLimit", "ProteinLimit", "UserId" },
                values: new object[] { 0, 0, 0, 0, 0, "b40c12be-c3bc-4765-80ca-2f637e603f8a" });


            migrationBuilder.InsertData(
                table: "UserExercises",
                columns: new[] { "UserExerciseId", "Date", "ExerciseId", "Time", "UserId" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 1, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 3, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 17, new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 2, new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4500, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 15, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 10000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 14, new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 8000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 13, new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 16, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 10000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 11, new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4500, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 10, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 4000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 9, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 12000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 8, new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4500, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 7, new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4500, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 6, new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 9000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 5, new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 12, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, 10000, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "UserMedicines",
                columns: new[] { "UserMedicineId", "Calories", "Carb", "EndDate", "Fat", "Phe", "Protein", "StartDate", "UserId" },
                values: new object[,]
                {
                    { 1, 5200, 3400, null, 1800, 1200, 3000, new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 2, 5000, 3800, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1700, 1500, 3400, new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 3, 5300, 3500, new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1900, 1100, 3200, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 22, 4200, 4400, null, 2800, 1000, 3600, new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "UserOffAlerts",
                columns: new[] { "UserOffAlertId", "Date", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 2, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "UserProductDish",
                columns: new[] { "ProductId", "UserId", "Weight" },
                values: new object[,]
                {
                    { 14, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 7500 },
                    { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 15000 },
                    { 5, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 10000 }
                });

            migrationBuilder.InsertData(
                table: "UserProductFavs",
                columns: new[] { "ProductId", "UserId" },
                values: new object[,]
                {
                    { 8, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 12, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 47, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 32, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 4, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 17, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "UserProductLastAddeds",
                columns: new[] { "ProductId", "UserId", "Order" },
                values: new object[,]
                {
                    { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 10, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 11, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 34, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 41, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "MealId", "ProductId", "Weight" },
                values: new object[,]
                {
                    { 1, 38, 45000 },
                    { 29, 21, 20000 },
                    { 28, 43, 30000 },
                    { 27, 24, 18000 },
                    { 27, 31, 15000 },
                    { 26, 31, 18000 },
                    { 26, 41, 25000 },
                    { 30, 31, 15000 },
                    { 25, 49, 10000 },
                    { 25, 4, 18000 },
                    { 24, 10, 35000 },
                    { 24, 50, 8000 },
                    { 24, 6, 20000 },
                    { 23, 107, 10000 },
                    { 22, 38, 45000 },
                    { 25, 46, 3000 },
                    { 21, 36, 15000 },
                    { 30, 24, 18000 },
                    { 31, 24, 18000 },
                    { 13, 107, 10000 },
                    { 21, 105, 5000 },
                    { 12, 105, 5000 },
                    { 29, 101, 10000 },
                    { 9, 101, 10000 },
                    { 36, 43, 30000 },
                    { 31, 31, 15000 },
                    { 35, 12, 25000 },
                    { 34, 37, 15000 },
                    { 33, 24, 18000 },
                    { 33, 31, 15000 },
                    { 32, 49, 10000 },
                    { 32, 46, 3000 },
                    { 32, 4, 18000 },
                    { 35, 2, 20000 },
                    { 21, 28, 8000 },
                    { 23, 37, 15000 },
                    { 20, 31, 15000 },
                    { 9, 21, 20000 },
                    { 20, 24, 18000 },
                    { 8, 50, 8000 },
                    { 8, 6, 20000 },
                    { 7, 42, 36000 }
                });

            migrationBuilder.InsertData(
                table: "MealProducts",
                columns: new[] { "MealId", "ProductId", "Weight" },
                values: new object[,]
                {
                    { 6, 5, 10000 },
                    { 10, 33, 25000 },
                    { 6, 3, 10000 },
                    { 5, 12, 25000 },
                    { 5, 2, 20000 },
                    { 4, 4, 25000 },
                    { 4, 25, 15000 },
                    { 3, 43, 30000 },
                    { 2, 40, 25000 },
                    { 6, 1, 10000 },
                    { 10, 32, 20000 },
                    { 8, 10, 35000 },
                    { 12, 28, 8000 },
                    { 19, 32, 5000 },
                    { 19, 40, 25000 },
                    { 18, 32, 5000 },
                    { 11, 39, 35000 },
                    { 17, 40, 28000 },
                    { 16, 49, 10000 },
                    { 16, 46, 3000 },
                    { 18, 40, 25000 },
                    { 15, 31, 18000 },
                    { 15, 41, 25000 },
                    { 14, 24, 18000 },
                    { 14, 31, 15000 },
                    { 13, 37, 15000 },
                    { 12, 36, 15000 },
                    { 16, 4, 18000 },
                    { 34, 107, 10000 }
                });

            migrationBuilder.InsertData(
                table: "UserProductDish",
                columns: new[] { "ProductId", "UserId", "Weight" },
                values: new object[,]
                {
                    { 101, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 5000 },
                    { 102, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 5000 }
                });

            migrationBuilder.InsertData(
                table: "UserProductFavs",
                columns: new[] { "ProductId", "UserId" },
                values: new object[,]
                {
                    { 103, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" },
                    { 105, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" }
                });

            migrationBuilder.InsertData(
                table: "UserProductLastAddeds",
                columns: new[] { "ProductId", "UserId", "Order" },
                values: new object[,]
                {
                    { 101, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 103, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 },
                    { 106, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957", 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "d318a720-1017-4703-98cf-44954069d6e5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 2, 40 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 3, 43 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 4, 25 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 5, 12 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 7, 42 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 8, 6 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 8, 10 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 8, 50 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 9, 21 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 9, 101 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 10, 32 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 10, 33 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 11, 39 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 12, 28 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 12, 36 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 12, 105 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 13, 37 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 13, 107 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 14, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 14, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 15, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 15, 41 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 16, 4 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 16, 46 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 16, 49 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 17, 40 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 18, 32 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 18, 40 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 19, 32 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 19, 40 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 20, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 20, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 21, 28 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 21, 36 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 21, 105 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 22, 38 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 23, 37 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 23, 107 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 24, 6 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 24, 10 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 24, 50 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 25, 4 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 25, 46 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 25, 49 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 26, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 26, 41 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 27, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 27, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 28, 43 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 29, 21 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 29, 101 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 30, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 30, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 31, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 31, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 32, 4 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 32, 46 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 32, 49 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 33, 24 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 33, 31 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 34, 37 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 34, 107 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 35, 2 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 35, 12 });

            migrationBuilder.DeleteData(
                table: "MealProducts",
                keyColumns: new[] { "MealId", "ProductId" },
                keyValues: new object[] { 36, 43 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProductDish",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductDish",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 5, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductDish",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 14, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductDish",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 101, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductDish",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 102, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 4, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 8, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 12, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 17, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 32, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 47, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 103, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductFavs",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 105, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 1, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 10, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 11, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 34, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 41, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 101, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 103, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "UserProductLastAddeds",
                keyColumns: new[] { "ProductId", "UserId" },
                keyValues: new object[] { 106, "483f0b30-9dbf-4fc0-b66a-4bc1642c4957" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5");

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04552528-8283-4b70-9718-26721ccb8a31", 0, "75ba8dd7-9b56-4f1b-8446-98e89d2d9c0c", "a@a", false, true, null, "Admin", "A@A", "A@A", "AQAAAAEAACcQAAAAEBL4cOyqKAj9RrDhsSS8/d58jsvmIftRcR3+KEj4s5tBpDUrOPgNmzI2/o5lahLgoA==", null, false, "fe8f6f77-047b-4434-b39c-908a814caaf5", false, "a@a" },
                    { "9863e18f-4f1b-4471-b7c4-df3c3bbb014e", 0, "ad0e2677-effc-4629-83e0-b27045122523", "u@u", false, true, null, "User", "U@U", "U@U", "AQAAAAEAACcQAAAAED5Z2oF//G85jexywW6KOzoKYbSANSzWOHUNcFuXHZBL+lHcGoeawOaBB2Ym5F89XQ==", null, false, "c97c27fe-209e-4cab-9c2e-2ff785137f71", false, "u@u" },
                    { "3cb24fec-9d0b-488a-8b06-e51deca24685", 0, "00d323c4-6d5b-497c-b992-d26b50b259bb", "u@u2", false, true, null, "User2", "U@U2", "U@U2", "AQAAAAEAACcQAAAAEIzP4qy+DDEgu8vLJ+kLBNzfSjyuBmmgxlmQC8nXhPpyIJ6Sn2fCj8x3jyKv6/8Lzw==", null, false, "1f1471ec-0793-499d-9d19-9ff679720b20", false, "u@u2" },
                    { "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29", 0, "b97e46d5-640b-4d1a-9530-a0aa00d853f9", "u@u3", false, true, null, "User3", "U@U3", "U@U3", "AQAAAAEAACcQAAAAEAriJ/W6y6PSCkvkZ/SQ1mLbP0WYlY2UkgKxIAej58aquP+3m+XWedXAsCoEXEt6Rw==", null, false, "bc1468e9-7c6c-4a87-a778-4f0ca5a2696b", false, "u@u3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "04552528-8283-4b70-9718-26721ccb8a31" });

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 1,
                columns: new[] { "AddCalories", "CaloriesLimit", "CarbLimit", "FatLimit", "PheLimit", "ProteinLimit", "UserId" },
                values: new object[] { false, 0, 0, 0, 0, 0, "9863e18f-4f1b-4471-b7c4-df3c3bbb014e" });

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 2,
                column: "UserId",
                value: "3cb24fec-9d0b-488a-8b06-e51deca24685");

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 3,
                column: "UserId",
                value: "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29");
        }
    }
}
