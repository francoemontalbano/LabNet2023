using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Web.Mvc;
using Ejercicio.EFU.MVC.Models;
using Ejercicio.EFU.MVC.ViewModels;

namespace Ejercicio.EFU.MVC.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;

        public WeatherController()
        {
            _httpClient = new HttpClient();
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> ShowWeather(string city)
        {
            var apiKey = "0ea31e0ba4c0827345c47dc63d605d99";
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                var viewModel = new WeatherViewModel
                {
                    City = weatherData.Name,
                    Description = weatherData.Weather[0].Description,
                    Temperature = weatherData.Main.Temp,
                    Humidity = weatherData.Main.Humidity,
                    WindSpeed = weatherData.Wind.Speed
                };

                return View(viewModel);

    }

            return View("ShowWeather");

            
        }
    }
}
