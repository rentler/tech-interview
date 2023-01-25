# tech-interview
A base solution intended as a starting point for our technical interviews

1. Build the WebApi docker image
```
docker build -f WeatherForecast.Web\Dockerfile -t weatherforecast-web .
```

2. Create and initialzie the database
```
dotnet ef database update --project WeatherForecast.Web
```

3 Startup the docker container
```
docker-compose -p interview up -d
```

# Tearing down docker container
```
docker-compose -p interview down -v
```
