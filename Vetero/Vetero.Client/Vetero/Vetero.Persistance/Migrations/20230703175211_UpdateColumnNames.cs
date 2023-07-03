using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class UpdateColumnNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Wind_Kph",
                schema: "Vetero",
                table: "WeatherStationData",
                newName: "WindKph");

            migrationBuilder.RenameColumn(
                name: "Wind_Dir",
                schema: "Vetero",
                table: "WeatherStationData",
                newName: "WindDir");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataDate",
                value: new DateTime(2023, 7, 3, 19, 52, 10, 805, DateTimeKind.Local).AddTicks(4575));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataDate",
                value: new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WindKph",
                schema: "Vetero",
                table: "WeatherStationData",
                newName: "Wind_Kph");

            migrationBuilder.RenameColumn(
                name: "WindDir",
                schema: "Vetero",
                table: "WeatherStationData",
                newName: "Wind_Dir");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataDate",
                value: new DateTime(2023, 6, 26, 18, 2, 52, 312, DateTimeKind.Local).AddTicks(4385));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataDate",
                value: new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
