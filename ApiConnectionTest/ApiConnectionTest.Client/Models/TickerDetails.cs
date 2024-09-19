using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace ApiConnectionTest.Client.Models;

[JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class TickerDetails
{
    public Branding Branding { get; set; }
    public string Ticker { get; set; }
    public long WeightedSharesOutstanding { get; set; }
}

[JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Branding
{
    public string IconUrl { get; set; }
    public string LogoUrl { get; set; }
}

