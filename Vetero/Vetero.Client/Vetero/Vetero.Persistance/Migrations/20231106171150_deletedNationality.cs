using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class deletedNationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nationality",
                schema: "Vetero",
                table: "Users",
                newName: "City");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "City",
                schema: "Vetero",
                table: "Users",
                newName: "Nationality");
        }
    }
}
