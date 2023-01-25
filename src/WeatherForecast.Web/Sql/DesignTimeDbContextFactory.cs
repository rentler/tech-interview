using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.Web.Sql;

/// <summary>
/// Used by the dotnet ef command to automatically scaffold
/// the SQL database.
/// </summary>
public class DesignTimeDbContextFactory
    : IDesignTimeDbContextFactory<SqlContext>
{
    /// <summary>
    /// Builds a ServiceSqlContext by looking at app settings json file and 
    /// uses the connection string.
    /// </summary>
    /// <param name="args">Arguments passed in from the ef pipeline.</param>
    /// <returns>A new ServiceSqlContext for scaffolding.</returns>
    public SqlContext CreateDbContext(string[] args)
    {
        var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        var projectDir = Directory.GetCurrentDirectory();
        var projectName = Path.GetFileName(projectDir);
        var webProjectPath = Path.Combine(projectDir, $"..\\{projectName}");

        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(webProjectPath)
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{environment}.json")
            .Build();

        var builder = new DbContextOptionsBuilder<SqlContext>();
        var connectionString = configuration.GetConnectionString("SqlDatabaseConnection");

        builder.UseSqlServer(connectionString);

        return new SqlContext(builder.Options);
    }
}