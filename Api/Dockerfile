# Create a docker image for the API
# Use the official dotnet core 7.0 sdk image

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build-env
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY Api/*.csproj ./Api/
COPY Library/*.csproj ./Library/
RUN dotnet restore Api/Api.csproj

# Copy everything else and build
COPY Api/. ./Api/
COPY Library/. ./Library/
RUN dotnet publish Api/ -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Api.dll"]