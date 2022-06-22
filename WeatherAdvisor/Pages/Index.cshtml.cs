using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WeatherAdvisor.Model;

namespace WeatherAdvisor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AdviceService _adviceService;
        public string Error { get; set; }
        public Location Location { get; set; }
        public List<AdviceModel> Advices { get; set; }
        [BindProperty] public string Zipcode { get; set; }

        public IndexModel(ILogger<IndexModel> logger,
            AdviceService adviceService)
        {
            _logger = logger;
            _adviceService = adviceService;
            Error = string.Empty;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            await Task.Delay(1);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _logger.LogInformation("Post request Index");
            var weatherData = await _adviceService.GetWeatherData(this.Zipcode);
            if (!string.IsNullOrEmpty(weatherData.Error))
            {
                this.Error = weatherData.Error;
                return Page();
            }
            Location = weatherData.Location;
            Advices = _adviceService.GetAdvices(weatherData);
            return Page();
        }
    }
}