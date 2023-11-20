using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vetero.Persistance.Migrations
{
    public partial class UserAndRoleAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "Vetero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "Vetero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "Vetero",
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2023, 11, 6, 4, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2023, 11, 6, 4, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2023, 11, 6, 5, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2023, 11, 6, 6, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2023, 11, 6, 6, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2023, 11, 6, 7, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2023, 11, 6, 7, 25, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2023, 11, 6, 8, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2023, 11, 6, 8, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 10,
                column: "Date",
                value: new DateTime(2023, 11, 6, 8, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 11,
                column: "Date",
                value: new DateTime(2023, 11, 6, 9, 20, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 12,
                column: "Date",
                value: new DateTime(2023, 11, 6, 9, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 13,
                column: "Date",
                value: new DateTime(2023, 11, 6, 10, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 14,
                column: "Date",
                value: new DateTime(2023, 11, 6, 11, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 15,
                column: "Date",
                value: new DateTime(2023, 11, 6, 12, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 16,
                column: "Date",
                value: new DateTime(2023, 11, 6, 13, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 17,
                column: "Date",
                value: new DateTime(2023, 11, 6, 14, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 18,
                column: "Date",
                value: new DateTime(2023, 11, 6, 15, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 19,
                column: "Date",
                value: new DateTime(2023, 11, 6, 16, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 20,
                column: "Date",
                value: new DateTime(2023, 11, 6, 17, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 21,
                column: "Date",
                value: new DateTime(2023, 11, 6, 18, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 22,
                column: "Date",
                value: new DateTime(2023, 11, 6, 19, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 23,
                column: "Date",
                value: new DateTime(2023, 11, 6, 20, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 24,
                column: "Date",
                value: new DateTime(2023, 11, 6, 21, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Vetero",
                table: "WeatherStationData",
                keyColumn: "Id",
                keyValue: 25,
                column: "Date",
                value: new DateTime(2023, 11, 6, 22, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                schema: "Vetero",
                table: "Users",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users",
                schema: "Vetero");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "Vetero");

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
    }
}
