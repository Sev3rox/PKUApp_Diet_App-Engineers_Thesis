using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e3665f5-5d71-442a-8885-ce89185c90ca", "AQAAAAEAACcQAAAAEAonj5rtRKxCrRsoc6FgpOUpGEvr52XGskE4EPlv3x/diepTpxhh0rdanZHoFFLm7Q==", "817d7154-bb14-4038-a017-d0a478ed7529" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21650bc7-5db5-48e5-8779-f6192cfb4f7f", "AQAAAAEAACcQAAAAEGA4v+JWXCBUxidqDt8kMWJhmNV17hx61TPXtbjHthn75uqvfqq0DKSah6xA/hTH5w==", "03b4d65a-0e0c-4bc7-83b2-d33a7d8a5d53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30abf619-fc3b-4d42-b7c5-4001fda66168", "AQAAAAEAACcQAAAAEO5EU3N3zJhjilhLtvdMhpjlDFScaRyUgufGKeJWpgTI5DbOogZlileXUHhUhhoBDw==", "af87e72b-ece2-4c00-89e8-04a6ed04b05e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6622743c-5eea-4e0d-a1c3-f194679ac153", "AQAAAAEAACcQAAAAEDX8xEkE4whIpD0tVr01tT02LrovLXoje+2dpS+qRvdxU5c5KP74CuOApQ6VHonK/g==", "1c938727-1bcb-48ef-b784-d79f65eeddcb" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2021, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2021, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 22,
                column: "StartDate",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30000ff4-6c88-40db-b7f9-a454cadc702b", "AQAAAAEAACcQAAAAEM/5Gn6UPRhNx+rMkkuN47jzEirWzOqlDttipkGaZXOfAvPns1CUBqh1mEFe0JsIbA==", "3986a0b5-e0b7-4524-8a2a-59d2eec44b59" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa15560d-dce2-492e-9112-636157ccdbaf", "AQAAAAEAACcQAAAAEFk9QN1tZ9wRpBlyKHBB3LbFER4TJ24U+4lKMjwBHFrCI4Cn+ZlbVqg+5Ayl3WkgEA==", "f1f4ef86-9f7f-4223-ad91-e32f7de7d837" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18357373-1618-44fe-a020-4d8172650250", "AQAAAAEAACcQAAAAEDKEwLjBwfV06htfGIiLDTUvlfuCIsaAVpApINMjIH6uc2IjUY1uQt4g6ii54eGBgQ==", "cc49661c-6fcf-479f-baa7-84da95c9752a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc752587-177e-4445-8942-7d6d441b264e", "AQAAAAEAACcQAAAAED0gRk1uJvm4ukkq8+MW1kpuhCn4aWGo7TnWPEIlGiloWT0DHvuUOB1SY4BXS2Chrw==", "c94d8b2b-2a78-4c48-8c62-76275c7da00c" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 22,
                column: "StartDate",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
