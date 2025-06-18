FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY . .
RUN dotnet build --configuration Release

FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build src/bin/Release/net9.0 .
ENTRYPOINT ["dotnet", "MicroserviceDemoUserService.dll"]