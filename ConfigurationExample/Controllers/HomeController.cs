using Microsoft.AspNetCore.Mvc;

namespace ConfigurationExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [Route("/")]
        public IActionResult Index()
        {
            // do not print
            //ViewBag.ClientId = _configuration["weatherapi:ClientId"];
            //ViewBag.ClientSecret = _configuration.GetValue<string>("weatherapi:ClientSecret", "Default Key");
            //return View();

            // bind loads configuration value into existing Option object
            WeatherApiOptions options2 = new WeatherApiOptions();
            _configuration.GetSection("weatherapi").Bind(options2);

            // Get loads configuration values into a new Option object
            IConfigurationSection weatherapiSection = _configuration.GetSection("weatherapi");
            WeatherApiOptions options = _configuration.GetSection("weatherapi").Get<WeatherApiOptions>();

            // could pass entire section to view
            ViewBag.ClientId = options.ClientId;
            ViewBag.ClientSecret = weatherapiSection["ClientSecret"];
            return View();
        }
    }
}
