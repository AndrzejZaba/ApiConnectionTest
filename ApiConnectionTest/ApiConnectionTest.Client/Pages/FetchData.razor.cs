using ApiConnectionTest.Client.Services;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ApiConnectionTest.Client.Pages
{
    public partial class FetchData
    {
        private string tickerData;
        private string time;

        [Inject]
        public IPolygonService PolygonService{ get; set; }

        private void Test()
        {
            tickerData = "";
            time = "";
        }
        private async Task GetTickerData()
        {
            var watch = Stopwatch.StartNew();
            try
            {
                tickerData = await PolygonService.GetStockTickerDataAsync();
            }
            catch (Exception ex)
            {
                tickerData = $"Error: {ex.Message}";
            }
            watch.Stop();
            time = watch.ElapsedMilliseconds.ToString();
        }
    }
}
