using WeatherAdvisor.Model;

namespace WeatherAdvisor.Advices
{
    class OutsideAdvice : Advice
    {
        public override bool Advise(WeatherModel weatherData)
        {
            // go out if it is not raining
            var raining = new RainingAdvice().Advise(weatherData);
            return !raining;
        }

        public override string GetAdviceName()
        {
            return AdviceName.SHOULD_GO_OUTSIDE;
        }
    }
}
