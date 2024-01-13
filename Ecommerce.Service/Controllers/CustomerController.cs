using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
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
