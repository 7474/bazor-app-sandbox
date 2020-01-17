using System.Net.Http;

namespace MackerelApi
{
    public partial class mackerel_apiClient
    {
        // TODO HttpClientの公開ではなく認証情報の設定メソッドとする。
        public HttpClient HttpClient { get { return _httpClient; } }
    }
}
