# tech-interview
A base solution intended as a starting point for our technical interviews

## Follow these steps in sequence

1. Build the Weather Forecast API docker image
```
docker build -f WeatherForecast.Web\Dockerfile -t weatherforecast-web .
```

2. Startup docker container

Includes a MSSQL image and a Weather Forecast API .NET 6 image
```
docker-compose -p interview up -d
```

3. Stop WeatherForecast API docker image so you can start coding
```
docker-compose -p interview stop weatherforecast-web
```

4. Open solution and implement CRUD operations for the WeatherForecast API

- Create WeatherForecast
- Read WeatherForecast by Id
- Update WeatherForecast by Id
- Delete WeatherForecast by Id

5. Create database and run Migrations

Run the following command from the Package Manager Console in Visual Studio
```
dotnet ef database update --project WeatherForecast.Web
```

6. Re-run Step 1 again to rebuild the WeatherForecast API docker image after changes

7. Run the following command to start the updated WeatherForecast API docker image
```
docker-compose -p interview start weatherforecast-web
```

8. Launch the WeatherForecast API by going to http://localhost:6001


# Tearing down docker container
```
docker-compose -p interview down -v
```
