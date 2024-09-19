using ApiConnectionTest.Client.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ApiConnectionTest.Client.Services;

public class PolygonService : IPolygonService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "xdYACsMHyrYcuLq4Ae4nqbTJRwUmu0lN";
    private const string PolygonBaseUrl = "https://api.polygon.io";

    public PolygonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<TickerDetails> GetStockTickerDataAsync()
    {
        var url = $"{PolygonBaseUrl}/v3/reference/tickers/AAPL?apiKey={ApiKey}";
        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            var json = await response.Content.ReadAsStringAsync();

            var fullResponse = JObject.Parse(json);
            var resultSection = fullResponse["results"].ToString();
            var ticker =  JsonConvert.DeserializeObject<TickerDetails>(resultSection);
            ticker.Branding.LogoUrl += $"?apiKey={ApiKey}";
            ticker.Branding.IconUrl += $"?apiKey={ApiKey}";

            return ticker;
        }
        else
        {
            throw new Exception("Error fetching stock data");
        }
    }
}
