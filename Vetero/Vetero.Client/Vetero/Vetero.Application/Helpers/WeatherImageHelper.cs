using Vetero.Application.Enums;
using Vetero.Domain.Entities.WeatherData;

namespace Vetero.Application.Helpers
{
    internal static class WeatherImageHelper
    {
        public static string SetWeatherImage(WeatherStationData data)
        {
            bool isWindy = data.WindKph > 20 ? true : false;
            //bool isModerateBreeze = data.WindKph > 20 && data.WindKph < 28 ? true : false;
            //bool isFreshBreeze = data.WindKph > 28 && data.WindKph < 38 ? true : false;
            //bool isStrongBreeze = data.WindKph > 39 && data.WindKph < 49 ? true : false;
            //bool isNearGale = data.WindKph > 50 && data.WindKph < 61 ? true : false;

            bool isRainy = data.TotalPrecip_mm > 0 ? true : false;
            bool isVeryLightRain = data.TotalPrecip_mm < 0.5 ? true : false;
            bool isLightRain = data.TotalPrecip_mm < 2.5 && data.TotalPrecip_mm > 0.5 ? true : false;
            bool isModerateRain = data.TotalPrecip_mm < 7.5 && data.TotalPrecip_mm > 2.5 ? true : false;
            bool isPouringRain = data.TotalPrecip_mm < 20 && data.TotalPrecip_mm > 7.5 ? true : false;
            bool isTempestuousRain = data.TotalPrecip_mm > 20 ? true : false;           

            bool isFrost = data.Temperature < 0 ? true : false;
            //bool isCold = data.Temperature > 0 && data.Temperature < 12 ? true : false;
            //bool isModerately = data.Temperature > 12 && data.Temperature < 17 ? true : false;
            //bool isWarm = data.Temperature > 17 && data.Temperature < 24 ? true : false;
            //bool isHot = data.Temperature > 24 && data.Temperature < 27 ? true : false;
            //bool isVeryHot = data.Temperature > 27 ? true : false;

            bool isCloudyChance = data.Pressure < 1000 ? true : false;
            bool isRainHumidity = data.Humidity > 60 ? true : false;

            if (isFrost && isRainy)
                return WeatherImageTypes.Snowy;
            if (isFrost && !isRainy)
                return WeatherImageTypes.BrrCold;
            if (isCloudyChance && !isRainy && !isRainHumidity)
                return WeatherImageTypes.Cloudy;
            if ((isCloudyChance && isRainy && isRainHumidity) || 
                (isRainy && (isVeryLightRain || isLightRain || isModerateRain)))
                return WeatherImageTypes.Rainy;
            if (isPouringRain && isTempestuousRain)
                return WeatherImageTypes.RainyThunder;
            if(!isCloudyChance && !isWindy && !isRainy)
                return WeatherImageTypes.Sunny;
            if (isWindy && !isRainy)
                return WeatherImageTypes.Windy;

            return WeatherImageTypes.Sunny;
        }
    }
}
