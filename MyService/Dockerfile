#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["MyService/MyService.csproj", "MyService/"]
RUN dotnet restore "MyService/MyService.csproj"
COPY . .
WORKDIR "/src/MyService"
RUN dotnet build "MyService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MyService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MyService.dll"]