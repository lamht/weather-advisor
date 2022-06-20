using WeatherAdvisor.Advices;
using WeatherAdvisor.Model;
using WeatherAdvisor.WeatherAdapter;

namespace WeatherAdvisor
{
    public class AdviceService
    {
        private readonly IWeather _weather;
        public AdviceService(IWeather weather)
        {
            _weather = weather;
        }

        public async Task<WeatherModel> GetWeatherData(string zipcode)
        {
            var weatherData = await _weather.Get(zipcode);
            return weatherData;
        }
        public List<AdviceModel> GetAdvices(WeatherModel weatherData)
        {

            var advices = AdviceFactory.GetAdvices();
            List<AdviceModel> result = new List<AdviceModel>();
            foreach (var advice in advices)
            {
                var r = new AdviceModel()
                {
                    AdviceName = advice.GetAdviceName(),
                    ShouldDo = advice.Advise(weatherData)
                };
                result.Add(r);
            }
            return result;
        }
    }
}
