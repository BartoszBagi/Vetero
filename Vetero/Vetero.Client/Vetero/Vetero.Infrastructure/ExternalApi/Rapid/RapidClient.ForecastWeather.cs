using System.Text;
using Vetero.Application.External.Queries;

namespace Vetero.Infrastructure.ExternalApi.Rapid
{
    public partial class RapidClient
    {
        public async Task<string> GetForecastWeatherAsync(ForecastQuery query, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            var days = query.Days != null ? $"&days={query.Days}" : "";
            var lang = query.Lang != null ? $"&lang={query.Lang}" : "&lang=PL";
            var date = query.Date != null ? $"&dt={query.Date}" : "";

            urlBuilder.Append(!string.IsNullOrEmpty(_baseUrl) ? _baseUrl : "").Append($"forecast.json?q={query.Location}")
                .Append($"{days}{lang}{date}");

            var client = _httpClient;
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", $"{_appSettings.RapidApiKey}");
            client.DefaultRequestHeaders.Add("X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com");

            try
            {
                using (var request = new HttpRequestMessage())
                {
                    request.Method = new HttpMethod("GET");
                    var url = urlBuilder.ToString();
                    request.RequestUri = new Uri(url, UriKind.RelativeOrAbsolute);

                    var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var responseData = response.Content == null ? null : await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                        return responseData;
                    }
                    else
                    {
                        return "Something bad happened";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
