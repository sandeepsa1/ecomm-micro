# Use .NET 9 SDK for building
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

# Copy everything and build
COPY . . 
RUN dotnet publish -c Release -o out

# Use .NET 9 runtime for the final container
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/out . 
ENTRYPOINT ["dotnet", "product-service.dll"]
