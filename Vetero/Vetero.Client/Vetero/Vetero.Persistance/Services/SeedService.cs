using Microsoft.EntityFrameworkCore;
using Vetero.Domain.Entities.WeatherData;
using Vetero.Persistance.Helpers;

namespace Vetero.Persistance.Services
{
    public static class SeedService
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<WeatherStationData>().HasData(
                new WeatherStationData()
                {
                    Id = 1,
                    DataDate = DateTime.Parse(DateHelper.GetTodayDateString("4", "20")),  // data pomiaru
                    Temperature = 12,   //temperatura
                    Sunrise = 6.30, // wschód
                    Sunset = 22.00, // zachód
                    Humidity = 50,  // wyrażane w procentach
                    WindKph = 30, // kilometry na godzine
                    WindDir = "East",
                    Pressure = 1006, // wyrażana w Paskalach (Pa)
                    TotalPrecip_mm = 0, // opady w milimetrach 1 mm odpowiada 1l wody rozlanemu na 1 metrze kwadratowym.
                                        // W przypadku śniegu odpowiada to wodzie powstałej po jego stopieniu.
                    TotalPrecip_in = 0, // całkowity opad
                    Uv = 6 // Natężenie słonecznego promieniowania ultrafioletowego (UV) wyrażone jest wskaźnikiem UV ("Solar UV index").
                             // Na obszarze Wielkiej Brytanii wskaźnik UV nie przekracza wartości równej 8
                             // (8 – bardzo rzadko,
                             // 7 – w dniach szczególnych, przeważnie przez dwa tygodnie w okresie letniego przesilenia).
                             // Wartości 9 i 10 są charakterystyczne dla obszaru śródziemnomorskiego. Prognoza wskaźnika UV odnosi się do dziennego maksimum.

                },
                new WeatherStationData()
                {
                    Id = 2,
                    DataDate = DateTime.Parse(DateHelper.GetTodayDateString("4", "45")),
                    Temperature = 13,
                    Sunrise = 6.30,
                    Sunset = 22.00,
                    Humidity = 50,
                    WindKph = 33,
                    WindDir = "East",
                    Pressure = 1006,
                    TotalPrecip_mm = 0,
                    TotalPrecip_in = 0,
                    Uv = 6
                },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("5", "30")),
                   Temperature = 14,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("6", "00")),
                   Temperature = 13,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("6", "45")),
                   Temperature = 14,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("7", "00")),
                   Temperature = 16,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("7", "25")),
                   Temperature = 18,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 45,
                   WindKph = 40,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("8", "00")),
                   Temperature = 20,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 45,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("8", "20")),
                   Temperature = 21,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 40,
                   WindKph = 35,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("8", "45")),
                   Temperature = 21,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("9", "20")),
                   Temperature = 21,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("9", "45")),
                   Temperature = 22,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("10", "00")),
                   Temperature = 22,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("11", "00")),
                   Temperature = 23,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("12", "00")),
                   Temperature = 24,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("13", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("14", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("15", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("16", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("17", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("18", "00")),
                   Temperature = 25,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("19", "00")),
                   Temperature = 23,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
               new WeatherStationData()
               {
                   Id = 2,
                   DataDate = DateTime.Parse(DateHelper.GetTodayDateString("20", "00")),
                   Temperature = 21,
                   Sunrise = 6.30,
                   Sunset = 22.00,
                   Humidity = 50,
                   WindKph = 33,
                   WindDir = "East",
                   Pressure = 1006,
                   TotalPrecip_mm = 0,
                   TotalPrecip_in = 0,
                   Uv = 6
               },
                new WeatherStationData()
                {
                    Id = 2,
                    DataDate = DateTime.Parse(DateHelper.GetTodayDateString("21", "00")),
                    Temperature = 19,
                    Sunrise = 6.30,
                    Sunset = 22.00,
                    Humidity = 50,
                    WindKph = 33,
                    WindDir = "East",
                    Pressure = 1006,
                    TotalPrecip_mm = 0,
                    TotalPrecip_in = 0,
                    Uv = 6
                },
                new WeatherStationData()
                {
                    Id = 2,
                    DataDate = DateTime.Parse(DateHelper.GetTodayDateString("22", "00")),
                    Temperature = 18,
                    Sunrise = 6.30,
                    Sunset = 22.00,
                    Humidity = 50,
                    WindKph = 33,
                    WindDir = "East",
                    Pressure = 1006,
                    TotalPrecip_mm = 0,
                    TotalPrecip_in = 0,
                    Uv = 6
                }
                );

        }
    }
}
