using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class InitialRoleSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d7d8e6e-6876-4158-9de6-b55e38e86148", "e9acfbe3-9629-4244-98de-b3f5d4f717c0", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d7d8e6e-6876-4158-9de6-b55e38e86148");
        }
    }
}
