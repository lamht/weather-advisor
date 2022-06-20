using WeatherAdvisor.Model;
namespace WeatherAdvisor.Advices
{

    class WearingScreenAdvice : Advice
    {
        private static readonly int uvIndex = 3;
        public override bool Advise(WeatherModel weatherData)
        {
            if (weatherData == null)
                return false;
            return weatherData.UvIndex > uvIndex;
        }

        public override string GetAdviceName()
        {
            return AdviceName.SHOULD_WEAR_SUNSCREEN;
        }
    }
}
