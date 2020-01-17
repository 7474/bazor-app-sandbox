using System.Net.Http;

namespace MackerelApi
{
    public partial class mackerel_apiClient
    {
        public void SetApiKey(string apiKey)
        {
            _httpClient.DefaultRequestHeaders.Remove("X-Api-Key");
            _httpClient.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
        }
    }
}
