namespace WeatherAdvisor.Model
{
    public class AdviceModel
    {
        public String AdviceName { get; set; }
        public bool ShouldDo { get; set; }
        
        public AdviceModel(string adviceName)
        {
            AdviceName = adviceName;
        }
    }
}
