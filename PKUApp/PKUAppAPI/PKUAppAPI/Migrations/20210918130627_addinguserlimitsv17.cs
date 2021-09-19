using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class addinguserlimitsv17 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDailyLimits",
                columns: table => new
                {
                    UserDailyLimitsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PheLimit = table.Column<int>(type: "int", nullable: false),
                    CaloriesLimit = table.Column<int>(type: "int", nullable: false),
                    ProteinLimit = table.Column<int>(type: "int", nullable: false),
                    FatLimit = table.Column<int>(type: "int", nullable: false),
                    CarbLimit = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDailyLimits", x => x.UserDailyLimitsId);
                    table.ForeignKey(
                        name: "FK_UserDailyLimits_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserDailyLimits_UserId",
                table: "UserDailyLimits",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDailyLimits");
        }
    }
}
