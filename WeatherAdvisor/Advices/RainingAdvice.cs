using WeatherAdvisor.Model;

namespace WeatherAdvisor.Advices
{
    class RainingAdvice : Advice
    {
        public override bool Advise(WeatherModel weatherData)
        {
            if (weatherData == null || weatherData.WeatherDescriptions == null)
                return false;
            if (weatherData.WeatherDescriptions.Contains("Raining"))
                return true;
            return false;
        }

        public override string GetAdviceName()
        {
            return AdviceName.IS_IT_RAINING;
        }
    }
}
