using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class v3RegistrationChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4d7d8e6e-6876-4158-9de6-b55e38e86148");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "54c21f22-5773-49e3-bf10-03b6bb49af1d", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8923e08e-d84a-4d9c-aa85-7f45e356c0ec");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4d7d8e6e-6876-4158-9de6-b55e38e86148", "e9acfbe3-9629-4244-98de-b3f5d4f717c0", "Administrator", "ADMINISTRATOR" });
        }
    }
}
