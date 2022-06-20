using AutoMapper;

namespace WeatherAdvisor.Mapping
{
    public class WeatherProfile : Profile
    {
        public WeatherProfile()
        {
            CreateMap<WeatherAdvisor.Model.WeatherStack.Location, WeatherAdvisor.Model.Location>();
            CreateMap<WeatherAdvisor.Model.WeatherStack.Current, WeatherAdvisor.Model.WeatherModel>();
        }

    }
}
