using WeatherAdvisor.Model;

namespace WeatherAdvisor.WeatherAdapter
{
    //Can change the implement with dependency injection
    public interface IWeather
    {
        Task<WeatherModel> Get(string zipCode);
    }
}
