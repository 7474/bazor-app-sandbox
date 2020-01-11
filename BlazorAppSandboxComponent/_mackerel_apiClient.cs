using System.Net.Http;

namespace MackerelApi
{
    public partial class mackerel_apiClient
    {
        public HttpClient HttpClient { get { return _httpClient; } }
    }
}
