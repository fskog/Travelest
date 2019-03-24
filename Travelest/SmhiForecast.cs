using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Travelest
{
    public class SmhiForecast

    {
        [JsonProperty("approvedTime")]
        public string Time;

        [JsonProperty("timeSeries")]
        public IList<ForecastData> ForecastData;

    }

    public class ForecastData
    {
        [JsonProperty("validTime")]
        public string Time;

        [JsonProperty("parameters")]
        public IList<ForecastObject> Parameters;
    }

    public class ForecastObject
    {

        [JsonProperty("name")]
        public string DataType;

        [JsonProperty("unit")]
        public string Unit;

        [JsonProperty("values")]
        public IList<string> Values;
    }
}
