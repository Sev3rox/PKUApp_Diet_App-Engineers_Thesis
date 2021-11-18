using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class start4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
