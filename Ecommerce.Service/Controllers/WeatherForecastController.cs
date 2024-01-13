using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<String> Get()
        {
            return new String[]
            {
                "Kerem",
                "Can"
            };
        }
    }
}
