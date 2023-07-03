using System.Text;

namespace Vetero.Infrastructure.ExternalApi.Rapid
{
    public partial class RapidClient
    {
        public async Task<string> GetRealTimeWeatherAsync(string location, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(!string.IsNullOrEmpty(_baseUrl) ? _baseUrl : "").Append($"current.json?q={location}");

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
                        return responseData == null ? throw new NotImplementedException() : responseData;
                    }
                    else
                    {
                        return "Something bad happened, not impelemented";
                    }
                }
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.Message);
            }
        }
    }
}
