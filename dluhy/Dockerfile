#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["dluhy/dluhy.csproj", "dluhy/"]
RUN dotnet restore "dluhy/dluhy.csproj"
COPY . .
WORKDIR "/src/dluhy"
RUN dotnet build "dluhy.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "dluhy.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "dluhy.dll"]