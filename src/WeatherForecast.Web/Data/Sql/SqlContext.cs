using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.Web.Data.Sql;

public class SqlContext : DbContext
{
    public SqlContext(DbContextOptions<SqlContext> options) : base(options)
    {

    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}
