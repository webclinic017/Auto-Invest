#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Auto-Invest/Auto-Invest.csproj", "Auto-Invest/"]
RUN dotnet restore "Auto-Invest/Auto-Invest.csproj"
COPY . .
WORKDIR "/src/Auto-Invest"
RUN dotnet build "Auto-Invest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Auto-Invest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Auto-Invest.dll"]