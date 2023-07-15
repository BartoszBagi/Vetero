using Vetero.Application.Enums;

namespace Vetero.Application.Helpers
{
    internal static class WeatherDescriptionHelper
    {
        public static string SetWeatherDescription(string imageHelperData)
        {
            if (imageHelperData == WeatherImageTypes.Sunny)
                return "Jest słonecznie, a wiatr umiarkowany, świetna pogoda na spacer.";
            if (imageHelperData == WeatherImageTypes.Snowy)
                return "Aktualnie jest zimno i pada śnieg. Pamiętaj o czapce!";
            if (imageHelperData == WeatherImageTypes.BrrCold)
                return "Aktualnie jest zimno. Lepiej ubierz się ciepło.";
            if (imageHelperData == WeatherImageTypes.Cloudy)
                return "Jest pochmurnie ale nie powinno padać. Dobra pogoda do pracy na powietrzu.";
            if (imageHelperData == WeatherImageTypes.Rainy)
                return "Pada deszcz. Wychodząc weź parasol.";
            if (imageHelperData == WeatherImageTypes.RainyThunder)
                return "Prawdopodobieństwo burz, lepiej zostać w domu.";
            if (imageHelperData == WeatherImageTypes.Windy)
                return "Aktualnie jest wietrznie. Lepiej zebrać pranie z balkonu.";

            return "Pogoda jaka by nie była, życzę Ci miłego dnia :)";
        }
    }
}
