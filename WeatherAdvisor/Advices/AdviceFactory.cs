namespace WeatherAdvisor.Advices
{
    public static class AdviceFactory
    {
        public static List<Advice> GetAdvices()
        {
            //can dynamic create list advice
            return new List<Advice>()
            {
                new OutsideAdvice(),
                new WearingScreenAdvice(),
                new FlyingKiteAdvice(),
            };
        }
    }
}
