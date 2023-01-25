FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY WeatherForecast.Web/WeatherForecast.Web.csproj WeatherForecast.Web/
RUN dotnet restore WeatherForecast.Web/WeatherForecast.Web.csproj --source https://api.nuget.org/v3/index.json
COPY . .
WORKDIR /src/WeatherForecast.Web
RUN dotnet build WeatherForecast.Web.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WeatherForecast.Web.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WeatherForecast.Web.dll"]
