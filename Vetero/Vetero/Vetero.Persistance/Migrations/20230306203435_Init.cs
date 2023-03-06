using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Vetero");

            migrationBuilder.CreateTable(
                name: "WeatherStationData",
                schema: "Vetero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStationData", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "WeatherStationData",
                columns: new[] { "Id", "DataDate", "Temperature" },
                values: new object[] { 1, new DateTime(2023, 3, 6, 21, 34, 35, 396, DateTimeKind.Local).AddTicks(3928), 36.600000000000001 });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "WeatherStationData",
                columns: new[] { "Id", "DataDate", "Temperature" },
                values: new object[] { 2, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Local), 38.600000000000001 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStationData",
                schema: "Vetero");
        }
    }
}
