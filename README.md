# tech-interview
A base solution intended as a starting point for our technical interviews

## Follow these steps in sequence

1. Startup MSSQL database in docker
```
docker-compose -p interview up -d
```

2. Open solution file in Visual Studio

3. Implement CRUD operations for WeatherForecast API
- Create WeatherForecast
- Read WeatherForecast by Id
- Update WeatherForecast by Id
- Delete WeatherForecast by Id

## Tearing down docker container
```
docker-compose -p interview down -v
```
