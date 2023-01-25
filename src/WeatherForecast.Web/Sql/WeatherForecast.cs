using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeatherForecast.Web.Sql;

public class WeatherForecast
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long WeatherForecastId { get; set; }

    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF { get; set; }

    [MaxLength(250)]
    public string Summary { get; set; }
}
