using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class userexemodelchangev24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserExercises_AspNetUsers_UserId",
                table: "UserExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExercises",
                table: "UserExercises");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserExercises",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "UserExerciseId",
                table: "UserExercises",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExercises",
                table: "UserExercises",
                column: "UserExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserExercises_UserId",
                table: "UserExercises",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercises_AspNetUsers_UserId",
                table: "UserExercises",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserExercises_AspNetUsers_UserId",
                table: "UserExercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserExercises",
                table: "UserExercises");

            migrationBuilder.DropIndex(
                name: "IX_UserExercises_UserId",
                table: "UserExercises");

            migrationBuilder.DropColumn(
                name: "UserExerciseId",
                table: "UserExercises");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserExercises",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserExercises",
                table: "UserExercises",
                columns: new[] { "UserId", "ExerciseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_UserExercises_AspNetUsers_UserId",
                table: "UserExercises",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
