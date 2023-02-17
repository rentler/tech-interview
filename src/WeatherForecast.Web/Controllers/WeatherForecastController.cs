using Microsoft.AspNetCore.Mvc;
using WeatherForecast.Web.Domain;

namespace WeatherForecast.Web.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [Route("{id}")]
    public WeatherForecastModel Read(long id)
    {
        throw new NotImplementedException();
    }
}
