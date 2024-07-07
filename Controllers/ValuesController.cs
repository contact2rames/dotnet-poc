using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet(Name = "loss")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                // Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                Name = "Ramesh",
                Summary = "Rupesh"
            })
            .ToArray();
        }
    }
}
