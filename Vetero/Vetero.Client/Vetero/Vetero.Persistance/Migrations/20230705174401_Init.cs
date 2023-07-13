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
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    Sunrise = table.Column<double>(type: "float", nullable: false),
                    Sunset = table.Column<double>(type: "float", nullable: false),
                    Humidity = table.Column<double>(type: "float", nullable: false),
                    WindKph = table.Column<double>(type: "float", nullable: false),
                    WindDir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: false),
                    TotalPrecip_mm = table.Column<double>(type: "float", nullable: false),
                    TotalPrecip_in = table.Column<double>(type: "float", nullable: false),
                    Uv = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherStationData", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "WeatherStationData",
                columns: new[] { "Id", "Date", "Humidity", "Pressure", "Sunrise", "Sunset", "Temperature", "TotalPrecip_in", "TotalPrecip_mm", "Uv", "WindDir", "WindKph" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 7, 5, 4, 20, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 12.0, 0.0, 0.0, 6.0, "East", 30.0 },
                    { 2, new DateTime(2023, 7, 5, 4, 45, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 13.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 3, new DateTime(2023, 7, 5, 5, 30, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 14.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 4, new DateTime(2023, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 13.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 5, new DateTime(2023, 7, 5, 6, 45, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 14.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 6, new DateTime(2023, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 16.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 7, new DateTime(2023, 7, 5, 7, 25, 0, 0, DateTimeKind.Unspecified), 45.0, 1006.0, 6.2999999999999998, 22.0, 18.0, 0.0, 0.0, 6.0, "East", 40.0 },
                    { 8, new DateTime(2023, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), 45.0, 1006.0, 6.2999999999999998, 22.0, 20.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 9, new DateTime(2023, 7, 5, 8, 20, 0, 0, DateTimeKind.Unspecified), 40.0, 1006.0, 6.2999999999999998, 22.0, 21.0, 0.0, 0.0, 6.0, "East", 35.0 },
                    { 10, new DateTime(2023, 7, 5, 8, 45, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 21.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 11, new DateTime(2023, 7, 5, 9, 20, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 21.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 12, new DateTime(2023, 7, 5, 9, 45, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 22.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 13, new DateTime(2023, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 22.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 14, new DateTime(2023, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 23.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 15, new DateTime(2023, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 24.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 16, new DateTime(2023, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 17, new DateTime(2023, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 18, new DateTime(2023, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 19, new DateTime(2023, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 20, new DateTime(2023, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 21, new DateTime(2023, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 25.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 22, new DateTime(2023, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 23.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 23, new DateTime(2023, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 21.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 24, new DateTime(2023, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 19.0, 0.0, 0.0, 6.0, "East", 33.0 },
                    { 25, new DateTime(2023, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified), 50.0, 1006.0, 6.2999999999999998, 22.0, 18.0, 0.0, 0.0, 6.0, "East", 33.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStationData",
                schema: "Vetero");
        }
    }
}
