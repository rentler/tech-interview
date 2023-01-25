# tech-interview
A base solution intended as a starting point for our technical interviews

# Building the docker image
```
docker build -f WeatherForecast.Web\Dockerfile -t weatherforecast-web .
```

# Create the database
```
dotnet ef database update --project WeatherForecast.Web
```

# Building the docker container
```
docker-compose -p interview up -d
```

# Tearing down docker container
```
docker-compose -p interview down -v
```