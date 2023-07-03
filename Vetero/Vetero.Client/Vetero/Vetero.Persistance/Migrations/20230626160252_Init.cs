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
                    Temperature = table.Column<double>(type: "float", nullable: false),
                    Sunrise = table.Column<double>(type: "float", nullable: false),
                    Sunset = table.Column<double>(type: "float", nullable: false),
                    Humidity = table.Column<double>(type: "float", nullable: false),
                    Wind_Kph = table.Column<double>(type: "float", nullable: false),
                    Wind_Dir = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                columns: new[] { "Id", "DataDate", "Humidity", "Pressure", "Sunrise", "Sunset", "Temperature", "TotalPrecip_in", "TotalPrecip_mm", "Uv", "Wind_Dir", "Wind_Kph" },
                values: new object[] { 1, new DateTime(2023, 6, 26, 18, 2, 52, 312, DateTimeKind.Local).AddTicks(4385), 20.0, 34.82, 7.0, 19.0, 36.600000000000001, 0.0, 0.0, 100.0, "East", 30.0 });

            migrationBuilder.InsertData(
                schema: "Vetero",
                table: "WeatherStationData",
                columns: new[] { "Id", "DataDate", "Humidity", "Pressure", "Sunrise", "Sunset", "Temperature", "TotalPrecip_in", "TotalPrecip_mm", "Uv", "Wind_Dir", "Wind_Kph" },
                values: new object[] { 2, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Local), 22.0, 34.82, 7.0099999999999998, 19.010000000000002, 38.600000000000001, 2.0, 1.0, 120.0, "East", 33.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherStationData",
                schema: "Vetero");
        }
    }
}
