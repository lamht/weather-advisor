#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["WeatherAdvisor/WeatherAdvisor.csproj", "WeatherAdvisor/"]
RUN dotnet restore "WeatherAdvisor/WeatherAdvisor.csproj"
COPY . .
WORKDIR "/src/WeatherAdvisor"
RUN dotnet build "WeatherAdvisor.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WeatherAdvisor.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WeatherAdvisor.dll"]