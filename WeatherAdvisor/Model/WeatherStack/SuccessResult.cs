using Newtonsoft.Json;

namespace WeatherAdvisor.Model.WeatherStack
{
    public class SuccessResult
    {
        [JsonProperty("request")]
        public Request Request { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("current")]
        public Current Current { get; set; }

        public SuccessResult()
        {
            Request = new Request();
            Location = new Location();
            Current = new Current();
        }
    }
}
