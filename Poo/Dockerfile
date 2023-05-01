FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Poo/Poo.csproj", "Poo/"]
RUN dotnet restore "Poo/Poo.csproj"
COPY . .
WORKDIR "/src/Poo"
RUN dotnet build "Poo.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Poo.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Poo.dll"]
