using Microsoft.EntityFrameworkCore.Migrations;

namespace PKUAppAPI.Migrations
{
    public partial class v100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c30785a5-5dd4-4303-b6ee-f21e154679eb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cba2cac7-a12a-4d3f-acfb-01fd62278377");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fbf0b4-2ee5-4790-b08f-65f729ded115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc47a809-0a95-4219-a1e4-a1a6691fd062");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "04552528-8283-4b70-9718-26721ccb8a31", 0, "75ba8dd7-9b56-4f1b-8446-98e89d2d9c0c", "a@a", false, true, null, "Admin", "A@A", "A@A", "AQAAAAEAACcQAAAAEBL4cOyqKAj9RrDhsSS8/d58jsvmIftRcR3+KEj4s5tBpDUrOPgNmzI2/o5lahLgoA==", null, false, "fe8f6f77-047b-4434-b39c-908a814caaf5", false, "a@a" },
                    { "9863e18f-4f1b-4471-b7c4-df3c3bbb014e", 0, "ad0e2677-effc-4629-83e0-b27045122523", "u@u", false, true, null, "User", "U@U", "U@U", "AQAAAAEAACcQAAAAED5Z2oF//G85jexywW6KOzoKYbSANSzWOHUNcFuXHZBL+lHcGoeawOaBB2Ym5F89XQ==", null, false, "c97c27fe-209e-4cab-9c2e-2ff785137f71", false, "u@u" },
                    { "3cb24fec-9d0b-488a-8b06-e51deca24685", 0, "00d323c4-6d5b-497c-b992-d26b50b259bb", "u@u2", false, true, null, "User2", "U@U2", "U@U2", "AQAAAAEAACcQAAAAEIzP4qy+DDEgu8vLJ+kLBNzfSjyuBmmgxlmQC8nXhPpyIJ6Sn2fCj8x3jyKv6/8Lzw==", null, false, "1f1471ec-0793-499d-9d19-9ff679720b20", false, "u@u2" },
                    { "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29", 0, "b97e46d5-640b-4d1a-9530-a0aa00d853f9", "u@u3", false, true, null, "User3", "U@U3", "U@U3", "AQAAAAEAACcQAAAAEAriJ/W6y6PSCkvkZ/SQ1mLbP0WYlY2UkgKxIAej58aquP+3m+XWedXAsCoEXEt6Rw==", null, false, "bc1468e9-7c6c-4a87-a778-4f0ca5a2696b", false, "u@u3" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "04552528-8283-4b70-9718-26721ccb8a31" });

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 1,
                column: "UserId",
                value: "9863e18f-4f1b-4471-b7c4-df3c3bbb014e");

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 2,
                column: "UserId",
                value: "3cb24fec-9d0b-488a-8b06-e51deca24685");

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 3,
                column: "UserId",
                value: "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8923e08e-d84a-4d9c-aa85-7f45e356c0ec", "04552528-8283-4b70-9718-26721ccb8a31" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cb24fec-9d0b-488a-8b06-e51deca24685");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9863e18f-4f1b-4471-b7c4-df3c3bbb014e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f2ba6f-c8d7-4dd8-83dd-02c3c213ce29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04552528-8283-4b70-9718-26721ccb8a31");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fc47a809-0a95-4219-a1e4-a1a6691fd062", 0, "e7ff9acf-8f25-4e37-b77f-ac8d5867c921", "a@a", false, true, null, "Admin", "A@A", "A@A", "AQAAAAEAACcQAAAAENawFML/bfclXH5AH3nPlW0R/pnHadOGDFZ7rfi8z1MalUiCc+VaxU2l+TDytBw3DQ==", null, false, "03036ae8-1945-4266-ab85-589409a61dbe", false, "a@a" },
                    { "f0fbf0b4-2ee5-4790-b08f-65f729ded115", 0, "5229f7e2-5b24-42a6-9834-f0f130e6e821", "u@u", false, true, null, "User", "U@U", "U@U", "AQAAAAEAACcQAAAAEGeVbjSxGWedmIaDQexL0Z0qpqRPSEf71JQsADyfIXIuCiDi/ifkOtArzFzpF/KSyQ==", null, false, "e11176c2-5af6-433b-bed0-f66ca4596042", false, "u@u" },
                    { "cba2cac7-a12a-4d3f-acfb-01fd62278377", 0, "0356bfe3-0d61-4f8e-9155-fd2aa0c492d0", "u@u2", false, true, null, "User2", "U@U2", "U@U2", "AQAAAAEAACcQAAAAEFxee2kU0Sj9Z3+JZIFeO4gzJPO0scYhuRTkQWiWNK8YJbEIjtW/C6KP+dpHZWvIVg==", null, false, "f78a5b7d-20c3-4a53-801c-65b6605cc8f3", false, "u@u2" },
                    { "c30785a5-5dd4-4303-b6ee-f21e154679eb", 0, "71cc0e1e-b5ca-4983-9f51-b9b1400a5e3f", "u@u3", false, true, null, "User3", "U@U3", "U@U3", "AQAAAAEAACcQAAAAEMQwMHy+HNeE2zpyfloUivtumSh1cHZwpDAELWxu880yB9Z8clZpKVGuKESi09G8lg==", null, false, "7cb0fe19-38ce-4ed0-ac3d-40f956c79393", false, "u@u3" }
                });

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 1,
                column: "UserId",
                value: "f0fbf0b4-2ee5-4790-b08f-65f729ded115");

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 2,
                column: "UserId",
                value: "cba2cac7-a12a-4d3f-acfb-01fd62278377");

            migrationBuilder.UpdateData(
                table: "UserDailyLimits",
                keyColumn: "UserDailyLimitsId",
                keyValue: 3,
                column: "UserId",
                value: "c30785a5-5dd4-4303-b6ee-f21e154679eb");
        }
    }
}
