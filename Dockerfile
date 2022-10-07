# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY utn_devops/*.csproj ./utn_devops/
RUN dotnet restore

# copy everything else and build app
COPY utn_devops/. ./utn_devops/
WORKDIR /source/utn_devops
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["dotnet", "utn_devops.dll"]