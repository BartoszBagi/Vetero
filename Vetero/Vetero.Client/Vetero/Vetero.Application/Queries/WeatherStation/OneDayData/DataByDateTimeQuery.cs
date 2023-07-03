using MediatR;

namespace Vetero.Application.Queries.WeatherStation.OneDayData
{
    public class DataByDateTimeQuery : IRequest<IEnumerable<OneDayDataDto>>
    {
        public string Date { get; set; }
    }
}
