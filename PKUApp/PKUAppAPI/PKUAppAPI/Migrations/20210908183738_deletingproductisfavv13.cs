using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class deletingproductisfavv13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isFav",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isFav",
                table: "Products",
                type: "bit",
                nullable: true);
        }
    }
}
