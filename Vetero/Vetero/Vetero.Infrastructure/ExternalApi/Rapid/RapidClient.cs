using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Infrastructure.ExternalApi.Rapid
{
    public partial class RapidClient : IRapidClient
    {
        private string _baseUrl = "https://weatherapi-com.p.rapidapi.com";
        private string _myApiKey = "3e6a145959msh2cf4f9b7c4fb4a8p1d71a5jsnfc4ef92cb297";
        private readonly HttpClient _httpClient;
        private Lazy<Newtonsoft.Json.JsonSerializerSettings> _settings;

        public RapidClient(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("RapidClient");
            _baseUrl = _httpClient.BaseAddress.ToString();
            _settings = new Lazy<Newtonsoft.Json.JsonSerializerSettings>(() =>
            {
                var settings = new Newtonsoft.Json.JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
        }


        protected Newtonsoft.Json.JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }
     
    }
}
