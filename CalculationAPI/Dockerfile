#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["CalculationAPI/CalculationAPI.csproj", "CalculationAPI/"]
RUN dotnet restore "CalculationAPI/CalculationAPI.csproj"
COPY . .
WORKDIR "/src/CalculationAPI"
RUN dotnet build "CalculationAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CalculationAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CalculationAPI.dll"]