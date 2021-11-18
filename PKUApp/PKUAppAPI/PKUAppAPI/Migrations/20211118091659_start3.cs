using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class start3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46ad44f4-c682-4c31-8f04-b364d516a8ed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e83fe879-8233-4c5b-bafe-bb64d5840e33", "AQAAAAEAACcQAAAAEKcQDNCeXTfsgg1MDradmQRanNcxAjW9466Mg8wYZhjzZ/vpdpU2HJXLtKcnuACuyg==", "2242630f-fa81-4ba6-a86a-7bbe85c8dac4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b48b45-fb38-431c-a8a1-6b3524e147a7", "AQAAAAEAACcQAAAAEA4VyWPvPSjTvMB9v6msGSjtF259//ncfmKy61fh7d0vUSFva0MJgopB4G1pulkuPw==", "2cccef8d-ec17-4f80-bfd0-101f66e261a1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c86f5a1f-3d79-4f67-b895-5dfcb9b73a9f", "AQAAAAEAACcQAAAAEOtPrjzj3pQaZSWx6g/gXcbkYkMOHU5uOlbwRs7DFUm3Cq3Ueh1AvJePeJam+QiLfQ==", "6ea09873-3d7b-4809-9004-8e1989e5be53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "597ad3b1-93fa-4975-8ee1-37e136e6994f", "AQAAAAEAACcQAAAAEPp04tifVL1wZzo5oi+DpVb39DanSKlKujz6IeiyORLwB+/Py1B7iQTXfd5XiyKlAQ==", "af05e7df-1813-45c9-b595-566e7715102b" });

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
                values: new object[] { "ba56adb2-a0ed-41de-a63a-7c7a8da50d16", "AQAAAAEAACcQAAAAEAzjV1J6e9+//utGCUmbOquPI+Lyi028If47ehP/UfU4WOg32LcnjOjBL60pVjTOcQ==", "1b44f3f8-87ce-42aa-9dc9-9f1d58d973f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "483f0b30-9dbf-4fc0-b66a-4bc1642c4957",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1abcab14-601c-4ca9-af1e-dea4ce782d30", "AQAAAAEAACcQAAAAEMc4f3S55jvsXrep9Knr+6RCRiyQkgt7/vPerHQWUQE6V41zCHR1b5vXAv7ozzg9uA==", "56a5d6ee-f62b-42c0-a29f-1d3029980780" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b40c12be-c3bc-4765-80ca-2f637e603f8a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de2b8972-2ed1-4982-a7a7-fc9500c10abf", "AQAAAAEAACcQAAAAEAe20sF5KBK0xFZFeDLpT59GoBPEIgneig0hxNOVBocPsJ64OvDkYBrYZIbcfdzqKQ==", "6cc4c496-02b1-443d-a02d-f5f3e2ce6dc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d318a720-1017-4703-98cf-44954069d6e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41080b2f-31be-403f-a33b-9455e69acdf6", "AQAAAAEAACcQAAAAED2yVO5SlkFZYV6mvGFbtnWglN6hTCTnfa6ZJ3XLSpkXnvRab0h3Aw9IcW/AlKX/KA==", "e2a49056-48a6-42df-947c-12e4482df58c" });

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
    }
}
