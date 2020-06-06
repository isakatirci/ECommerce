using BlazorUI.Client.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorUI.Client.Services
{
    public abstract class BaseService
    {
        private readonly HttpClient _httpClient;

        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> Get<T>(string url)
        {
            var json = await _httpClient.GetStringAsync(url);
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> Post<T>(string url, object data)
        {
            var json = JsonConvert.SerializeObject(data);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await _httpClient.PostAsync(url, content);
            return JsonConvert.DeserializeObject<T>(result.Content.ToString());
        }
    }
}
