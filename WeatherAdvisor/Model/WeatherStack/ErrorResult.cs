using Newtonsoft.Json;

namespace WeatherAdvisor.Model.WeatherStack
{
    public class ErrorResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; } = true;

        [JsonProperty("error")]
        public Error Error { get; set; }

        public ErrorResult()
        {
            Error = new Error();
        }
    }
    public class Error
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("info")]
        public string Info { get; set; }

        public Error()
        {
            Type = string.Empty;
            Info = string.Empty;
        }
    }
}
