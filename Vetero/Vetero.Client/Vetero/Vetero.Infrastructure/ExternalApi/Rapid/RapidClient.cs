﻿using Newtonsoft.Json;
using Microsoft.Extensions.Options;
using Vetero.Application.Common.Helpers;
using Vetero.Application.Common.Interfaces;

namespace Vetero.Infrastructure.ExternalApi.Rapid
{
    public partial class RapidClient : IRapidClient
    {
        private string _baseUrl = "https://weatherapi-com.p.rapidapi.com";
        private readonly HttpClient _httpClient;
        private Lazy<JsonSerializerSettings> _settings;
        private readonly AppSettings _appSettings;
        public RapidClient(IHttpClientFactory factory, IOptions<AppSettings> options)
        {
            _httpClient = factory.CreateClient("RapidClient");

            _baseUrl = _httpClient.BaseAddress.ToString();
            _settings = new Lazy<JsonSerializerSettings>(() =>
            {
                var settings = new JsonSerializerSettings();
                UpdateJsonSerializerSettings(settings);
                return settings;
            });
            _appSettings = options.Value;
        }


        protected JsonSerializerSettings JsonSerializerSettings { get { return _settings.Value; } }

        partial void UpdateJsonSerializerSettings(JsonSerializerSettings settings);

        public string BaseUrl
        {
            get { return _baseUrl; }
            set { _baseUrl = value; }
        }

    }
}
