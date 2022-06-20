using WeatherAdvisor.Model;

namespace WeatherAdvisor.Advices
{
    class FlyingKiteAdvice : Advice
    {
        private static readonly int windSpeed = 15;
        public override bool Advise(WeatherModel weatherData)
        {
            if (weatherData == null)
                return false;
            var raining = new RainingAdvice().Advise(weatherData);
            if (!raining)
            {
                return weatherData.WindSpeed > windSpeed;
            }
            return false;
        }

        public override string GetAdviceName()
        {
            return AdviceName.CAN_FLY_THE_KITE;
        }
    }
}
