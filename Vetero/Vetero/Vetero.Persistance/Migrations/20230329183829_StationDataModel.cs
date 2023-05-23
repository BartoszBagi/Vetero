using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class StationDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Humidity",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sunrise",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Sunset",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrecip_in",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrecip_mm",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Uv",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Wind_Dir",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Wind_Kph",
                schema: "Vetero",
                table: "WeatherStationData",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataDate", "Humidity", "Pressure", "Sunrise", "Sunset", "Uv", "Wind_Dir", "Wind_Kph" },
                values: new object[] { new DateTime(2023, 3, 29, 20, 38, 29, 216, DateTimeKind.Local).AddTicks(3715), 20.0, 34.82, 7.0, 19.0, 100.0, "East", 30.0 });

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataDate", "Humidity", "Pressure", "Sunrise", "Sunset", "TotalPrecip_in", "TotalPrecip_mm", "Uv", "Wind_Dir", "Wind_Kph" },
                values: new object[] { new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), 22.0, 34.82, 7.0099999999999998, 19.010000000000002, 2.0, 1.0, 120.0, "East", 33.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Humidity",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Pressure",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Sunrise",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Sunset",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "TotalPrecip_in",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "TotalPrecip_mm",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Uv",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Wind_Dir",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.DropColumn(
                name: "Wind_Kph",
                schema: "Vetero",
                table: "WeatherStationData");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataDate",
                value: new DateTime(2023, 3, 6, 21, 34, 35, 396, DateTimeKind.Local).AddTicks(3928));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataDate",
                value: new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
