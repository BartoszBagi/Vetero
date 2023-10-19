using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class TestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherTestData",
                schema: "Vetero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    Humidity = table.Column<double>(type: "float", nullable: false),
                    WindKph = table.Column<double>(type: "float", nullable: false),
                    Pressure = table.Column<double>(type: "float", nullable: false),
                    TotalPrecip_mm = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherTestData", x => x.Id);
                });

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 15, 4, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 15, 4, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 15, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 15, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 10, 15, 6, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 10, 15, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 10, 15, 7, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 10, 15, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 10, 15, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 10, 15, 8, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 10, 15, 9, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 10, 15, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 10, 15, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 10, 15, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 10, 15, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 10, 15, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 10, 15, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 10, 15, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 10, 15, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 10, 15, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 10, 15, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2023, 10, 15, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 10, 15, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 10, 15, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2023, 10, 15, 22, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherTestData",
                schema: "Vetero");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 7, 5, 4, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 7, 5, 4, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 7, 5, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 7, 5, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 7, 5, 6, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 7, 5, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 7, 5, 7, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 7, 5, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 7, 5, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 7, 5, 8, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 7, 5, 9, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 7, 5, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 7, 5, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 7, 5, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 7, 5, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 7, 5, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 7, 5, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 7, 5, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 7, 5, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 7, 5, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 7, 5, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2023, 7, 5, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 7, 5, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 7, 5, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2023, 7, 5, 22, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
