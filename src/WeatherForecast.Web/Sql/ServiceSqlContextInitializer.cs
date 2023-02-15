using Microsoft.EntityFrameworkCore;
namespace WeatherForecast.Web.Sql;

/// <summary>
/// Initializes, migrates, and seeds the 
/// database. If using Asp.Net Core this
/// should be used in the Program.cs to setup the database
/// in the instance it doesn't exist.
/// </summary>
public class ServiceSqlContextInitializer
{
    /// <summary>
    /// Performs the actual actions of using migrations to setup
    /// the database and seeding with test data if required.
    /// </summary>
    /// <param name="services">Core serviceprovider from dependancy
    /// injection that is used to instantiate the contexts.</param>
    /// <returns>Empty task because it is async.</returns>
    public static async Task Initialize(IServiceProvider services)
    {
        SqlContext context =
            services.GetRequiredService<SqlContext>();

        await context.Database.MigrateAsync();
    }
}

