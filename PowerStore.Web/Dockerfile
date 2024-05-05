FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
RUN apt-get update -qq && apt-get -y install libgdiplus libc6-dev

EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["PowerStore.Web/PowerStore.Web.csproj", "PowerStore.Web/"]
COPY ["PowerStore.Framework/PowerStore.Framework.csproj", "PowerStore.Framework/"]
COPY ["PowerStore.Domain/PowerStore.Domain.csproj", "PowerStore.Domain/"]
COPY ["PowerStore.Core/PowerStore.Core.csproj", "PowerStore.Core/"]
COPY ["PowerStore.Services/PowerStore.Services.csproj", "PowerStore.Services/"]
COPY ["PowerStore.Api/PowerStore.Api.csproj", "PowerStore.Api/"]
RUN dotnet restore "PowerStore.Web/PowerStore.Web.csproj"
COPY . .
WORKDIR "/src/PowerStore.Web"
RUN dotnet build "PowerStore.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PowerStore.Web.csproj" -c Release -o /app/publish


FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .

RUN chmod 755 /app/Rotativa/Linux/wkhtmltopdf

ENTRYPOINT ["dotnet", "PowerStore.Web.dll"]