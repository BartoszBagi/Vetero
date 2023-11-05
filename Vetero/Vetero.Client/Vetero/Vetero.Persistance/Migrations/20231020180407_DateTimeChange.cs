using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class DateTimeChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                schema: "Vetero",
                table: "WeatherTestData",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 20, 4, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 20, 4, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 20, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 20, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 10, 20, 6, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 10, 20, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 10, 20, 7, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 10, 20, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 10, 20, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 10, 20, 8, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 10, 20, 9, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 10, 20, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 10, 20, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 10, 20, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 10, 20, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 10, 20, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 10, 20, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 10, 20, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 10, 20, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 10, 20, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 10, 20, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2023, 10, 20, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 10, 20, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 10, 20, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2023, 10, 20, 22, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Date",
                schema: "Vetero",
                table: "WeatherTestData",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 10, 19, 4, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 10, 19, 4, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 10, 19, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 10, 19, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 10, 19, 6, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 10, 19, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 10, 19, 7, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 10, 19, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 10, 19, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 10, 19, 8, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 10, 19, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 10, 19, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 10, 19, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 10, 19, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 10, 19, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 10, 19, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 10, 19, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 10, 19, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 10, 19, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 10, 19, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2023, 10, 19, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 10, 19, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 10, 19, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2023, 10, 19, 22, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
