using Vetero.Shared.Commands.Rapid;
using Vetero.Shared.Dto;
using Vetero.Shared.Dto.WeatherStation;

namespace Vetero.Shared.ViewModels.Rapid.TestedData
{
    public class TestedDataModel
    {
        public WeatherTestDataDto WeatherTestData { get; set; } = new WeatherTestDataDto();
        public WeatherStationCompareDataDto StationCompareData { get; set; } = new WeatherStationCompareDataDto();
        public CompareWeatherResultDto CompareResults { get; set; } = new CompareWeatherResultDto();
    }
}
