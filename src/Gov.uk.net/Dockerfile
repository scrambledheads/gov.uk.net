#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Gov.uk.net/Gov.uk.net.csproj", "Gov.uk.net/"]
RUN dotnet restore "Gov.uk.net/Gov.uk.net.csproj"
COPY . .
WORKDIR "/src/Gov.uk.net"
RUN dotnet build "Gov.uk.net.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Gov.uk.net.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Gov.uk.net.dll"]