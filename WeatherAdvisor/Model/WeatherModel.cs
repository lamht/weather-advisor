namespace WeatherAdvisor.Model
{
    public class WeatherModel
    {
        public Location Location { get; set; }
        public List<string> WeatherDescriptions { get; set; }
        public int Temperature { get; set; }
        public int WindSpeed { get; set; }
        public int UvIndex { get; set; }
        public int Pressure { get; set; }

        public string Error { get; set; }
        
        public WeatherModel()
        {
            Location = new Location();
            Error = string.Empty;
            WeatherDescriptions = new List<string>();
        }

    }
    public class Location
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        
        public Location()
        {
            Name = string.Empty;
            Country = string.Empty;
            Region = string.Empty;
        }
    }
}
