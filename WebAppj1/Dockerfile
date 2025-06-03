FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
# Copia solo el .csproj primero (mejora caching de Docker)
COPY ["WebAppj1.csproj", "WebAppj1/"]
RUN dotnet restore "WebAppj1/WebAppj1.csproj"

# Copia el resto y publica
RUN ls
COPY . "WebAppj1/"]
WORKDIR "/src/WebAppj1"
RUN ls
RUN dotnet publish "WebAppj1.csproj" -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WebAppj1.dll"]