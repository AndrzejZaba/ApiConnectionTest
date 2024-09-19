using ApiConnectionTest.Client.Models;
using ApiConnectionTest.Client.Services;
using Microsoft.AspNetCore.Components;
using System.Diagnostics;

namespace ApiConnectionTest.Client.Pages
{
    public partial class FetchData
    {
        private TickerDetails tickerData;
        private string time;

        [Inject]
        public IPolygonService PolygonService{ get; set; }

        private void Test()
        {
            if (tickerData == null)
                tickerData = new TickerDetails();
            else
            {
                tickerData.Ticker = "";
                tickerData.WeightedSharesOutstanding = 0;
                tickerData.Branding.LogoUrl = "";
                tickerData.Branding.IconUrl = "";
            }

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
                tickerData = new TickerDetails();
                tickerData.Branding = new Branding();
                tickerData.Ticker = $"Error: {ex.Message}";
            }
            watch.Stop();
            time = watch.ElapsedMilliseconds.ToString();
        }
    }
}
