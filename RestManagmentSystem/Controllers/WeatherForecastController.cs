using Microsoft.AspNetCore.Mvc;
using RestManagmentSystem;

namespace RestManagmentSystem.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly MyContext _context;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, MyContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        var menu = new Menu();
        menu.add(new MenuItem("Meat", 30, 1, "good meat"));
        menu.add(new MenuItem("Chicken", 20, 1, "good chicken"));


        return menu.getSummary();
    }
}