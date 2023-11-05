using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class DeletePressureFromModel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pressure",
                schema: "Vetero",
                table: "WeatherTestData");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                schema: "Vetero",
                table: "WeatherTestData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
