namespace ApiConnectionTest.Client.Services;

public class PolygonService
{
    private readonly HttpClient _httpClient;
    private const string ApiKey = "xdYACsMHyrYcuLq4Ae4nqbTJRwUmu0lN";
    private const string PolygonBaseUrl = "https://api.polygon.io";

    public PolygonService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<string> GetStockTickerDataAsync()
    {
        var url = $"{PolygonBaseUrl}/v2/aggs/ticker/AAPL/range/1/day/2023-01-09/2023-01-09?apiKey={ApiKey}";
        var response = await _httpClient.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            return await response.Content.ReadAsStringAsync();
        }
        else
        {
            throw new Exception("Error fetching stock data");
        }
    }
}
