using ApiConnectionTest.Client.Services;
using Microsoft.AspNetCore.Components;

namespace ApiConnectionTest.Client.Pages
{
    public partial class FetchData
    {
        private string tickerData;

        [Inject]
        public PolygonService PolygonService{ get; set; }
        private async Task GetTickerData()
        {
            try
            {
                tickerData = await PolygonService.GetStockTickerDataAsync();
            }
            catch (Exception ex)
            {
                tickerData = $"Error: {ex.Message}";
            }
        }
    }
}
