#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Football_manager.csproj", "."]
RUN dotnet restore "./Football_manager.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Football_manager.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Football_manager.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
CMD ASPNETCORE_URLS=http://*:$PORT dotnet Football_manager.dll
#ENTRYPOINT ["dotnet", "WebApplication5.dll"]