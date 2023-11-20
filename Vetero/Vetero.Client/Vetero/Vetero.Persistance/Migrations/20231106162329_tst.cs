using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class tst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "User" });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Manager" });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Vetero",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "Vetero",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "Vetero",
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
