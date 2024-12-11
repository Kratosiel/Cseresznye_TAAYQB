using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Cseresznye_TAAYQB
{

    public class MetaData
    {
        [JsonProperty("1. Information")]
        public string Information { get; set; }

        [JsonProperty("2. Symbol")]
        public string Symbol { get; set; }

        [JsonProperty("3. Last Refreshed")]
        public string LastRefreshed { get; set; }

        [JsonProperty("4. Time Zone")]
        public string TimeZone { get; set; }
    }

    public class MonthlyTimeSeries
    {
        [JsonProperty("1. open")]
        public string Open { get; set; }

        [JsonProperty("2. high")]
        public string High { get; set; }

        [JsonProperty("3. low")]
        public string Low { get; set; }

        [JsonProperty("4. close")]
        public string Close { get; set; }

        [JsonProperty("5. volume")]
        public string Volume { get; set; }
    }

    public class StockData
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData { get; set; }

        [JsonProperty("Monthly Time Series")]
        public Dictionary<string, MonthlyTimeSeries> MonthlyTimeSeries { get; set; }
    }
}
