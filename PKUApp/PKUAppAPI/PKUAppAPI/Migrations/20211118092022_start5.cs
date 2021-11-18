using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class start5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "802287bb-6ea6-46eb-bb07-b588d17a2004", "AQAAAAEAACcQAAAAEM5YTh8KHe8s0qhj4I2Btz1AQnryzhEt5U3TeQNHHG+sh06WsDo/EY6FVcjTZGH6KQ==", "7f12804a-0159-4935-acb9-762eb110ad3e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb978aeb-ecdb-4b32-9d37-2221a0fbbc2f", "AQAAAAEAACcQAAAAEJlUo9wvMe6ra4R8UaEqKpChDGWvu8bATSEUPz0g7M5VqzcWhFkpB0LsUigjGb0dew==", "50432f4f-a832-4476-bb5a-d12c4952e658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a1f4a09-aea6-46a6-bcf7-3c27a7e9e4e8", "AQAAAAEAACcQAAAAELrRe44FszsWRdqfv3FXE+swTbUgxDlvoENqh5GEYhLHGlU6cMi417Pnkb0P25TVBg==", "d4a375db-bc11-423b-89a7-abc40450ba61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "609b4c61-4692-4ecd-b98d-46b81333a8f7", "AQAAAAEAACcQAAAAEA893zwSsGryjix4cyQ1GWUYZYDmUaCIcM9prUrEzX6vcbOY/SXL3iYtE25uyQ2c3A==", "9b34e598-6d42-4314-a9f3-63b0e25cec3a" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 26,
                column: "Date",
                value: new DateTime(2021, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 27,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 28,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 29,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 30,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 31,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 32,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 33,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 34,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 35,
                column: "Date",
                value: new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "MealId",
                keyValue: 36,
                column: "Date",
                value: new DateTime(2021, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 101,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 102,
                column: "Date",
                value: new DateTime(2021, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 103,
                column: "Date",
                value: new DateTime(2021, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 104,
                column: "Date",
                value: new DateTime(2021, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 105,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 106,
                column: "Date",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 107,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 108,
                column: "Date",
                value: new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 109,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "TrackedValues",
                keyColumn: "TrackedValueId",
                keyValue: 110,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2021, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2021, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2021, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2021, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2021, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserExercises",
                keyColumn: "UserExerciseId",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2021, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 1,
                column: "StartDate",
                value: new DateTime(2021, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2021, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "UserMedicines",
                keyColumn: "UserMedicineId",
                keyValue: 22,
                column: "StartDate",
                value: new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UserOffAlerts",
                keyColumn: "UserOffAlertId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2021, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b228181-0586-4305-a38a-7dc72a6e8263", "AQAAAAEAACcQAAAAECxmmA35RiEftMaPOh1Z9VCep/hgnnGi8BGtXFwletTHP66fdKqlnkJbI3hQ2Y7wNA==", "8542394d-eb3e-4f05-aa99-06858c43072e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92e89e24-85e9-4e33-96ba-5ea0f4f57a88", "AQAAAAEAACcQAAAAEOW+3TdRJ52aqeNi0O8SZTJ3xGTbXbzd9tLbn+8QvXgjxZQTzi8x/85f+g0h1HPAUw==", "0e55942f-f369-484e-869d-b45e03b7f3e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c460db9-5db1-4aa4-9aa6-d2271e24c2f9", "AQAAAAEAACcQAAAAELqArhOk8p2bKIFTTaEokFDluNXCBJXiepcpdYOgFvCAxCpxkqKIHpM0gMfeQ0GMQw==", "b86f38d7-fa6b-454f-a3cb-97442eee1a3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7d0554c-8e3f-4b22-883d-9ca45ae99d11", "AQAAAAEAACcQAAAAEIGjLNI8VTZ4af+6ajRzcZ5SXkIDcc2TO+hQMGuDsupRSOFPHS6ElaiYJF/FPvl/iw==", "49bcda4e-510a-4109-8434-13611122cb88" });

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
    }
}
