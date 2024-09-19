using ApiConnectionTest.Client.Models;

namespace ApiConnectionTest.Client.Services
{
    public interface IPolygonService
    {
        Task<TickerDetails> GetStockTickerDataAsync();
    }
}
