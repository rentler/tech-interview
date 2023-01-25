using Microsoft.EntityFrameworkCore;
using WeatherForecast.Web.Sql;

namespace WeatherForecast.Web.Configuration;

public static class IServiceCollectionExtensions
{
    public static void ConfigureServices(
        this IServiceCollection services, IConfiguration config)
    {
        var connectionStringsSection = config.GetSection("ConnectionStrings");
        var connectionStrings = connectionStringsSection.Get<ConnectionStrings>();
        services.Configure<ConnectionStrings>(connectionStringsSection);

        services.AddDbContext<SqlContext>(opts =>
        {
            opts.UseSqlServer(connectionStrings.SqlDatabaseConnection,
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(3);
                });
        });
    }
}
