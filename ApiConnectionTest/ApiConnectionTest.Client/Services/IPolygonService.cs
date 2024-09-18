namespace ApiConnectionTest.Client.Services
{
    public interface IPolygonService
    {
        Task<string> GetStockTickerDataAsync();
    }
}
