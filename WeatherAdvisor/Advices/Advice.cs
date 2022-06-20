using WeatherAdvisor.Model;

namespace WeatherAdvisor.Advices
{
    public abstract class Advice
    {
        public abstract bool Advise(WeatherModel weatherData);
        public abstract String GetAdviceName();
    }
}
