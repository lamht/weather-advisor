using Newtonsoft.Json;

namespace WeatherAdvisor.Model.WeatherStack
{
    public class Current
    {
        [JsonProperty("observation_time")]
        public string ObservationTime { get; set; }

        [JsonProperty("temperature")]
        public int Temperature { get; set; }

        [JsonProperty("weather_code")]
        public int WeatherCode { get; set; }

        [JsonProperty("weather_icons")]
        public List<string> WeatherIcons { get; set; }

        [JsonProperty("weather_descriptions")]
        public List<string> WeatherDescriptions { get; set; }

        [JsonProperty("wind_speed")]
        public int WindSpeed { get; set; }

        [JsonProperty("wind_degree")]
        public int WindDegree { get; set; }

        [JsonProperty("wind_dir")]
        public string WindDir { get; set; }

        [JsonProperty("pressure")]
        public int Pressure { get; set; }

        [JsonProperty("precip")]
        public int Precip { get; set; }

        [JsonProperty("humidity")]
        public int Humidity { get; set; }

        [JsonProperty("cloudcover")]
        public int Cloudcover { get; set; }

        [JsonProperty("feelslike")]
        public int Feelslike { get; set; }

        [JsonProperty("uv_index")]
        public int UvIndex { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("is_day")]
        public string IsDay { get; set; }

        public Current()
        {
            ObservationTime = string.Empty;
            WeatherIcons = new List<string>();
            WeatherDescriptions = new List<string>();
            WindDir = string.Empty;
            IsDay = string.Empty;
        }
    }
}
