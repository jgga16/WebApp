FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
# Copia solo el .csproj primero (mejora caching de Docker)
COPY ["WebAppj1.csproj", "WebAppj1/"]
RUN dotnet restore "WebAppj1/WebAppj1.csproj"

# Copia el resto y publica
COPY . .
WORKDIR "/src/WebAppj1"
RUN ls
RUN dotnet publish "WebAppj1.csproj" -c Release -o /app/publish --no-restore

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "WebAppj1.dll"]