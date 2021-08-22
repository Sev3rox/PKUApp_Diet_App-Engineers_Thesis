using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class v5smallproductchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalFat",
                table: "Products",
                newName: "Fat");

            migrationBuilder.RenameColumn(
                name: "TotalCarb",
                table: "Products",
                newName: "Carb");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fat",
                table: "Products",
                newName: "TotalFat");

            migrationBuilder.RenameColumn(
                name: "Carb",
                table: "Products",
                newName: "TotalCarb");
        }
    }
}
