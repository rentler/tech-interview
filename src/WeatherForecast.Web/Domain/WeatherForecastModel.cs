namespace WeatherForecast.Web.Domain;

public class WeatherForecastModel
{
    public long WeatherForecastId { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; set; }
}
