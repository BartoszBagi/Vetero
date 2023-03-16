using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Vetero.Infrastructure.ExternalApi.Rapid
{
    public partial class RapidClient
    {
        public async Task<string> GetRealTimeWeatherAsync(string location, CancellationToken cancellationToken)
        {
            var urlBuilder = new StringBuilder();
            urlBuilder.Append(!string.IsNullOrEmpty(_baseUrl) ? _baseUrl : "").Append($"current.json?q={location}");

            var client = _httpClient;
            client.DefaultRequestHeaders.Add("X-RapidAPI-Key", "3e6a145959msh2cf4f9b7c4fb4a8p1d71a5jsnfc4ef92cb297");
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
                throw ex;
            }
        }
    }
}
