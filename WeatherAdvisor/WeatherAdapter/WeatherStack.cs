using AutoMapper;
using Newtonsoft.Json;
using WeatherAdvisor.Model;
using WeatherAdvisor.Model.WeatherStack;

namespace WeatherAdvisor.WeatherAdapter
{
    public class WeatherStack : IWeather
    {
        private readonly String _url;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<WeatherStack> _logger;
        private readonly IMapper _mapper;

        public WeatherStack(IConfiguration configuration,
            IHttpClientFactory httpClientFactory,
            ILogger<WeatherStack> logger,
            IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
            _url = configuration.GetValue<String>("WeatherStack");
            _mapper = mapper;
        }
        public async Task<WeatherModel> Get(string zipCode)
        {
            var httpClient = _httpClientFactory.CreateClient();
            String url = String.Format(_url, zipCode);
            _logger.LogInformation($"Request weather stack {url}");
            using (var response = await httpClient.GetAsync(url))
            {
                var content = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogInformation($"Call weather stack error status code {response.StatusCode}, content {content}");
                    return new WeatherModel
                    {
                        Error = "Call weather stack got error!"
                    };
                }

                var errorResult = JsonConvert.DeserializeObject<ErrorResult>(content);
                if (errorResult != null && !errorResult.Success)
                {
                    return new WeatherModel
                    {
                        Error = errorResult?.Error?.Info ?? "Something wrong"
                    };
                }
                else
                {
                    var successResult = JsonConvert.DeserializeObject<SuccessResult>(content);
                    if (successResult == null)
                    {
                        return new WeatherModel
                        {
                            Error = "Something wrong"
                        };
                    }
                    return MapResponse(successResult);
                }
            }
        }

        private WeatherModel MapResponse(SuccessResult input)
        {
            var location = input.Location;
            var current = input.Current;
            var mapLocation = _mapper.Map<WeatherAdvisor.Model.Location>(location);
            var weatherModel = _mapper.Map<WeatherAdvisor.Model.WeatherModel>(current);
            weatherModel.Location = mapLocation;

            return weatherModel;
        }
    }
}
